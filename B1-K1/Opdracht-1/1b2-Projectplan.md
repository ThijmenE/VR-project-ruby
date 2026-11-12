# Projectplan

Versienummer : 1.5

Auteur : Thijmen, Marijn

Studentnummer : 0266883, 0265825

Klas : 24SDG

Datum : 2026-11-12

<div style="page-break-after: always;"></div>

## Versiebeheer

| Datum      | Versie | Wie | Wijzigingen |
| ---------- | ------ | --- | ----------- |
| 2026-10-02 | 1.0    | Thijmen | Projectplan ingevuld |
| 2026-10-02 | 1.0    | Marijn  | Projectplan ingevuld |
| 2026-10-27 | 1.1    | Marijn  | Afwijkingen ingevuld |
| 2026-10-29 | 1.2    | Thijmen | Uitleg opdrachtgever verbeterd|
| 2026-10-27 | 1.3    | Marijn  | Datums toegevoegd aan afwijkingen|
| 2026-11-10 | 1.4    | Thijmen | meer afwijkingen ingevuld|
| 2026-11-12 | 1.5    | Marijn  | Spelfouten en interpunctie verbeterd|

<div style="page-break-after: always;"></div>

## Inhoudsopgave

- [Projectplan](#projectplan)
  - [Versiebeheer](#versiebeheer)
  - [Inhoudsopgave](#inhoudsopgave)
  - [Inleiding](#inleiding)
    - [Over dit document](#over-dit-document)
    - [Over het project en de opdrachtgever](#over-het-project-en-de-opdrachtgever)
  - [Betrokkenen](#betrokkenen)
  - [Projectgrenzen](#projectgrenzen)
  - [Prioriteiten](#prioriteiten)
  - [Planning](#planning)
  - [Afwijkingen](#afwijkingen)

<div style="page-break-after: always;"></div>

## Inleiding

### Over dit document

In dit document wordt inzicht gegeven over de verschillende technieken die gebruikt gaan worden tijdens het ontwikkelen van de applicatie.

### Over het project en de opdrachtgever

De opdrachtgever van ons project heet Marjan de Jonge en ze is van van Ruby Campus. Je kan bij Ruby langskomen als je vragen hebt over wat digitale ontwikkeling in jouw leven kan betekenen. Bij Ruby ondersteunen ze ondernemers met slimme adviezen om processen te verbeteren, bereik te vergroten en kansen te grijpen. En ze helpen studenten door hen opdrachten te geven om hun digitale skills sterker te maken. Ze hebben bijvoorbeeld een workshop gehad over hoe je met AI kan werken en ze hebben een toeristische databank genaamd Touripedia officieel gelanceerd bij Ruby zelf.

## Betrokkenen

Thijmen: Projectleider, programmeur, modelleur, +31682009171, taeggens@st.noorderpoort.nl

Marijn: Notulist, programmeur, modelleur, aanspreekpunt, +31633677013, mlubbers5@st.noorderpoort.nl

## Projectgrenzen

Zodra het project is afgerond krijgt ruby het project en komen er geen updates meer (tenzij er een gamebreaking bug in de game zit). Er komen geen transacties in de game voor voor echt geld. De game is bedoeld om kort gespeeld te worden dus er komen geen uitbreidingen. Omdat de game bedoeld is voor jonge kinderen komt er geen realistisch geweld of seksuele onderwerpen in de game voor.

## Prioriteiten

Must have
- : Basic movement
- : Robot maker machine
- : Robot personalities/talking
- : UI

Should have
- : Inrichting kinderkamer
- : Minigames
- : Robot animaties

Could have
- : Score tracking in minigames
- : Meer expressieve robot

Won't have (now)
- : Grotere map/meerdere kamers
- : Meer robot onderdelen en accessoires

## Planning

https://github.com/users/ThijmenE/projects/6/views/3

## Afwijkingen

Wij hebben het project staan voor 4 weken maar we hebben de planning gebaseerd op 3 weken. Als we dan nog uitlopen, is er alsnog niks aan de hand.

2026-10-21 - Bij het dartbord zijn we langer bezig geweest dan we hadden verwacht. Het gooien van de pijltjes op het bord waren we al een tijdje mee bezig. De dartpijlen hadden we laten plakken aan het bord met behulp van kinematic, maar de pijltjes gooide je niet met de punt naar voren. Daar hebben we een script voor gemaakt dat de dartpijl draait en met de punt naar voren in het dartbord laat komen. Twee uur langer aan besteed dan we hadden verwacht. Geen problemen met tijdstekort.

2026-10-21 - Menu UI was eerder af dan we hadden verwacht. We verwachtten er twee tot vier uur mee bezig te zijn, maar het werd uiteindelijk maar één tot twee uur. Geen issues gehad tijdens het maken van de UI.

2026-10-21 - Bowling Minigame hadden we verwacht één tot twee uur ermee bezig te zijn. We hadden één groot issue en dat was de bowlingbal die zich niet gedroeg als een bowlingbal. We hebben daarvoor een script gemaakt dat de bal met een goede snelheid laat gaan, maar de bal laag houdt. Eerder kon je de bal veel te makkelijk omhoog gooien, maar hij wordt nu naar beneden gehaald. We hebben geen tijd verloren aan de bowlingminigame.

2026-10-21 - Bij de basketbalminigame hadden we 30 tot 60 minuten voor ingepland, maar dat is iets meer geworden. Wij hebben de minigame wel snel klaargekregen, maar we hebben het later nog weer geüpdatet. We hebben later nog een cooldown op de score gezet, zodat je niet meer kunt valsspelen, en we hebben nog textures toegevoegd aan de ballen.

2026-10-21 - De reset button werkte gelijk goed. Alleen wilden we nog dat je in-game met je hand de button in kon drukken en dat duurde iets langer dan verwacht.

2026-10-21 - De blokken spawner heeft langer geduurd dan verwacht. Wij hadden UI gemaakt voor het spawnen van de blokken en die op de hand van de speler gezet. We hadden ook nog een andere UI op de hand van de speler staan en dat zorgde ervoor dat ze door elkaar heen gingen. We hadden een cooldown op de spawner gezet, zodat je de blokken niet kon spammen. Maar als je het menu opende, een blok spawnde en gelijk uit het menu ging, bleef het script vastzitten waardoor alles niet meer werkte. Dat zorgde ervoor dat we veel tijd zijn verloren.

2026-10-21 - De tutorial hadden we ook op de hand van de speler gezet en dat zorgde voor problemen met de blokken spawner. Als je ze beide aanzette, gingen ze door elkaar heen. Ook hadden we een probleem met de cards van de UI, omdat hij daar doorheen moest lopen in de scene. Het heeft ons uiteindelijk geen tijd gekost.

2026-10-21 - Bij de prullenbak konden we eerst de bouwblokken niet verwijderen, omdat de instellingen in de blokken niet goed waren. Dus dat heeft ons iets meer tijd gekost dan normaal.

2026-10-25 - De robotmachine kwam iets later af dan op de planning en heeft op 2026-11-04 nog toevoegingen gekregen, zodat het beter werkt met het robotpraten en modellen met meerdere meshfilters of kleuren.

2026-11-06 - Bouwblokken hadden de hele tijd collisionproblemen, waardoor ze makkelijk in elkaar vast konden komen te zitten of heel snel over andere objecten heen gleden. De bouwblokken zijn nu automatisch aan je hand vast en gaan door objecten in de buurt heen, waardoor je de blokken weer los krijgt als ze ergens vast komen te zitten. Ook bevriezen de blokken na een seconde zodra de rotatie en de positie van de blokken heel weinig veranderen.

2026-10-28 | 2026-11-10 - Begonnen met het maken van een testmodel voor de robotmachine om te zien of alles goed werkte. Later zijn we met het echte model gaan werken, wat veel tijd kostte om de grootte en rotatie goed te krijgen. Daarna zijn we bezig geweest met hoeden en brillen om hier de rotatie en grootte goed op te krijgen.

2026-10-28 | 2026-11-10 - Robotanimaties zijn weggehaald, omdat het niet goed kan werken met de manier waarop de robot machine is gemaakt.

2026-11-2 - Het praten van de robot is afgekomen voor alle minigames, maar de zinnen voor het gooien, schudden en vallen was eerst stilgezet, omdat we eerst belangrijkere dingen af wilden, krijgen zoals de robot machine zelf helemaal klaar en de bouwblokken.