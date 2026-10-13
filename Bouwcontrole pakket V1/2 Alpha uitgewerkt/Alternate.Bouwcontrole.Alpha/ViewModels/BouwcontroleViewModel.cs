namespace Alternate.Bouwcontrole.Alpha.ViewModels;

public class BouwcontroleViewModel
{
    public string? Scan { get; set; }
    public string? ScanMelding { get; set; }
    public List<string> Gescand { get; set; } = new();
    public List<RegelViewModel> Regels { get; set; } = new();
    public List<string> ConflictenTussenOnderdelen { get; set; } = new();
    public List<string> OntbrekendeArtikels { get; set; } = new();
}
