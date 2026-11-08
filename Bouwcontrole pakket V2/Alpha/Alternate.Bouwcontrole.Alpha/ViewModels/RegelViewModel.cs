using Alternate.Bouwcontrole.Alpha.Models;

namespace Alternate.Bouwcontrole.Alpha.ViewModels;

public class RegelViewModel
{
    public string Artikelcode { get; set; } = "";
    public string KrakenId { get; set; } = "";
    public string Naam { get; set; } = "";
    public Ernst Ernst { get; set; }
}
