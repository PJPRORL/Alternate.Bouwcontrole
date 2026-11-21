namespace Alternate.Bouwcontrole.API.Models
{
    public abstract class Voeding
    {
        public string FormFactor { get; set; } = "";
        public int Lengte { get; set; }
        public int Vermogen { get; set; }
        public string Kleur { get; set; } = "";
    }
}
