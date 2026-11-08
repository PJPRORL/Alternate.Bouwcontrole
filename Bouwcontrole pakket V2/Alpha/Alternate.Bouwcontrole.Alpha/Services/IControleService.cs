using Alternate.Bouwcontrole.Alpha.Models;

namespace Alternate.Bouwcontrole.Alpha.Services;

public interface IControleService
{
    List<string> ControleerTussenOnderdelen(List<Onderdeel> order);
    List<string> ControleerOntbrekend(List<Onderdeel> order);
}
