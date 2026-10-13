# Takenlijst Bouwcontrole

Stappenplan in taken · met tijdsinschatting · V1 · 13 oktober 2026

Word-versie: `Takenlijst Bouwcontrole V1.docx`. Afvinkbaar: het HTML-project in `Takenlijst Bouwcontrole V1.zip`, met de voortgang in de browser (sleutel `takenlijst-bouwcontrole-v1`) en een back-up als JSON.

Regel: de lijst zegt wat er moet gebeuren, nooit hoe. Geen code, geen signatures, geen veldenlijsten. De enige uitzondering is de alpha: daar staat op jouw vraag code bij, in de brainstorm.

Gebaseerd op docs/stappenplan.md, docs/projectafspraken.md, de brainstorm over de alpha, de oefeningen van hoofdstuk 02 tot 09 en je repo PJPRORL/Alternate.Bouwconflicten (laatste commit 30 september 2026).

## T · Tijdsinschatting

Hoe lang het duurt aan 6 uur per week, gebaseerd op de cursus.

**Oordeel**

- **Werkende alpha:** 9 tot 12 uur, dus twee weken. Begin je nu, dan staat hij er eind oktober.
- **Demo, einde fase 11:** 56 tot 81 uur. Aan 6 uur per week tussen half en eind januari 2027. Realistisch, met de examens van januari: februari 2027.
- **Project af, einde fase 15:** 30 tot 46 uur extra. Eind mei 2027, kort na de laatste les van .NET Development.

### Mijlpalen

| Mijlpaal | Eigen werk | Weken bij 6 u | Aan 6 u per week | Realistisch |
|---|---|---|---|---|
| Werkende alpha | 9–12 u | 1½–2 | eind oktober 2026 | begin november 2026 |
| Demo (einde fase 11) | 56–81 u | 9–14 | half tot eind januari 2027 | februari 2027 |
| Project af (einde fase 15) | 30–46 u extra | 5–8 | na de laatste les van .NET Development | eind mei 2027 |

Met de alpha eerst schuift de demo twee weken op. Elke week die je in de examenperiode niet aan het project werkt, schuift ze nog een week op.

### Waar de rem zit

- **Deel 1: je eigen tijd remt, niet de school.** Het project staat volgens de repo op fase 1, de les op 04. Je loopt dus drie fases achter. Tot begin januari heb je zo'n 70 uur, en deel 1 vraagt er 56 tot 81. Tussen eind november en de jaarwisseling haal je de lessen in. Enkel aan de ondergrens kan les 09 je daarna nog even laten wachten.
- **Deel 2: de school remt, niet jij.** 30 tot 46 uur, gespreid over februari tot mei, laat ruimte over. Die kan naar het databaseproject, de scraper of de open vragen uit het ontwerp.

### Hoe gerekend

- Per fase is de samengestelde oefening (●●●) van dat hoofdstuk de maat. Die past een hele les toe op een bestaande API, en dat is wat je per fase met Bouwcontrole doet.
- Voor je eigen domein maal 2 tot 3: meer onderdeeltypes, geen vaste startgegevens, eigen beslissingen en geen nakijkscript. Fase 7 maal 4 tot 6: alle types, de conflictregels, overerving die in geen cursus staat, en de seeding.
- Fases zonder oefening (0, 1, 2, 11 en heel deel 2) zijn een eigen schatting.
- Gerekend met 6 uur per week. De les lezen en de oefeningen maken tellen niet mee: die doe je voor school. Enkel bij de alpha telt het lezen mee, omdat je daar vooruitloopt.
- Vakanties zijn niet apart gerekend. De datums zijn een schatting, geen belofte.

### Uren per fase

| Fase | Les | Maat (●●●) | Factor | Schatting |
|---|---|---|---|---|
| 0 · Opruimen | — | — | eigen schatting | 1–2 u |
| 1 · Het project draait | PA 01 | — | eigen schatting | 1–2 u |
| 2 · Analyse | — | — | eigen schatting | 3–5 u |
| 3 · Modellen en CRUD | PA 02 | 02_06 · ±2 u | ×2–3 | 4–6 u |
| 4 · Repository, DI, logging | PA 03 | 03_06 · ±2 u | ×2–2,5 | 4–5 u |
| 5 · Docker en database | PA 04 | 04_06 · ±2 u | ×2–3 | 4–6 u |
| 6 · Echte repository en async | PA 05 | 05_06 · ±2 u | ×2–3 | 4–6 u |
| 7 · Hiërarchie, regels, seeding | PA 06 | 06_06 · ±2,5 u | ×4–6 | 10–15 u |
| 8 · Generics en Unit of Work | PA 07 | 07_06 · ±2,5 u | ×2–2,5 | 5–6 u |
| 9 · Gerelateerde data | PA 08 | 08_06 · ±2,5 u | ×1,5–2 | 4–5 u |
| 10 · DTO's en Mapster | PA 09 | 09_06 · ±3 u | ×2–2,5 | 6–8 u |
| 11 · Engine en demo | — | — | eigen schatting | 10–15 u |
| Deel 1 samen |  |  |  | 56–81 u |
| Alpha | ND 09–10 | — | eigen schatting | 9–12 u |
| 12 · Tests | ND 08 | — | eigen schatting | 8–12 u |
| 13 · Identity | ND 06–07 | — | eigen schatting | 8–12 u |
| 14 · Het scherm | ND 09–10 | — | eigen schatting | 8–12 u |
| 15 · Keuzelijsten en rechten | ND 11 | — | eigen schatting | 6–10 u |
| Deel 2 samen |  |  |  | 30–46 u |
| Alles samen |  |  |  | 86–127 u, met alpha 95–139 u |

Afgerond op hele uren. PA is Programming Advanced, ND is .NET Development.

## V · Voorbereiding

Wat je regelt voor je verder bouwt. Weinig werk, maar zonder kloppen de inschatting en de volgorde niet.

### Stand van zaken

- [ ] **V01** Push je lokale werk naar GitHub. — De laatste commit dateert van 30 september. Deze lijst en de inschatting gaan uit van wat daar staat. Ben je lokaal verder, dan schuift alles in je voordeel op. *(Repo · stand 30 september)*
- [ ] **V02** Vink in deel 1 af wat al klaar is. — Zo zie je meteen hoeveel je achterloopt op de lessen. Op school staat de les op 04, het project volgens de repo op fase 1. *(Repo · lesrooster)*

### Planning

- [ ] **V03** Leg de lesdata naast je projecttijd. — Programming Advanced: laatste les en examen begin januari. .NET Development: laatste les in mei, examen in juni. Met 6 uur per week heb je tot begin januari zo'n 70 uur. *(Jouw planning)*
- [ ] **V04** Kies wanneer je de alpha bouwt. — De alpha kost 9 tot 12 uur: twee weken van je projecttijd, en de demo schuift evenveel op. Nu bouwen geeft je team iets om op te reageren. Na de demo kost hij je in deel 1 niets. *(Tijdsinschatting)*

## A · Alpha in Razor

Een los prototype van het ene scherm, om met je team te testen. Klaar wanneer scenario 1 tot 3 op het scherm geven wat je verwacht, en je team de vijf scenario's doorlopen heeft.

### Opzetten

- [ ] **A01** Maak het project Alternate.Bouwcontrole.Alpha. — Met het sjabloon ASP.NET Core Web App (Model-View-Controller), op .NET 10, in een eigen solution naast je cursussolution. Niet via Add → New Project in je cursussolution. *(Brainstorm · Variant: start in Razor)*
- [ ] **A02** Pak het lege sjabloon uit in de projectmap. — Doe daarna de vier stappen uit de LEESMIJ. Eerst de @using in _ViewImports, anders bouwt de view niet. *(Bouwcontrole Alpha sjabloon V1 · LEESMIJ)*
- [ ] **A03** Lees .NET Development les 09 en 10 in grote lijnen. — Controllers met views, de layout, routing en ViewModels. Genoeg om te begrijpen wat je bouwt. De echte toepassing volgt in fase 14. *(ND les 09–10)*

### Invullen

- [ ] **A04** Vul de modellen en de ViewModels in. — Wat het scherm toont: artikelcode, Kraken-Id, naam en een ernst per regel, plus de meldingen. *(Brainstorm · Wat de alpha moet tonen)*
- [ ] **A05** Vul de onderdelenservice met verzonnen artikels. — Met minstens de NZXT-gevallen uit de vijf scenario's en een behuizing. *(Brainstorm · Scenario's)*
- [ ] **A06** Laat de controller een scan ontvangen en de order opnieuw opbouwen. — Elke scan is een formulier dat naar dezelfde actie gaat, met de vorige scans als verborgen velden. *(Brainstorm · Hoe het scannen werkt)*
- [ ] **A07** Bouw de view met de vier zones en de twee conflictvakken. — Zoals de eerste mockup. De kleur blijft een beslissing van het scherm. *(Brainstorm · mockup)*
- [ ] **A08** Boots de NZXT-controle na. — Begin met scenario 3: alleen losse fans. *(Brainstorm · Jouw volgende stuk)*

### Testen met het team

- [ ] **A09** Test met de echte scanner. — De meeste USB-scanners typen de code als een toetsenbord en sluiten af met Enter. *(Brainstorm · Stappen)*
- [ ] **A10** Loop de vijf scenario's door met je team. — Noteer bij scenario 4 wat het team verwacht. Dat weet de werkvloer beter dan de software. *(Brainstorm · Scenario's)*
- [ ] **A11** Vul de open vragen in de brainstorm in. — Welke artikels nog een verplichte partner hebben, melding of blokkade, en hoe het team "hetzelfde type" herkent. *(Brainstorm · Open vragen voor het team)*

## P · Deel 1 · Programming Advanced, tot de demo

Fase 0 tot 11 uit het stappenplan. Lees per fase eerst de les. Wanneer een fase klaar is, staat bij haar laatste taak.

### Fase 0 · Opruimen · geen les · ±1–2 u

- [ ] **P01** Draai de projectreferentie om. — Nu verwijst je webproject naar je testproject. Het hoort omgekeerd: het testproject verwijst naar het webproject. Anders ziet je testproject je klassen niet, en sleept je applicatie de testpakketten mee. *(Stappenplan fase 0 · .csproj)*
- [ ] **P02** Haal Scalar uit het testproject. — Een testproject heeft geen API-pagina nodig. *(Tests .csproj)*
- [ ] **P03** Laat het ERD-bestand voorlopig liggen. — Het is nog het lege sjabloon. Je databaseproject levert het nieuwe ERD, na de beoordeling. *(Takenlijst databaseproject · B03)*

### Fase 1 · Het project draait · les 01 · ±1–2 u

- [ ] **P04** Maak het project weer compileerbaar. — In ProductController is de declaratie van de lijst niet afgesloten. Zolang dat zo is, bouwt het hele project niet. *(ProductController · stand 30 september)*
- [ ] **P05** Gooi het weer-voorbeeld weg. — WeatherForecast en zijn controller. *(Stappenplan fase 1)*
- [ ] **P06** Maak één eigen endpoint dat antwoordt. — Klaar wanneer: je klikt het aan in Scalar en krijgt antwoord. *(Stappenplan fase 1)*

### Fase 2 · Analyse · geen les · ±3–5 u

- [ ] **P07** Beslis de twee open vragen over de types. — Lucht- en waterkoeling, HDD en SSD: twee types, of twee soorten van één type? *(Jouw analyse · ontwerp-bouwcontrole)*
- [ ] **P08** Leg bij elke eigenschap de conflictregel die ze nodig heeft. — Een eigenschap zonder regel hoort niet in je model. *(Stappenplan fase 2 · conflictanalyse V2)*
- [ ] **P09** Neem de verplichte begeleidende artikels mee. — Een regel die vuurt op iets dat ontbreekt, zoals losse NZXT-fans zonder controller. Welke eigenschap heeft die regel nodig? *(Brainstorm · Plaats in het ontwerp)*
- [ ] **P10** Vul de vertaaltabel in. — Op de rollen na die pas in les 06 duidelijk worden. Klaar wanneer: elke eigenschap heeft haar regel, en de tabel is ingevuld. *(docs/vertaaltabel.md)*

### Fase 3 · Modellen en CRUD · les 02 · ±4–6 u

- [ ] **P11** Breng je modellen in lijn met je keuze voor een abstracte basisklasse. — In de repo is Onderdeel nog leeg en niet abstract, en erven de types er niet van. *(Hoofdmodel Onderdeel · stand 30 september)*
- [ ] **P12** Kies één onderdeeltype voor deze fase. — Eén type volstaat om het patroon te leren. *(Stappenplan fase 3)*
- [ ] **P13** Maak data.json geldig. — Nu ontbreken er waarden, en is Moederbord een lijst terwijl de andere types een enkel object zijn. Groepeer per onderdeeltype, en geef elk type dezelfde vorm. *(Stappenplan fase 3 · voorwaarde 1)*
- [ ] **P14** Bouw de volledige CRUD op dat ene type. — Met de juiste statuscodes. De tabel staat in les 02. *(PA les 02)*
- [ ] **P15** Beslis wat er gebeurt met een onderdeel dat uit de handel gaat. — Soft of hard delete: er hangen straks conflictregels aan. Klaar wanneer: aanmaken, opvragen, wijzigen en verwijderen werken via Scalar, met de juiste code. *(Stappenplan fase 3 · valkuil)*

### Fase 4 · Repository, DI en logging · les 03 · ±4–5 u

- [ ] **P16** Haal het lezen van je JSON achter een interface. — Met een implementatie die het bestand leest. *(PA les 03 · stappenplan fase 4)*
- [ ] **P17** Laat de controller de interface via zijn constructor krijgen. — Maakt je controller zelf een repository aan, dan is de oefening gemist. *(Stappenplan fase 4 · valkuil)*
- [ ] **P18** Voeg logging toe. — Klaar wanneer: alles werkt zoals in fase 3, en je controller bevat geen enkele regel over data. *(PA les 03)*

### Fase 5 · Docker en database · les 04 · ±4–6 u

- [ ] **P19** Zet PostgreSQL en pgAdmin op met Docker Compose. — Docker moet draaien voor je de database bijwerkt. *(PA les 04)*
- [ ] **P20** Koppel je project aan de database. — Packages, connectiestring, een databasecontext met je ene model, en de registratie. *(PA les 04 · stappenplan fase 5)*
- [ ] **P21** Maak de eerste migratie en voer ze uit. — Pas de database nooit met de hand aan. Klaar wanneer: je tabel staat in pgAdmin. *(PA les 04 · valkuil)*

### Fase 6 · De echte repository en async · les 05 · ±4–6 u

- [ ] **P22** Schrijf een tweede implementatie van je interface, tegen de databasecontext. — Wisselen doe je met één registratie. Je JSON blijft, als bron voor de seeding. *(PA les 05 · stappenplan fase 6)*
- [ ] **P23** Maak daarna de hele keten async. — Niet tegelijk met de overstap naar de database, en breek de keten nergens. Klaar wanneer: je data overleeft een herstart, en er staat geen synchrone databaseoproep meer. *(PA les 05)*

### Fase 7 · Hiërarchie, conflictregels en seeding · les 06 · ±10–15 u

- [ ] **P24** Maak de overige onderdeeltypes als modellen. — Op basis van fase 2. *(Stappenplan fase 7)*
- [ ] **P25** Beslis hoe je de overerving naar tabellen vertaalt. — Geen van beide cursussen behandelt dit. H12 van het vak Database bespreekt overerving als special topic, met de opties naast elkaar. *(Ontwerp sectie 5 · Database H12)*
- [ ] **P26** Modelleer de conflictregels als een verzameling voorwaarden. — Ook de nieuwe soort uit de brainstorm: een regel over iets dat ontbreekt. *(Stappenplan fase 7 · brainstorm)*
- [ ] **P27** Leg de relaties vast met de Fluent API, met het verwijdergedrag. — Denk na over wat er met een conflictregel gebeurt als een onderdeel verdwijnt. *(PA les 06 · valkuil)*
- [ ] **P28** Seed genoeg regels voor een echte bouworder. — Twee regels bewijzen dat het werkt, maar overtuigen niemand op je werk. *(Stappenplan fase 7)*
- [ ] **P29** Maak de migratie en voer ze uit. — Klaar wanneer: een handvol regels uit je lijst staat als data in je database. *(Stappenplan fase 7)*

### Fase 8 · GenericRepository en Unit of Work · les 07 · ±5–6 u

- [ ] **P30** Bouw een generieke repository met specifieke repositories erbovenop. — Specifiek alleen waar een model echt iets extra nodig heeft. *(PA les 07)*
- [ ] **P31** Laat de Unit of Work centraal opslaan, en geef ze aan je controllers. — Klaar wanneer: je controllers vragen nog maar één ding op in hun constructor. *(PA les 07 · stappenplan fase 8)*

### Fase 9 · Gerelateerde data · les 08 · ±4–5 u

- [ ] **P32** Haal een conflict met al zijn voorwaarden in één keer op. — In de specifieke repository, niet in de generieke. *(PA les 08)*
- [ ] **P33** Laat de tijdelijke oplossing voor cycli tijdelijk. — Ze verdwijnt in fase 10. Dapper heb je niet nodig. Klaar wanneer: geen reeks losse vragen meer naar de database voor één conflict. *(PA les 08 · stappenplan fase 9)*

### Fase 10 · DTO's en Mapster · les 09 · ±6–8 u

- [ ] **P34** Maak aparte DTO's voor wat je terugstuurt en wat je ontvangt. — De validatie verhuist naar de DTO's die binnenkomen. Een DTO bevat nooit een model. *(PA les 09)*
- [ ] **P35** Installeer en configureer Mapster. — Niet AutoMapper: een andere syntax, en commercieel. *(PA les 09 · projectafspraken §6)*
- [ ] **P36** Haal de tijdelijke oplossing voor cycli weg. — Klaar wanneer: elk endpoint ontvangt en geeft een DTO. *(Stappenplan fase 10)*

### Fase 11 · De conflict-engine en je demo · geen les · ±10–15 u

- [ ] **P37** Beantwoord eerst de twee vragen uit het stappenplan. — Wat moet de engine teruggeven zodat het scherm weet welke regel het kleurt? En vuurt een conflict met twee voorwaarden als maar één onderdeel aan allebei voldoet? *(Stappenplan fase 11)*
- [ ] **P38** Schrijf de engine als gewone klasse in je Services-laag. — Geen database en geen HTTP erin, anders kan je hem in fase 12 niet testen. *(Stappenplan fase 11)*
- [ ] **P39** Maak het endpoint dat een bouworder aanneemt. — Kies zelf het verb: er staat geen tabel achter. *(Stappenplan fase 11)*
- [ ] **P40** Controleer met de hand tegen gevallen waarvan je het antwoord kent. — Uit je incompatibiliteitenlijst. *(Stappenplan fase 11)*
- [ ] **P41** Laat iemand anders een bouworder kiezen voor je de demo toont. — Klaar wanneer: een bouworder via Scalar geeft de juiste conflicten terug. *(Stappenplan fase 11 · valkuil)*

## N · Deel 2 · .NET Development

Fase 12 tot 15. Hier remt de school, niet je eigen tijd. Plan ze per les zodra je de lesdata kent (Q01).

### Fase 12 · Tests rond de engine · ND les 08 · ±8–12 u

- [ ] **N01** Richt het testproject in met NUnit en Moq. — Het staat klaar sinds fase 0. *(ND les 08)*
- [ ] **N02** Leid je testgevallen af uit je incompatibiliteitenlijst, niet uit je code. — Je test wat er hoort te gebeuren, niet wat je engine toevallig doet. *(Stappenplan fase 12)*
- [ ] **N03** Vind je een fout: eerst de test die faalt, dan pas herstellen. — Klaar wanneer: je tests zijn groen, met minstens één geval dat je in fase 11 niet met de hand probeerde. *(Stappenplan fase 12)*

### Fase 13 · Identity, gebruikers en rollen · ND les 06–07 · ±8–12 u

- [ ] **N04** Beslis wie op de werkvloer wat mag. — Een van de open vragen uit het ontwerp. *(Ontwerp · open vragen)*
- [ ] **N05** Voeg Identity toe, met een eigen gebruikersmodel en rollen. — Neem de instellingen die in les 06 een fout in .NET 8 omzeilen niet blind over. *(ND les 06–07 · stappenplan fase 13)*
- [ ] **N06** Scherm je endpoints af. — Geen wachtwoorden die hard in je code blijven staan. Klaar wanneer: zonder token weigert een afgeschermd endpoint. *(Stappenplan fase 13)*

### Fase 14 · Het scherm · ND les 09–10 · ±8–12 u

- [ ] **N07** Voeg MVC toe aan hetzelfde project. — De tweede manier uit les 09: front-end en back-end in één applicatie. *(ND les 09)*
- [ ] **N08** Bouw het scherm opnieuw, in je eigen code. — Neem uit de alpha de feedback van je team en de indeling mee, niet de code. Het project zelf maak je volledig zelf. *(Projectafspraken §5 · brainstorm)*
- [ ] **N09** Zet je ViewModels in een eigen map, en laat de kleur een beslissing van het scherm. — Klaar wanneer: een reeks scans toont per onderdeel de juiste kleur, en onderaan de conflicten. *(Stappenplan fase 14)*

### Fase 15 · Keuzelijsten, aanmelden en rechten · ND les 11 · ±6–10 u

- [ ] **N10** Voeg keuzelijsten en de aanmeld- en beheerschermen toe. — Rolnamen moeten exact overeenkomen met de database. *(ND les 11 · valkuil)*
- [ ] **N11** Stel in waar iemand zonder rechten terechtkomt. — Een knop verbergen is geen beveiliging. Klaar wanneer: zonder beheerrechten lukt controleren, maar regels wijzigen niet. *(Stappenplan fase 15)*

## Q · Open vragen

Wat de inschatting en de volgorde nog kan verschuiven. Vink af wanneer je het antwoord hebt, en noteer het erbij.

### Te beantwoorden

- [ ] **Q01** Wanneer starten de lessen van .NET Development, en wanneer vallen les 06 tot 11? — De inschatting gaat uit van februari tot mei. *(Canvas)*
- [ ] **Q02** Wissel je fase 12 en 13? — De cursus geeft Identity (les 06–07) voor testen (les 08). Het stappenplan zet de tests eerst. Volg je de lessen strikt, dan komt fase 13 eerst. Beslis het voor deel 2 begint. *(Stappenplan · projectafspraken §1)*
- [ ] **Q03** Bestaat les 10 van Programming Advanced (Unit testing), en wanneer valt ze? — Ze is nog niet aangeleverd. Valt ze in januari, dan kan fase 12 al in deel 1. *(Projectafspraken §3)*
- [ ] **Q04** Wanneer vallen de deadlines van het databaseproject? — Dat project loopt in dezelfde weken als fase 5 tot 10, en de inschatting rekent het niet mee. *(Takenlijst databaseproject · V01)*
- [ ] **Q05** Hoeveel uur werk je aan Bouwcontrole tijdens de examens van januari? — Tel elke week die je overslaat op bij de datum van de demo. *(Tijdsinschatting)*
