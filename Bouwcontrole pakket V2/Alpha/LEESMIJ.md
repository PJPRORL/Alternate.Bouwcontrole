# Alpha

Het scanscherm van Bouwcontrole, als los project. Je gebruikt het in fase 8 voor je demo.

> Dit valt onder de uitzondering voor de alpha: een los project, waarin ik de code mag geven. Je cursusproject, je API en je controle blijven volledig jouw werk.

## Openen

1. Dubbelklik op `Alternate.Bouwcontrole.Alpha.sln`.
2. Druk op F5. De browser opent meteen het scanscherm.

Kies je het profiel `https`, dan vraagt Visual Studio de eerste keer om een ontwikkelcertificaat te vertrouwen. Zeg ja, of kies het profiel `http`.

## Wat er nu in zit

Een scanscherm met verzonnen artikels. Typ een code en druk op Enter, zoals de scanner doet.

| Kraken-Id | Artikel |
| --- | --- |
| `K-1001` | NZXT casefan, los |
| `K-1002` | NZXT casefan, triple pack (reeks A, met controller) |
| `K-1003` | NZXT controller |
| `K-1004` | NZXT casefan, triple pack B (reeks B, met controller) |
| `K-2001` | Behuizing |

Een code die niet in de lijst staat, bijvoorbeeld `K-9999`, geeft de melding *Onbekende code*. De controle is nog niet ingevuld: alle regels blijven groen. Dat is zo bedoeld.

## Wat er in fase 8 verandert

De alpha wordt een venster op je API:

- een gescande code zoekt ze op via je endpoint op Kraken-Id;
- de controle vraagt ze aan je controle-endpoint;
- ze toont per onderdeel groen, oranje of rood, en per conflict de onderdelen, de uitleg en de oplossing.

De verzonnen artikels en de nagebootste controle verdwijnen dan. Ik schrijf die koppeling, zodra je me het antwoord van je endpoints uit Scalar stuurt. Zie het stappenplan, fase 8.

## Goed om te weten

- Bootstrap komt via internet. Zonder internet werkt het scherm, maar met de standaardletters van de browser.
- Bij de demo draaien je API en de alpha tegelijk. Kies in Visual Studio meerdere startprojecten, of start ze in twee vensters.
- In fase 14 bouw je het scherm zelf, in je eigen project. Dan gaat de alpha weg.
