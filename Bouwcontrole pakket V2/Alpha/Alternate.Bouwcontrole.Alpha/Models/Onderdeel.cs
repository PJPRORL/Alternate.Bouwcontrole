namespace Alternate.Bouwcontrole.Alpha.Models;

public class Onderdeel
{
    public string KrakenId { get; set; } = "";
    public string Artikelcode { get; set; } = "";
    public string Naam { get; set; } = "";
    public string Type { get; set; } = "";
    public string? Reeks { get; set; }
    public bool ControllerMeegeleverd { get; set; }
}
