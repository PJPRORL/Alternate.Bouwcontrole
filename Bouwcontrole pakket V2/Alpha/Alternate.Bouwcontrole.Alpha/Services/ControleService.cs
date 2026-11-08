using Alternate.Bouwcontrole.Alpha.Models;

namespace Alternate.Bouwcontrole.Alpha.Services;

public class ControleService : IControleService
{
    public List<string> ControleerTussenOnderdelen(List<Onderdeel> order)
    {
        var meldingen = new List<string>();
        // Jouw stuk: twee onderdelen die niet bij elkaar passen
        return meldingen;
    }

    public List<string> ControleerOntbrekend(List<Onderdeel> order)
    {
        var meldingen = new List<string>();
        // Jouw stuk: het NZXT-geval, te beginnen met scenario 3
        return meldingen;
    }
}
