namespace Alternate.Bouwcontrole.API.Models
{
    public class Werkgeheugen
    {
        // Attributes && properties
        public int KrakenId { get; set; }
        public string Brand { get; set; } = "";
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";
        public int module { get; set; }
        public int Capaciteit { get; set; }

        // Constructor
        public Werkgeheugen(int krakenId, string brand, string name, string type, int module, int capaciteit)
        {
            this.KrakenId = krakenId;
            this.Brand = brand;
            this.Name = name;
            this.Type = type;
            this.module = module;
            this.Capaciteit = capaciteit;
        }

        // Methods

    }
}
