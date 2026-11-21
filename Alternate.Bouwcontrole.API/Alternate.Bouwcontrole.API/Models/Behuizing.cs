namespace Alternate.Bouwcontrole.API.Models
{
    public abstract class Behuizing: Onderdeel
    {
        public string FormFactor { get; set; } = "";
        public int Koelerhoogte { get; set; }
        public int Kaartlengte { get; set; }
        public int AantalPcieBrackets { get; set; }
        public int FormaatRadiator { get; set; }
        public int FormaatVentilator { get; set; }
        public int AantalVentilator { get; set; }
        public int MeegeleverdeVentilator { get; set; }
        public int LengteVoeding { get; set; }
        public string FormfactorVoeding { get; set; } = "";
        public string kleur { get; set; } = "";
    }
}
