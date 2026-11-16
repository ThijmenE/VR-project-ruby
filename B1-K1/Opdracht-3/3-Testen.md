# Testen

Versienummer : 1.4

Auteur : Thijmen, Marijn

Studentnummer : 0266883, 0265825

Klas : 24SDG

Datum : 2026-11-16

<div style="page-break-after: always;"></div>

## Versiebeheer

| Datum      | Versie | Wie | Wijzigingen |
| ---------- | ------ | --- | ----------- |
| 2026-10-21 |  1.0   |  Marijn | Planning van testen ingevuld      |
| 2026-10-21 |  1.0   | Thijmen | Planning van testen ingevuld      |
| 2026-10-22 |  1.1   |  Marijn |  Alle data genoteerd + eindconclusie en verbetervoorstellen |
| 2026-10-22 |  1.1   |  Thijmen | eindconclusie en verbetervoorstellen|
| 2026-10-29 |  1.2   |  Marijn | Test cases beter gemaakt|
| 2026-11-16 |  1.3   |  Marijn | Hele document beter geformuleerd|
| 2026-11-16 |  1.3   |  Thijmen | meegeholpen met formuleren|
| 2026-11-16 |  1.4   |  Thijmen | Algemene informatie veranderd in gebruikers/usability test resultaten|


<div style="page-break-after: always;"></div>

## Inhoudsopgave

- [Testen](#testen)
  - [Versiebeheer](#versiebeheer)
  - [Inhoudsopgave](#inhoudsopgave)
  - [Inleiding](#inleiding)
  - [Overzicht van de testen functionaliteiten](#overzicht-van-de-testen-functionaliteiten)
  - [Test omgeving](#test-omgeving)
  - [Planning testactiviteiten](#planning-testactiviteiten)
    - [Testplan](#testplan)
    - [Testcases en resultaten](#testcases-en-resultaten)
  - [Eindconclusie](#eindconclusie)
  - [Verbetervoorstellen](#verbetervoorstellen)

<div style="page-break-after: always;"></div>

## Inleiding

In dit document worden de testactiviteiten van VR Project Ruby beschreven. Tijdens de playtests worden verschillende functionaliteiten van de game getest, waaronder de minigames darten, bowlen, basketbal en het bouwen met blokken. De tests worden uitgevoerd met gebruikers om te controleren of de game goed werkt en of de bediening duidelijk en gebruiksvriendelijk is. De testresultaten worden vastgelegd en gebruikt om verbeterpunten voor de game op te stellen.

## Overzicht van de testen functionaliteiten

Playtest 1 (Halverwege project)

Darten, Trigger, Grip, Rondkijken, Lopen, Springen, Menu UI, Bowling baan, Basketbal, bouw blokken, reset button, blokken spawner, menu muziek, muziek knop, knop manager, uileg/tutorial, prullenbak

|Categorie | Functionaliteiten |
|------------------|--------|
| Besturing |	Bewegen, springen, rondkijken, trigger en grip button |
| Minigames |	Darten, bowlen, basketbal en bouwblokken |
| Interface |	Menu UI, resetknop, knoppenmanager en blokken spawner |
| Overig |	Tutorial, muziek en prullenbak |

## Test omgeving

We testen vandaag: Playtesting, gebruikerstest, usability testing,

Voor test 1 zijn wij bij ruby met een vr bril (meta quest 3), omdat niet veel een eigen vr bril hebben. Wij zetten de build klaar en de testers kunnen gelijk bezig.

De tests zijn uitgevoerd bij Ruby met kinderen van de basisschool. Hiervoor is een VR-bril gebruikt waarop de versie van halverwege ons project werd uitgevoerd. De testers konden de game zelfstandig uitproberen, terwijl wij keken hoe zij de verschillende functionaliteiten gebruikten. Tijdens het testen hebben wij gelet op de werking van de minigames, de bediening en eventuele problemen die gebruikers tegenkwamen.

## Planning testactiviteiten

Playtest 1:

|Testcases volgnr. | Tester | Wanneer | Doorlooptijd test |
|------------------|--------|---------|-------------------|
| #1 |	Tester1 |	2026-10-21 |	 15 min |
| #2 |	Tester2 |	2026-10-21 |	 15 min |
| #3 |	Tester3 |	2026-10-21 |	 5 min  |
| #4 |	Tester4 |	2026-10-21 |	 10 min |
| #5 |	Tester5 |	2026-10-21 |	 10 min |
| #6 |	Tester6 |	2026-10-21 |	 5 min  |
| #7 |	Tester7 |	2026-10-21 |	 5 min  |
| #8 |	Tester8 |	2026-10-21 |	 5 min  |

<div style="page-break-after: always;"></div>

### Testplan

Er is een VR bril nodig om te kunnen testen. We zijn nog niet klaar want dit is een tussentijdse test, daarom hebben we nog geen build klaar. Wij hebben de game vanuit Unity opgestart.

Je hebt een app nodig van de VR bril om hem te gebruiken op je pc. Zodra de game klaar is moet de game gedownload worden uit de repository en kan daarna lokaal gelanceerd worden.

### Testcases en resultaten

| Volgnr | Functionaliteit | Scenario | Test input | Verwachte werking\output | Werkelijke werking\output | Conclusie test |
|--------|------------------|----------|------------|--------------------------|--------------------------|----------------|
| |Beschrijving van de functionaliteit (vaak genoemd in functioneel ontwerp) | Hoe gaat getest worden of de functie werkt? | Welke test-data gaan gebruikt worden? | Welk resultaat verwacht je van de functie? | Wat is het resultaat van de test? | Werkt de functie zoals verwacht? Indien van niet geef aan wat fout is. |
| #1 | Darten | De tester pakt de dartpijltjes en gooit ze in het dartbord | Dartpijltes, dartbord en VR-controllers| De speler kan de dartpijltjes in het dartbord gooien, alleen gaan de pijltjes verkeerd in het bord| pijltjes gingen niet door het dartbord, maar het gooien ging lastig door de rotatie van de pijltjes | Pijltjes gingen niet door het dartbord heen|
| #1 | Bowlen | De tester pakt de bowlingbal op en gooit deze richting de kegels| Bowlingbal en VR-controllers| De speler kan de bowlingbal oppakken en richting de kegels gooien. De bal blijft binnen de bowlingbaan.| Bal is te licht dus je gooit perongeluk over de pins. Je gooit een aantal keer in de grond vanwege de afstand tussen bal en speler| Werkt zoals we hadden verwacht|
| #1 | Bouwblokken | Speler opent bouwblokken menu, klikt op een blok en kan daarmee bouwen| Bouwblokken spawner, bouwblokken en VR-controllers| De speler kan blokken spawnen door middel van het menu en kan bouwen. bouwblokken glijden snel door elkaar heen en blijven vast zitten in de grond of andere objecten| Niet getest| Niet getest|
| #1 | Basketbal | De speler pakt een basketbal een gooit hem door de hoop voor score| Basketbal, baskethoop, scoreUI en VR-controllers| De speler kan de basketbal oppakken en gooien door de baskethoop| Je gooit perongeluk door de grond en muur, door de afstand tussen bal en speler| Makkelijk om te doen maar basketbal moet gelijk naar de speler zijn hand.|
| #1 | Knoppenmanager | De tester drukt op X/Y/Menu knop om een menu te openen| menu interface en VR-controllers| Speler kan drukken op de knoppen en het menu verschijnt| Niet getest| Niet getest|
| #1 | Blokken spawner| De speler drukt op Y om het blokken menu te openen om daar blokken te kunnen spawnen| Spawnknoppen, blokprefabs en VR-controller| De blokken verschijnen in de scene wanneer de speler op de UI knoppen drukt| Niet getest| Niet getest|
| #2 | Darten | De tester pakt de dartpijltjes en gooit ze in het dartbord | Dartpijltes, dartbord en VR-controllers| De speler kan de dartpijltjes in het dartbord gooien, alleen gaan de pijltjes verkeerd in het bord| pijltjes gingen niet door het dartbord, maar het gooien ging lastig door de rotatie van de pijltjes| Pijltjes gingen niet door de muur of grond dus dat is goed, alleen nog fixen dat de pijtles met de goede kant het bord in gaan.|
| #2 | Bowlen | De tester pakt de bowlingbal op en gooit deze richting de kegels| Bowlingbal en VR-controllers| De speler kan de bowlingbal oppakken en richting de kegels gooien. De bal blijft binnen de bowlingbaan.| Gooit vaak door de grond een muur, bal is te licht, waardoor het niet laag blijft| Werkt zoals verwacht. Wisten van de issues af.|
| #2 | Bouwblokken | Speler opent bouwblokken menu, klikt op een blok en kan daarmee bouwen| Bouwblokken spawner, bouwblokken en VR-controllers| De speler kan blokken spawnen door middel van het menu en kan bouwen. bouwblokken glijden snel door elkaar heen en blijven vast zitten in de grond of andere objecten| Gebruikt de blokken goed, en gooit ze weg via prullenbak. alleen gaan de blokken nog door de grond, muur en andere blokken| Werkt zoals verwacht, alleen gaan de blokken nog regelmatig door elkaar of door de grond en muur|
| #2 | Basketbal | De speler pakt een basketbal een gooit hem door de hoop voor score| Basketbal, baskethoop, scoreUI en VR-controllers| De speler kan de basketbal oppakken en gooien door de baskethoop| Niet getest| Niet getest|
| #2 | Knoppenmanager | De tester drukt op X/Y/Menu knop om een menu te openen| menu interface en VR-controllers| Speler kan drukken op de knoppen en het menu verschijnt|Werkt goed, geen problemen|Geen issues|
| #2 | Blokken spawner| De speler drukt op Y om het blokken menu te openen om daar blokken te kunnen spawnen| Spawnknoppen, blokprefabs en VR-controller| De blokken verschijnen in de scene wanneer de speler op de UI knoppen drukt| Werkt goed, alleen kan je nog te veel spammen met blokken spawnen| Werkt goed, iets langere cooldown op de spawn|
| #3 | Darten | De tester pakt de dartpijltjes en gooit ze in het dartbord | Dartpijltes, dartbord en VR-controllers| De speler kan de dartpijltjes in het dartbord gooien, alleen gaan de pijltjes verkeerd in het bord| Niet getest| Niet getest|
| #3 | Bowlen | De tester pakt de bowlingbal op en gooit deze richting de kegels| Bowlingbal en VR-controllers| De speler kan de bowlingbal oppakken en richting de kegels gooien. De bal blijft binnen de bowlingbaan.| Niet getest| Niet getest|
| #3 | Bouwblokken | Speler opent bouwblokken menu, klikt op een blok en kan daarmee bouwen| Bouwblokken spawner, bouwblokken en VR-controllers| De speler kan blokken spawnen door middel van het menu en kan bouwen. bouwblokken glijden snel door elkaar heen en blijven vast zitten in de grond of andere objecten| Bouwen werkt goed, alleen gaat het nog door elkaar heen| Werkt zoals verwacht, alleen gaan de blokken nog regelmatig door elkaar of door de grond en muur|
| #3 | Basketbal | De speler pakt een basketbal een gooit hem door de hoop voor score| Basketbal, baskethoop, scoreUI en VR-controllers| De speler kan de basketbal oppakken en gooien door de baskethoop| Werkt goed met de ballen, maar je kan valsspelen door de bal vast te pakken en omhoog en naar beneden te gaan| Werkt goed, alleen kan je valsspelen|
| #3 | Knoppenmanager | De tester drukt op X/Y/Menu knop om een menu te openen| menu interface en VR-controllers| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed, alles getest| Werkt zoals verwacht|
| #3 | Blokken spawner| De speler drukt op Y om het blokken menu te openen om daar blokken te kunnen spawnen| Spawnknoppen, blokprefabs en VR-controller| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Werkt goed|
| #4 | Darten | De tester pakt de dartpijltjes en gooit ze in het dartbord | Dartpijltes, dartbord en VR-controllers| De speler kan de dartpijltjes in het dartbord gooien, alleen gaan de pijltjes verkeerd in het bord| Geen problemen met dat de pijltjes door de muur of grond heen gaan, maar wel met het gooien omdat de pijltes niet dichtbij de controller zit | Pijltjes gingen niet door de muur of grond dus dat is goed, alleen nog fixen dat de pijtles met de goede kant het bord in gaan|
| #4 | Bowlen | De tester pakt de bowlingbal op en gooit deze richting de kegels| Bowlingbal en VR-controllers| De speler kan de bowlingbal oppakken en richting de kegels gooien. De bal blijft binnen de bowlingbaan. maar de bal kan nog door de muren en grond| Bal is te licht dus je gooit te makkelijk over de pins. gooit aantal keer in de grond| Werkt zoals we hadden verwacht|
| #4 | Bouwblokken | Speler opent bouwblokken menu, klikt op een blok en kan daarmee bouwen| Bouwblokken spawner, bouwblokken en VR-controllers| De speler kan blokken spawnen door middel van het menu en kan bouwen. bouwblokken glijden snel door elkaar heen en blijven vast zitten in de grond of andere objecten| Werkt goed| Kan iets te snel blokken spawnen, kleine cooldown|
| #4 | Basketbal | De speler pakt een basketbal een gooit hem door de hoop voor score| Basketbal, baskethoop, scoreUI en VR-controllers| De speler kan de basketbal oppakken en gooien door de baskethoop| Gooit door het plafond of door de muur| Makkelijk om te doen maar basketbal moet gelijk naar de speler zijn hand.|
| #4 | Knoppenmanager | De tester drukt op X/Y/Menu knop om een menu te openen| menu interface en VR-controllers| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Geen issues|
| #4 | Blokken spawner| De speler drukt op Y om het blokken menu te openen om daar blokken te kunnen spawnen| Spawnknoppen, blokprefabs en VR-controller| De blokken verschijnen in de scene wanneer de speler op de UI knoppen drukt| Werkt goed| Geen issues naast spam|
| #5 | Darten | De tester pakt de dartpijltjes en gooit ze in het dartbord | Dartpijltes, dartbord en VR-controllers| De speler kan de dartpijltjes in het dartbord gooien, alleen gaan de pijltjes verkeerd in het bord| pijltjes gingen niet door het dartbord, maar het gooien ging lastig door de rotatie van de pijltjes| Pijltjes gingen niet door de muur of grond dus dat is goed, alleen nog fixen dat de pijtles met de goede kant het bord in gaan|
| #5 | Bowlen | De tester pakt de bowlingbal op en gooit deze richting de kegels| Bowlingbal en VR-controllers| De speler kan de bowlingbal oppakken en richting de kegels gooien. De bal blijft binnen de bowlingbaan. maar de bal kan nog door de muren en grond| Bal is te licht dus je gooit te makkelijk over de pins.| Werkt zoals we hadden verwacht|
| #5 | Bouwblokken | Speler opent bouwblokken menu, klikt op een blok en kan daarmee bouwen| Bouwblokken spawner, bouwblokken en VR-controllers| De speler kan blokken spawnen door middel van het menu en kan bouwen. bouwblokken glijden snel door elkaar heen en blijven vast zitten in de grond of andere objecten| Niet getest| Niet getest|
| #5 | Basketbal | De speler pakt een basketbal een gooit hem door de hoop voor score| Basketbal, baskethoop, scoreUI en VR-controllers| De speler kan de basketbal oppakken en gooien door de baskethoop| Gooit door het plafond of door de muur, werkt wel goed met de ballen| Makkelijk om te doen, maar basketbal moet gelijk naar de speler zijn hand.|
| #5 | Knoppenmanager | De tester drukt op X/Y/Menu knop om een menu te openen| menu interface en VR-controllers| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Geen issues|
| #5 | Blokken spawner| De speler drukt op Y om het blokken menu te openen om daar blokken te kunnen spawnen| Spawnknoppen, blokprefabs en VR-controller| De blokken verschijnen in de scene wanneer de speler op de UI knoppen drukt| Werkt goed| Geen issues naast spam|
| #6 | Darten | De tester pakt de dartpijltjes en gooit ze in het dartbord | Dartpijltes, dartbord en VR-controllers| De speler kan de dartpijltjes in het dartbord gooien, alleen gaan de pijltjes verkeerd in het bord| pijltjes gingen niet door het dartbord, maar het gooien ging lastig door de rotatie van de pijltjes Kon niet vaak in het bord gooien, lastig.| Pijltjes gingen niet door de muur of grond dus dat is goed, alleen nog fixen dat de pijtles met de goede kant het bord in gaan om op het bord te gooien|
| #6 | Bowlen | De tester pakt de bowlingbal op en gooit deze richting de kegels| Bowlingbal en VR-controllers| De speler kan de bowlingbal oppakken en richting de kegels gooien. De bal blijft binnen de bowlingbaan. maar de bal kan nog door de muren en grond| Bal is te licht dus je gooit te makkelijk over de pins.| Werkt zoals we hadden verwacht|
| #6 | Bouwblokken | Speler opent bouwblokken menu, klikt op een blok en kan daarmee bouwen| Bouwblokken spawner, bouwblokken en VR-controllers| De speler kan blokken spawnen door middel van het menu en kan bouwen. bouwblokken glijden snel door elkaar heen en blijven vast zitten in de grond of andere objecten| Niet getest| Niet getest|
| #6 | Basketbal | De speler pakt een basketbal een gooit hem door de hoop voor score| Basketbal, baskethoop, scoreUI en VR-controllers| De speler kan de basketbal oppakken en gooien door de baskethoop| Gooit door het plafond of door de muur werkt wel goed met de ballen| Makkelijk om te doen maar basketbal moet gelijk naar de speler zijn hand.|
| #6 | Knoppenmanager | De tester drukt op X/Y/Menu knop om een menu te openen| menu interface en VR-controllers| Speler kan drukken op de knoppen en het menu verschijnt| Niet getest| Niet getest|
| #6 | Blokken spawner| De speler drukt op Y om het blokken menu te openen om daar blokken te kunnen spawnen| Spawnknoppen, blokprefabs en VR-controller| De blokken verschijnen in de scene wanneer de speler op de UI knoppen drukt| Niet getest| Niet getest|
| #7 | Darten | De tester pakt de dartpijltjes en gooit ze in het dartbord | Dartpijltes, dartbord en VR-controllers| De speler kan de dartpijltjes in het dartbord gooien, alleen gaan de pijltjes verkeerd in het bord| pijltjes gingen niet door de grond of muur, wel lastig.| Gaat niet door de muur/dartbord. Pijltjes moeten gelijk naar je hand als je ze oppakt|
| #7 | Bowlen | De tester pakt de bowlingbal op en gooit deze richting de kegels| Bowlingbal en VR-controllers| De speler kan de bowlingbal oppakken en richting de kegels gooien. De bal blijft binnen de bowlingbaan. maar de bal kan nog door de muren en grond| Bal is te licht dus je gooit te makkelijk over de pins.| Werkt zoals we hadden verwacht. gelijk naar hand als je de bal oppakt, dan word het makkelijker.|
| #7 | Bouwblokken | Speler opent bouwblokken menu, klikt op een blok en kan daarmee bouwen| Bouwblokken spawner, bouwblokken en VR-controllers| De speler kan blokken spawnen door middel van het menu en kan bouwen. bouwblokken glijden snel door elkaar heen en blijven vast zitten in de grond of andere objecten| Bouwt met blokken, blokken gaan door de muur en grond| Naast dat de blokken door elkaar heen gaan geen problemen met het bouwen zelf|
| #7 | Basketbal | De speler pakt een basketbal een gooit hem door de hoop voor score| Basketbal, baskethoop, scoreUI en VR-controllers| De speler kan de basketbal oppakken en gooien door de baskethoop| Niet door plafond of muur gegaan, gooien ging goed| Makkelijk om te doen maar basketbal moet gelijk naar de speler zijn hand.|
| #7 | Knoppenmanager | De tester drukt op X/Y/Menu knop om een menu te openen| menu interface en VR-controllers| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Geen issues|
| #7 | Blokken spawner| De speler drukt op Y om het blokken menu te openen om daar blokken te kunnen spawnen| Spawnknoppen, blokprefabs en VR-controller| De blokken verschijnen in de scene wanneer de speler op de UI knoppen drukt| Werkt goed| Geen issues|
| #8 | Darten | De tester pakt de dartpijltjes en gooit ze in het dartbord | Dartpijltes, dartbord en VR-controllers| De speler kan de dartpijltjes in het dartbord gooien, alleen gaan de pijltjes verkeerd in het bord| Geen problemen met dat de pijltjes door de grond of muur gaan, wel lastig om goed te gooien.| Werkt beter als verwacht. Pijltjes moeten gelijk naar je hand als je ze oppakt.|
| #8 | Bowlen | De tester pakt de bowlingbal op en gooit deze richting de kegels| Bowlingbal en VR-controllers| De speler kan de bowlingbal oppakken en richting de kegels gooien. De bal blijft binnen de bowlingbaan. maar de bal kan nog door de muren en grond| Bal is te licht dus je gooit te makkelijk over de pins. De pins omgooien werkt goed| Werkt zoals we hadden verwacht. gelijk naar hand als je de bal oppakt, dan wordt het makkelijker.|
| #8 | Bouwblokken | Speler opent bouwblokken menu, klikt op een blok en kan daarmee bouwen| Bouwblokken spawner, bouwblokken en VR-controllers| De speler kan blokken spawnen door middel van het menu en kan bouwen. bouwblokken glijden snel door elkaar heen en blijven vast zitten in de grond of andere objecten| Bouwt veel met blokken, wel gaan de blokken weer door elkaar heen| Naast dat de blokken door elkaar of grond/muur heen gaan geen problemen met het bouwen zelf|
| #8 | Basketbal | De speler pakt een basketbal een gooit hem door de hoop voor score| Basketbal, baskethoop, scoreUI en VR-controllers| De speler kan de basketbal oppakken en gooien door de baskethoop| Niet door plafond of muur gegaan, gooien ging goed| Makkelijk om te doen maar basketbal moet gelijk naar de speler zijn hand.|
| #8| Knoppenmanager | De tester drukt op X/Y/Menu knop om een menu te openen| menu interface en VR-controllers| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Geen issues|
| #8 | Blokken spawner| De speler drukt op Y om het blokken menu te openen en kan dan blokken spawnen| Spawnknoppen, blokprefabs en VR-controller| De blokken verschijnen in de scene wanneer de speler op de UI knoppen drukt| Werkt goed| Geen issues|

## gebruikerstest/usability test resultaten:

### Tester 1:

Tester 1 heeft moeite om VR te begrijpen. Het lukte haar wel gelijk om de pijltjes en ballen naar zichzelf toe te halen met joysticks. de dart pijltjes waren iets te ver weg voor de tester dus gaan wij de pijltjes naast de reset knop neer zetten. We zagen ook dat de basketbal een punt kon geven als je de buitenkant van de ring raakt.

### Tester 2:

Tester 2 begreep VR en de minigames snel. Het oppakken van voorwerpen gaf hetzelfde probleem als bij tester 1. Ook liep tester 2 tegen het probleem met de tutorial aan. Het bowlen werkte niet goed met de bal. Tester 2 kon goed met de bouwblokken werken en had snel door hoe deze werkten. De prullenbak werkte goed om blokken weg te gooien, maar blokken bleven soms in de muur steken. Tester 2 bleef lang spelen en vond de game erg leuk.

### Tester 3:

Tester 3 vond VR lastig, maar kon goed met basketbal spelen. Het oppakken van voorwerpen gaf hetzelfde probleem als bij de andere testers. De bouwblokken vielen direct door de grond, maar tester 3 vond het leuk om ermee te spelen. De menuknop en slider werkten goed. Bij basketbal kon tester 3 valsspelen door de bal vast te houden en ermee omhoog en omlaag te bewegen. Tester 3 vond de game erg leuk en bleef lang spelen.

### Tester 4:

Tester 4 begreep VR snel en kon goed met bowlen spelen. Bij basketbal kon tester 4 valsspelen. Ook merkte tester 4 dezelfde problemen met voorwerpen op als de andere testers. Tester 4 wist niet dat er knoppen op de controller zitten en creeërde vaak bouwblokken. Een langere cooldown kan helpen om het vaak spawnen te beperken.

### Tester 5:

Tester 5 begreep VR goed en keek op de controller om te zien wat de knoppen doen. Tester 5 wist niet dat er knoppen op de controller zitten. Tijdens het spelen ging de basketbal door de muur. Tester 5 vond de game erg leuk.

### Tester 6:

Tester 6 vond VR lastig. Tester 6 vond darten leuk, maar had moeite met het spel. De bowlingbal ging door de grond; dit probleem kwam vaker voor.

### Tester 7:

Tester 7 vond het lastig om de bediening te begrijpen en gebruikte een knop op de controller. Ook had tester 7 moeite met het oppakken van voorwerpen.

### Tester 8:

Tester 8 las de knoppen op de controller en begreep wat deze doen. De bediening van de game was nog niet helemaal duidelijk. Bowlen ging goed en tester 8 had darten snel door.

<div style="page-break-after: always;"></div>

## Eindconclusie

Playtest 1 (Halverwege project):

Tijdens de playtests van VR Project Ruby hebben wij de game door meerdere testers laten uitproberen. Hierbij hebben wij gekeken naar de werking van de verschillende minigames, de bediening en de gebruiksvriendelijkheid van de game.

Uit de testresultaten blijkt dat de meeste functionaliteiten in de basis goed werken. De testers konden de verschillende minigames uitproberen en vonden het bouwen met blokken en het spelen van de minigames over het algemeen leuk.

Tijdens het testen kwamen er wel verschillende problemen naar voren. Zo hadden meerdere testers moeite met het oppakken van voorwerpen, omdat deze niet direct goed op de positie van hun hand terechtkwamen. Ook waren er problemen met de physics van de bowlingbal en de bouwblokken, waardoor objecten soms door de grond of muren heen gingen.

Bij basketbal ontdekten testers dat ze op een oneerlijke manier punten konden scoren door de bal vast te houden en deze door de basket te bewegen. Daarnaast bleek dat de bediening en de uitleg van de controller niet voor iedere tester duidelijk waren.

Op basis van deze resultaten hebben wij verschillende verbeterpunten opgesteld. Deze richten zich vooral op de physics van objecten, het oppakken van voorwerpen, het scoresysteem van basketbal en de uitleg van de bediening.

De eisen en wensen van de opdrachtgever zijn verwerkt in de game. Er zijn nog fouten in de minigames die wij er nog uit gaan halen.

## Verbetervoorstellen
Alle verbeter voorstellen staan genoteerd in 4-Verbetervoorstellen.md