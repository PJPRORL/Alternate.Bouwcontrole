namespace Alternate.Bouwcontrole.API.Models
{
    public class Processor
    {
        //API: Manual for Icecat Push-API (API-IN) - https://iceclog.com/manual-for-icecat-push-api-api-in/ - https://icecat.com/data-capture/ - https://icecat.biz/

        // Attributes && Properties
        public int KrakenId { get; set; }

        public string Brand { get; set; } = "";

        public string Name { get; set; }

        public string Socket { get; set; } = "";

        public string Chipset { get; set; } = "";

        public int TDP { get; set; }

        public Boolean Accessoire { get; set; }

        // Constructor
        public Processor(int krakenId, string brand, string name, string socket, string chipset, int tdp, Boolean accessoire)
        {
            KrakenId = krakenId;
            Brand = brand;
            Name = name;
            Socket = socket;
            Chipset = chipset;
            TDP = tdp;
            Accessoire = accessoire;
        }

        // Methods

    }
}
