# Leeg sjabloon Bouwcontrole-alpha

Lege bestanden en klassen voor de Razor-alpha. De uitgewerkte versie staat in de
brainstorm, in de sectie "Variant: start in Razor", en als volledig project in de
map `2 Alpha uitgewerkt`.

## Zo zet je het in je project

1. Maak het project met het sjabloon *ASP.NET Core Web App (Model-View-Controller)*
   op .NET 10 en noem het `Alternate.Bouwcontrole.Alpha`.
2. Kopieer de inhoud van de map `Alternate.Bouwcontrole.Alpha` hiernaast naar de
   map waarin het `.csproj`-bestand staat. Laat Windows de mappen samenvoegen met
   de mappen die er al zijn.
3. Visual Studio neemt de nieuwe bestanden vanzelf op.

## Wat nog buiten deze bestanden moet gebeuren

- `Views/_ViewImports.cshtml`: een `@using` voor de ViewModels. Doe dit vóór je
  de eerste keer bouwt: de view kent het ViewModel anders niet, en dat geeft een
  compileerfout.
- `Program.cs`: de twee services registreren, en de standaardroute laten starten
  bij Bouwcontrole in plaats van bij Home.
- `Views/Shared/_Layout.cshtml`: het `header`-blok met de navigatiebalk en het
  `footer`-blok weghalen.
- `wwwroot/css/site.css`: de CSS uit de brainstorm.

## Goed om te weten

- `GlobalUsings.cs` werkt alleen voor `.cs`-bestanden. Views halen hun usings
  uit `_ViewImports.cshtml`.
- Met `GlobalUsings.cs` mag je de `using`-regels bovenaan de uitgewerkte versie
  in de brainstorm weglaten.
- Laat `HomeController` en `Models/ErrorViewModel.cs` uit het sjabloon staan. De
  foutpagina van het sjabloon gebruikt ze.
- De map van de view moet heten zoals de controller zonder "Controller", en het
  bestand zoals de actie. Zo vindt MVC `Views/Bouwcontrole/Index.cshtml` bij
  `BouwcontroleController` en de actie `Index`.
