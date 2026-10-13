# Alpha uitgewerkt

De Razor-alpha uit de brainstorm, als volledig project voor Visual Studio. Alle code uit de sectie *Variant: start in Razor* staat erin, en de zeven stappen van die sectie zijn al gedaan.

> Dit valt onder de uitzondering voor de alpha: een los wegwerpproject, waarin code mag. Je cursusproject blijft volledig jouw werk.

## Openen

1. Pak de zip uit.
2. Dubbelklik op `Alternate.Bouwcontrole.Alpha.sln`.
3. Druk op F5. De browser opent meteen het scanscherm.

Kies je het profiel `https`, dan vraagt Visual Studio de eerste keer om een ontwikkelcertificaat te vertrouwen. Zeg ja, of kies het profiel `http`.

## Testcodes

| Kraken-Id | Artikel |
| --- | --- |
| `K-1001` | NZXT casefan, los |
| `K-1002` | NZXT casefan, triple pack (reeks A, met controller) |
| `K-1003` | NZXT controller |
| `K-1004` | NZXT casefan, triple pack B (reeks B, met controller) |
| `K-2001` | Behuizing |

Typ een code en druk op Enter, zoals de scanner doet. Een code die niet in de lijst staat, bijvoorbeeld `K-9999`, geeft de melding *Onbekende code*.

## Wat er al in zit

| Bestand | Uit de brainstorm |
| --- | --- |
| `Models/Onderdeel.cs`, `Models/Ernst.cs` | Models: het onderdeel en de ernst |
| `Services/IOnderdelenService.cs`, `Services/OnderdelenService.cs` | Services: verzonnen gegevens |
| `Services/IControleService.cs`, `Services/ControleService.cs` | Services: de nagebootste controle |
| `ViewModels/BouwcontroleViewModel.cs`, `ViewModels/RegelViewModel.cs` | ViewModels: wat het scherm nodig heeft |
| `Controllers/BouwcontroleController.cs` | Controllers: elke scan komt hier binnen |
| `Views/Bouwcontrole/Index.cshtml` | Views: het scherm |
| `Program.cs` | De twee services geregistreerd, de startroute op Bouwcontrole (stap 3) |
| `Views/_ViewImports.cshtml` | De `@using` voor de ViewModels (stap 4) |
| `Views/Shared/_Layout.cshtml` | Zonder header en footer (stap 5) |
| `wwwroot/css/site.css` | De CSS uit de HTML-versie, onder de CSS van het sjabloon (stap 6) |

De rest komt uit het MVC-sjabloon: `HomeController`, `ErrorViewModel` en de foutpagina.

## Wat nog jouw stuk is

Hetzelfde als *Jouw volgende stuk* in de brainstorm:

- `ControleerOntbrekend` in de `ControleService`: het NZXT-geval, te beginnen met scenario 3.
- `ControleerTussenOnderdelen` blijft voorlopig leeg.
- De controller zet elke regel op `InOrde`. Wat moeten de controles teruggeven zodat ook de juiste regel kleurt?

Tot dan blijven alle regels groen en de twee vakken leeg. Dat is zo bedoeld.

## Verschil met een nieuw project uit het sjabloon

- **Bootstrap komt via internet** (cdnjs), niet uit `wwwroot/lib`. Zonder internet werkt het scherm, maar met de standaardletters van de browser. Wil je het zoals het sjabloon: maak een nieuw MVC-project, kopieer de map `wwwroot/lib` hierheen en zet in `_Layout.cshtml` de oude link terug.
- jQuery en de validatiescripts zitten er niet in. De alpha gebruikt geen JavaScript.
- Het project werd hier niet gebouwd: in deze werkomgeving kon .NET niet geïnstalleerd worden. De eerste keer F5 is dus ook de eerste test. Geeft hij een fout, stuur dan de foutmelding door.
