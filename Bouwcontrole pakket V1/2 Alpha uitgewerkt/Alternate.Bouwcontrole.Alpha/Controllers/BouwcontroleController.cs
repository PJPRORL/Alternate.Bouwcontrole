using Alternate.Bouwcontrole.Alpha.Models;
using Alternate.Bouwcontrole.Alpha.Services;
using Alternate.Bouwcontrole.Alpha.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Alternate.Bouwcontrole.Alpha.Controllers;

public class BouwcontroleController : Controller
{
    private readonly IOnderdelenService _onderdelenService;
    private readonly IControleService _controleService;

    public BouwcontroleController(IOnderdelenService onderdelenService, IControleService controleService)
    {
        _onderdelenService = onderdelenService;
        _controleService = controleService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new BouwcontroleViewModel());
    }

    [HttpPost]
    public IActionResult Index(BouwcontroleViewModel invoer)
    {
        var model = new BouwcontroleViewModel { Gescand = invoer.Gescand };
        var scan = invoer.Scan?.Trim();

        if (!string.IsNullOrEmpty(scan))
        {
            if (_onderdelenService.Zoek(scan) != null)
                model.Gescand.Add(scan);
            else
                model.ScanMelding = $"Onbekende code: {scan}";
        }

        var order = new List<Onderdeel>();
        foreach (var krakenId in model.Gescand)
        {
            var onderdeel = _onderdelenService.Zoek(krakenId);
            if (onderdeel == null) continue;

            order.Add(onderdeel);
            model.Regels.Add(new RegelViewModel
            {
                Artikelcode = onderdeel.Artikelcode,
                KrakenId = onderdeel.KrakenId,
                Naam = onderdeel.Naam,
                Ernst = Ernst.InOrde // voorlopig, tot de controle dit beslist
            });
        }

        model.ConflictenTussenOnderdelen = _controleService.ControleerTussenOnderdelen(order);
        model.OntbrekendeArtikels = _controleService.ControleerOntbrekend(order);

        // Anders zet de tag helper de vorige scan terug in het scanveld
        ModelState.Clear();
        return View(model);
    }
}
