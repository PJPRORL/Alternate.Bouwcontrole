using Alternate.Bouwcontrole.Alpha.Models;

namespace Alternate.Bouwcontrole.Alpha.Services;

public class OnderdelenService : IOnderdelenService
{
    // Verzonnen artikels, enkel voor de alpha
    private readonly List<Onderdeel> _onderdelen = new()
    {
        new() { KrakenId = "K-1001", Artikelcode = "ART-1001", Naam = "NZXT casefan, los",           Type = "casefan",    Reeks = "A" },
        new() { KrakenId = "K-1002", Artikelcode = "ART-1002", Naam = "NZXT casefan, triple pack",   Type = "casefan",    Reeks = "A", ControllerMeegeleverd = true },
        new() { KrakenId = "K-1003", Artikelcode = "ART-1003", Naam = "NZXT controller",             Type = "controller", Reeks = "A" },
        new() { KrakenId = "K-1004", Artikelcode = "ART-1004", Naam = "NZXT casefan, triple pack B", Type = "casefan",    Reeks = "B", ControllerMeegeleverd = true },
        new() { KrakenId = "K-2001", Artikelcode = "ART-2001", Naam = "Behuizing",                   Type = "behuizing" }
    };

    public Onderdeel? Zoek(string krakenId) =>
        _onderdelen.FirstOrDefault(o => o.KrakenId == krakenId);
}
