using Alternate.Bouwcontrole.Alpha.Models;

namespace Alternate.Bouwcontrole.Alpha.Services;

public interface IOnderdelenService
{
    Onderdeel? Zoek(string krakenId);
}
