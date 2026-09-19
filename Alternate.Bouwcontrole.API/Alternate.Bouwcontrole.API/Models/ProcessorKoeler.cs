namespace Alternate.Bouwcontrole.API.Models
{
    public class ProcessorKoeler
    {
        // Attributes && properties
        public int KrakenId { get; set; }

        public string Brand { get; set; } = "";

        public string Name { get; set; } = "";

        public string Type { get; set; } = "";

        public string Socket { get; set; } = "";

        public int TDP { get; set; }

        public int Aansluiting { get; set; }

        public int Afmeting { get; set; }

        // Constructor
        public ProcessorKoeler(int krakenId, string brand, string name, string type, string socket, int tdp, int aansluiting, int afmeting)
        {
            this.KrakenId = krakenId;
            this.Brand = brand;
            this.Name = name;
            this.Type = type;
            this.Socket = socket;
            this.TDP = tdp;
            this.Aansluiting = aansluiting;
            this.Afmeting = afmeting;
        }

        // Methods

    }
}
