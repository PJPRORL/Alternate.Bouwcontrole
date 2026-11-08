namespace Alternate.Bouwcontrole.API.Models
{
    public abstract class Moederbord : Onderdeel
    {
        // Attributes
        public string Socket { get; set; } = "";

        public string Chipset { get; set; } = "";

        public string Formfactor { get; set; } = "";

        public int MaximumSupportedMemorySize { get; set; }

        public int MemorySlots { get; set; }

        public string MemoryType { get; set; } = "";

        public string SupportedMemoryProfiles { get; set; } = "";

        public int PCIeSlots { get; set; }

        public string PCIeType { get; set; }

        public int SATAConnectors { get; set; }

        public List<string> M2Slots { get; set; } = new List<string>();

        public List<string> InternalUSB { get; set; } = new List<string>();
    }
}
