namespace Alternate.Bouwcontrole.API.Models
{
    public abstract class Onderdeel
    {
        public int Id { get; set; }
        public string Artikelcode { get; set; } = "";
        public string Brand { get; set; } = "";
        public string Name { get; set; } = "";
    }
}
