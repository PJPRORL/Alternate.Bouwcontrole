namespace Alternate.Bouwcontrole.API.Models
{
    public abstract class Casefan: Onderdeel
    {
        public int Afmeting { get; set; }
        public int Aantal { get; set; }
        public string VerlichtingsType { get; set; } = "";
        public bool ControllerMeegeleverd { get; set; } = false;
        public bool USBNoodzakelijk { get; set; } = false;
        public string Kleur { get; set; } = "";
    }
}
