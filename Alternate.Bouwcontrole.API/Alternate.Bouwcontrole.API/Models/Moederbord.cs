namespace Alternate.Bouwcontrole.API.Models
{
    public class Moederbord
    {
        // Attributes
        public int KrakenId { get; set; }

        public string Brand { get; set; } = "";

        public string Name { get; set; } = "";

        public string Socket { get; set; } = "";

        public string Chipset { get; set; } = "";

        public string Formfactor { get; set; } = "";

        public int SupportedMemorySize { get; set; }

        public int MemorySlots { get; set; }

        public string MemoryType { get; set; } = "";

        public int PCIeSlots { get; set; }

        public string PCIeType { get; set; }

        public int SATAConnectors { get; set; }

        public List<string> M2Slots { get; set; } = new List<string>();

        public List<string> InternalUSB { get; set; } = new List<string>();

        // Constructor
        public Moederbord(int krakenId, string brand, string name, string socket, string chipset, string formfactor, int supportedMemorySize, int memorySlots, string memoryType, int pcieSlots, string pcieType, int sataConnectors)
        {
            KrakenId = krakenId;
            Brand = brand;
            Name = name;
            Socket = socket;
            Chipset = chipset;
            Formfactor = formfactor;
            SupportedMemorySize = supportedMemorySize;
            MemorySlots = memorySlots;
            MemoryType = memoryType;
            PCIeSlots = pcieSlots;
            PCIeType = pcieType;
            SATAConnectors = sataConnectors;
        }

        // Methods

    }
}
