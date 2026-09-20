# Eigenschappen per onderdeeltype

Bouwcontrole — overzicht ter nazicht

20 september 2026

---

## Waar dit over gaat

Ik ben een hulpmiddel aan het bouwen dat gescande onderdelen uit een bouworder
controleert op bekende conflicten. Voor ik de gegevens vastleg, wil ik zeker zijn
dat ik per onderdeeltype de juiste eigenschappen bijhoud.

Hieronder staat wat ik nu per onderdeel wil opslaan. **Wat ik van jullie nodig
heb: wat mis ik?** Jullie bouwen deze systemen dagelijks en zien dingen misgaan
die ik niet bedacht heb.

## Eén regel die ik heb toegepast

Een eigenschap staat alleen in de lijst als er een controle van afhangt.

Een voorbeeld. De kloksnelheid van een processor staat groot op elke
productpagina, maar er is geen enkel ander onderdeel dat er iets mee te maken
heeft — dus die houd ik niet bij. Het warmtevermogen wél, want daar moet de
koeler tegen kunnen.

Dat is geen zuinigheid. Hoe meer ik bijhoud, hoe meer er verkeerd of verouderd in
staat, en hoe minder de meldingen te vertrouwen zijn.

Zie je dus iets ontbreken, zeg er dan bij **welke controle het zou dienen**. Dan
weet ik meteen of het erin hoort.

---

## Moederbord

- socket — bepaalt welke processor en welke koeler passen
- formfactor (ATX, mATX, ITX, E-ATX) — bepaalt in welke behuizing het past
- aansluitingen op de achterzijde, ja of nee — zo'n bord past alleen in een
  behuizing die daarvoor gemaakt is
- geheugentype, DDR4 of DDR5
- aantal geheugensloten
- aantal geheugenkanalen
- maximale geheugencapaciteit
- ondersteunde geheugenprofielen (XMP, EXPO of allebei)
- aantal SATA-poorten
- aantal ventilatoraansluitingen
- aantal interne USB-aansluitingen, per type — hier sluit de behuizing zijn
  frontpoorten op aan, en soms ook een ventilatorcontroller
- interne USB-C-aansluiting, ja of nee
- aantal verlichtingsaansluitingen, per type
- aantal CPU-stroomaansluitingen, per type
- kleur

Per M.2-slot afzonderlijk, omdat ze op één bord kunnen verschillen: welke
lengtes het slot toelaat, of het PCIe of SATA voert, en welke PCIe-generatie.

Twee dingen die ik niet van een productpagina krijg: welke processorgeneraties
het bord ondersteunt, en of het een BIOS-update aankan zonder dat er een
processor in zit.

---

## Processor

- socket
- generatie
- warmtevermogen — bepaalt of de koeler volstaat en telt mee voor de voeding
- officieel ondersteunde geheugensnelheid
- geïntegreerde grafische kern, ja of nee — zonder kaart in de order is er anders
  geen beeld
- kleur

---

## CPU-koeler

- lucht of waterkoeling
- ondersteunde sockets
- koelvermogen
- kleur

Bij luchtkoeling ook de hoogte, en de vrije ruimte boven de geheugensloten.

Bij waterkoeling de radiatormaat en de dikte van de radiator.

Het koelvermogen is lastig: er is geen afgesproken meetmethode, en fabrikanten
geven het vaak niet of te optimistisch op. Als jullie hier een eigen vuistregel
voor hanteren, hoor ik die graag.

---

## Geheugen

- geheugentype, DDR4 of DDR5
- capaciteit per module
- aantal modules in de set
- snelheid
- profieltype (XMP, EXPO, allebei of geen)
- set-aanduiding — om te zien of modules uit dezelfde verpakking komen
- hoogte van de module
- kleur

De hoogte staat bijna nooit op een productpagina, terwijl het botsen met een
brede luchtkoeler er volledig van afhangt. Weet iemand een betrouwbare bron,
graag.

---

## Videokaart

- lengte
- dikte, uitgedrukt in het aantal slotposities dat ze inneemt
- stroomverbruik
- stroomaansluitingen die ze vraagt, per type en aantal
- kleur

---

## SSD

- M.2 of SATA

Bij M.2: de lengte, of het een PCIe- of SATA-model is, en de PCIe-generatie.

Bij SATA: het formaat.

En de kleur, al zal die zelden zichtbaar zijn.

---

## HDD

- formaat, 3,5" of 2,5"
- kleur

Verder telt een HDD mee voor het aantal SATA-poorten en de stroomaansluitingen
van de voeding, maar daar is geen aparte eigenschap voor nodig.

---

## PC-behuizing

- ondersteunde formfactors
- geschikt voor borden met aansluitingen op de achterzijde, ja of nee
- maximale koelerhoogte
- maximale kaartlengte
- maximale kaartlengte wanneer er een radiator vooraan zit
- aantal uitbreidingsposities
- montageplaatsen per drive-formaat
- ondersteunde radiatormaten
- ondersteunde ventilatorafmetingen
- aantal ventilatorplaatsen
- aantal meegeleverde ventilatoren
- frontpoorten, per type
- USB-C-frontpoort, ja of nee
- ondersteunde voedingsformfactors
- maximale voedingslengte
- kleur

De kaartlengte mét radiator vooraan en de maximale voedingslengte staan zelden
vermeld. Behuizingen geven alleen het gunstigste getal.

---

## Voeding

- formfactor (ATX, SFX, SFX-L)
- lengte
- vermogen
- CPU-stroomaansluitingen, per type en aantal
- kaartaansluitingen, per type en aantal
- aantal SATA-stroomaansluitingen
- kleur

---

## Casefans

- afmeting, 120 of 140 mm
- aantal in de set
- verlichtingstype (geen, RGB of ARGB)
- controller meegeleverd, ja of nee
- interne USB nodig, ja of nee
- kleur

Die laatste twee hangen samen. Een set met eigen controller sluit niet op het
bord aan, dus dan doet het aantal aansluitingen op het bord er niet toe. Maar
zulke controllers vragen vaak wel een interne USB-aansluiting, en daar
concurreren ze om met de frontpoorten van de behuizing.

---

## Over de kleur

Elk onderdeel draagt een kleur, omdat we regelmatig systemen bouwen in één
kleurstelling. Komt er een afwijkende kleur in een order, dan wil ik daar een
opmerking over geven — geen blokkering.

Twee vragen daarbij:

**Welke onderdelen tellen mee?** Een processor, een M.2-SSD onder zijn
koelplaatje en een schijf in een kooi ziet niemand. Als die meetellen, krijgt
bijna elke order een opmerking. Ik ga er nu van uit dat alleen de behuizing, de
ventilatoren, de koeler, het moederbord, het geheugen, de videokaart en de
voeding meetellen. Klopt die keuze?

**Volstaan zwart en wit?** Er bestaat ook grijs, zilver en hout-look. Wat doen we
daarmee — meetellen, of erbuiten laten?

---

## Wat ik bewust heb weggelaten

Deze kwamen wel ter sprake, maar er hangt geen enkele controle van af. Zie ik dat
verkeerd, laat het weten.

- kloksnelheid van de processor
- aantal kernen
- capaciteit van SSD's en harde schijven
- lees- en schrijfsnelheden
- rendementscertificering van de voeding
- geluidsniveau van ventilatoren
- prijs

---

## Wat ik nog niet te pakken krijg

Dit zijn eigenschappen waar wél een controle van afhangt, maar die ik moeilijk
of niet automatisch kan ophalen. Weet iemand een betere bron, of houden we dit
ergens intern bij?

- hoogte van geheugenmodules
- vrije ruimte boven de geheugensloten bij een luchtkoeler
- maximale kaartlengte met een radiator vooraan
- lengte van een voeding
- koelvermogen van een koeler
- of een behuizing geschikt is voor borden met aansluitingen op de achterzijde
- welke processorgeneraties een bord ondersteunt
- of een ventilatorset een interne USB-aansluiting nodig heeft

---

## Wat ik graag terug hoor

1. Welke eigenschap mis je, en welke controle zou ze dienen?
2. Welke combinaties gaan er bij jullie in de praktijk mis die hier nog niet
   uit te halen zijn?
3. Klopt mijn aanname over welke onderdelen meetellen voor de kleur?
4. Zijn er onderdeeltypes die ik helemaal vergeten ben? Ik heb nu: behuizing,
   moederbord, processor, koeler, geheugen, videokaart, SSD, HDD, voeding en
   ventilatoren.

Aanvullen mag rechtstreeks in dit document.
