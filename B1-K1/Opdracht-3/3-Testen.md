# Testen

Versienummer : 1.2

Auteur : Thijmen, Marijn

Studentnummer : 0266883, 0265825

Klas : 24SDG

Datum : 2026-10-29

<div style="page-break-after: always;"></div>

## Versiebeheer

| Datum      | Versie | Wie | Wijzigingen |
| ---------- | ------ | --- | ----------- |
| 2026-10-21 |  1.0   |  Marijn | Planning van testen ingevuld      |
| 2026-10-21 |  1.0   | Thijmen | Planning van testen ingevuld      |
| 2026-10-22 |  1.1   |  Marijn |  Alle data genoteerd + eindconclusie en verbetervoorstellen |
| 2026-10-22 |  1.1   |  Thijmen | eindconclusie en verbetervoorstellen|
| 2026-10-29 |  1.2   |  Marijn | Test cases beter gemaakt|


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

In dit document wordt het testplan met testcases omschreven van een (deel van een) applicatie. De resultaten van de uitgevoerde test worden vastgelegd en er wordt een conclusie getrokken van de uitgevoerde test.

## Overzicht van de testen functionaliteiten

Playtest 1 (Halverwege project)

Darten, Trigger, Grip, Rondkijken, Lopen, Springen, Menu UI, Bowling baan, Basketbal, bouw blokken, reset button, blokken spawner, menu muziek, muziek knop, knop manager, uileg/tutorial, prullenbak

Playtest 2 (Einde project)

## Test omgeving

Wij zijn bij ruby om onze game te laten testen door kinderen van de basischool. We testen vandaag: Playtesting, gebruikerstest, usability testing,

Voor test 1 zijn wij bij ruby met een vr bril , omdat niet veel een eigen vr bril hebben. Wij zetten de build klaar en de testers kunnen gelijk bezig.

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

Er is een VR bril nodig om te kunnen testen, we zijn nog niet klaar want dit is een tussentijdse test. Daarom hebben we nog geen build klaar.

Je hebt een app nodig van de VR bril om hem te gebruiken op je pc. Zodra de game klaar is moet de game gedownload worden uit de repository en kan daarna lokaal gelanceerd worden.

### Testcases en resultaten

| Volgnr | Functionaliteit | Scenario | Test input | Verwachte werking\output | Werkelijke werking\output | Conclusie test |
|--------|------------------|----------|------------|--------------------------|--------------------------|----------------|
| |Beschrijving van de functionaliteit (vaak genoemd in functioneel ontwerp) | Hoe gaat getest worden of de functie werkt? | Welke test-data gaan gebruikt worden? | Welk resultaat verwacht je van de functie? | Wat is het resultaat van de test? | Werkt de functie zoals verwacht? Indien van niet geef aan wat fout is. |
| #1 | Darten | De minigame spelen | Performance testers en code| Lastig om te spelen maar dat is de bedoeling. Dartpijl gaat nog wel vaak door het dartbord heen| pijltjes gingen niet door het dartbord, maar het gooien ging lastig door de rotatie van de pijltjes | Pijltjes gingen niet door het dartbord heen|
| #1 | Bowlen | De minigame spelen| Performance testers en code| Makkelijk te spelen maar de bal kan nog door de muren en grond door de afstand tussen de bal en de speler maar de bal kan nog door de muren en grond door de afstand tussen de bal en de speler| Bal is te licht dus je gooit perongeluk over de pins. Je gooit een aantal keer in de grond vanwege de afstand tussen bal en speler| Werkt zoals we hadden verwacht|
| #1 | Bouwblokken | De minigame spelen| Performance testers en code| Makkelijk te gebruiken maar de blokken komen regelmatig in elkaar vast te zitten| Niet getest| Niet getest|
| #1 | Basketbal | De minigame spelen| Performance testers en code| Moeilijk te spelen door de afstand tussen bal en speler. Je kan nog valsspelen door de afstand te gebruiken| Je gooit perongeluk door de grond en muur, door de afstand tussen bal en speler| Makkelijk om te doen maar basketbal moet gelijk naar de speler zijn hand.|
| #1 | Knoppenmanager | De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Niet getest| Niet getest|
| #1 | Blokken spawner| De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Niet getest| Niet getest|
| #2 | Darten | De minigame spelen | Performance testers en code| Lastig om te spelen maar dat is de bedoeling. Dartpijl gaat nog wel vaak door het dartbord heen| pijltjes gingen niet door het dartbord, maar het gooien ging lastig door de rotatie van de pijltjes| Pijltjes gingen niet door de muur of grond dus dat is goed, alleen nog fixen dat de pijtles met de goede kant het bord in gaan.|
| #2 | Bowlen | De minigame spelen| Performance testers en code| Makkelijk te spelen maar de bal kan nog door de muren en grond door de afstand tussen de bal en de speler| Gooit vaak door de grond een muur, bal gooit niet als een bowlingbal| Werkt zoals verwacht. Wisten van de issues af.|
| #2 | Bouwblokken | De minigame spelen| Performance testers en code| Makkelijk te gebruiken maar de blokken komen regelmatig in elkaar vast te zitten| Gebruikt de blokken goed, en gooit ze weg via prullenbak. alleen clippen de blokken door de muur en grond.| Werkt zoals verwacht, alleen gaan de blokken nog regelmatig door elkaar of door de grond en muur|
| #2 | Basketbal | De minigame spelen| Performance testers en code| Moeilijk te spelen door de afstand tussen bal en speler. Je kan nog valsspelen door de afstand te gebruiken| Niet getest| Niet getest|
| #2 | Knoppenmanager | De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt|Werkt goed, geen problemen|Geen issues|
| #2 | Blokken spawner| De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed, alleen kan je nog te veel spammen met blokken spawnen| Werkt goed, iets langere cooldown op de spawn|
| #3 | Darten | De minigame spelen | Performance testers en code| Lastig om te spelen maar dat is de bedoeling. Dartpijl gaat nog wel vaak door het dartbord heen| Niet getest| Niet getest|
| #3 | Bowlen | De minigame spelen| Performance testers en code| Makkelijk te spelen maar de bal kan nog door de muren en grond door de afstand tussen de bal en de speler| Niet getest| Niet getest|
| #3 | Bouwblokken | De minigame spelen| Performance testers en code| Makkelijk te gebruiken maar de blokken komen regelmatig in elkaar vast te zitten| Bouwen werkt goed, alleen gaat het nog door elkaar heen| Werkt zoals verwacht, alleen gaan de blokken nog regelmatig door elkaar of door de grond en muur|
| #3 | Basketbal | De minigame spelen| Performance testers en code| Moeilijk te spelen door de afstand tussen bal en speler. Je kan nog valsspelen door de afstand te gebruiken| Werkt goed met de ballen, maar je kan valsspelen door de bal vast te pakken en omhoog en naar beneden te gaan| Werkt goed, alleen kan je valsspelen|
| #3 | Knoppenmanager | De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed, alles getest| Werkt zoals verwacht|
| #3 | Blokken spawner| De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Geen issues naast spam spawn|
| #4 | Darten | De minigame spelen | Performance testers en code| Lastig om te spelen maar dat is de bedoeling. Dartpijl gaat nog wel vaak door het dartbord heen| Geen problemen met dat de pijltjes door de muur of grond heen gaan, maar wel met het gooien omdat de pijltes niet dichtbij de controller zit | Pijltjes gingen niet door de muur of grond dus dat is goed, alleen nog fixen dat de pijtles met de goede kant het bord in gaan|
| #4 | Bowlen | De minigame spelen| Performance testers en code| Makkelijk te spelen maar de bal kan nog door de muren en grond door de afstand tussen de bal en de speler maar de bal kan nog door de muren en grond| Bal is te licht dus je gooit te makkelijk over de pins. gooit aantal keer in de grond| Werkt zoals we hadden verwacht|
| #4 | Bouwblokken | De minigame spelen| Performance testers en code| Makkelijk te gebruiken maar de blokken komen regelmatig in elkaar vast te zitten| Werkt goed, spammed blokken| Kan iets te snel blokken spawnen, kleine cooldown|
| #4 | Basketbal | De minigame spelen| Performance testers en code| Moeilijk te spelen door de afstand tussen bal en speler. Je kan nog valsspelen door de afstand te gebruiken| Gooit door het plafond of door de muur| Makkelijk om te doen maar basketbal moet gelijk naar de speler zijn hand.|
| #4 | Knoppenmanager | De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Geen issues|
| #4 | Blokken spawner| De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Geen issues naast spam|
| #5 | Darten | De minigame spelen | Performance testers en code| Lastig om te spelen maar dat is de bedoeling. Dartpijl gaat nog wel vaak door het dartbord heen| pijltjes gingen niet door het dartbord, maar het gooien ging lastig door de rotatie van de pijltjes| Pijltjes gingen niet door de muur of grond dus dat is goed, alleen nog fixen dat de pijtles met de goede kant het bord in gaan|
| #5 | Bowlen | De minigame spelen| Performance testers en code| Makkelijk te spelen maar de bal kan nog door de muren en grond door de afstand tussen de bal en de speler maar de bal kan nog door de muren en grond| Bal is te licht dus je gooit te makkelijk over de pins.| Werkt zoals we hadden verwacht|
| #5 | Bouwblokken | De minigame spelen| Performance testers en code| Makkelijk te gebruiken maar de blokken komen regelmatig in elkaar vast te zitten| Niet getest| Niet getest|
| #5 | Basketbal | De minigame spelen| Performance testers en code| Moeilijk te spelen door de afstand tussen bal en speler. Je kan nog valsspelen door de afstand te gebruiken| Gooit door het plafond of door de muur werkt wel goed met de ballen| Makkelijk om te doen maar basketbal moet gelijk naar de speler zijn hand.|
| #5 | Knoppenmanager | De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Geen issues|
| #5 | Blokken spawner| De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Geen issues naast spam|
| #6 | Darten | De minigame spelen | Performance testers en code| Lastig om te spelen maar dat is de bedoeling. Dartpijl gaat nog wel vaak door het dartbord heen| pijltjes gingen niet door het dartbord, maar het gooien ging lastig door de rotatie van de pijltjes Kon niet vaak in het bord gooien, lastig.| Pijltjes gingen niet door de muur of grond dus dat is goed, alleen nog fixen dat de pijtles met de goede kant het bord in gaan om op het bord te gooien|
| #6 | Bowlen | De minigame spelen| Performance testers en code| Makkelijk te spelen maar de bal kan nog door de muren en grond door de afstand tussen de bal en de speler maar de bal kan nog door de muren en grond| Bal is te licht dus je gooit te makkelijk over de pins.| Werkt zoals we hadden verwacht|
| #6 | Bouwblokken | De minigame spelen| Performance testers en code| Makkelijk te gebruiken maar de blokken komen regelmatig in elkaar vast te zitten| Niet getest| Niet getest|
| #6 | Basketbal | De minigame spelen| Performance testers en code| Moeilijk te spelen door de afstand tussen bal en speler. Je kan nog valsspelen door de afstand te gebruiken| Gooit door het plafond of door de muur werkt wel goed met de ballen| Makkelijk om te doen maar basketbal moet gelijk naar de speler zijn hand.|
| #6 | Knoppenmanager | De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Niet getest| Niet getest|
| #6 | Blokken spawner| De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Niet getest| Niet getest|
| #7 | Darten | De minigame spelen | Performance testers en code| Lastig om te spelen maar dat is de bedoeling. Dartpijl gaat nog wel vaak door het dartbord heen| pijltjes gingen niet door de grond of muur, wel lastig.| Werkt beter als verwacht met clipping. pijltjes moeten gelijk naar je hand als je ze oppakt|
| #7 | Bowlen | De minigame spelen| Performance testers en code| Makkelijk te spelen maar de bal kan nog door de muren en grond door de afstand tussen de bal en de speler maar de bal kan nog door de muren en grond| Bal is te licht dus je gooit te makkelijk over de pins.| Werkt zoals we hadden verwacht. gelijk naar hand als je de bal oppakt, dan word het makkelijker.|
| #7 | Bouwblokken | De minigame spelen| Performance testers en code| Makkelijk te gebruiken maar de blokken komen regelmatig in elkaar vast te zitten| Bouwt met blokken, blokken gaan door de muur en grond| naast dat de blokken door elkaar heen gaan geen problemen met het bouwen zelf|
| #7 | Basketbal | De minigame spelen| Performance testers en code| Moeilijk te spelen door de afstand tussen bal en speler. Je kan nog valsspelen door de afstand te gebruiken| Niet door plafond of muur gegaan, gooien ging goed| Makkelijk om te doen maar basketbal moet gelijk naar de speler zijn hand.|
| #7 | Knoppenmanager | De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Geen issues|
| #7 | Blokken spawner| De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Geen issues|
| #8 | Darten | De minigame spelen | Performance testers en code| Lastig om te spelen maar dat is de bedoeling. Dartpijl gaat nog wel vaak door het dartbord heen| Geen problemen met dat de pijltjes door de grond of muur gaan, wel lastig om goed te gooien.| Werkt beter als verwacht. Pijltjes moeten gelijk naar je hand als je ze oppakt.|
| #8 | Bowlen | De minigame spelen| Performance testers en code| Makkelijk te spelen maar de bal kan nog door de muren en grond door de afstand tussen de bal en de speler maar de bal kan nog door de muren en grond| Bal is te licht dus je gooit te makkelijk over de pins. De pins omgooien werkt goed| Werkt zoals we hadden verwacht. gelijk naar hand als je de bal oppakt, dan word het makkelijker.|
| #8 | Bouwblokken | De minigame spelen| Performance testers en code| Makkelijk te gebruiken maar de blokken komen regelmatig in elkaar vast te zitten| Bouwt veel met blokken, wel gaan de blokken weer door elkaar heen| Naast dat de blokken door elkaar of grond/muur heen gaan geen problemen met het bouwen zelf|
| #8 | Basketbal | De minigame spelen| Performance testers en code| Moeilijk te spelen door de afstand tussen bal en speler. Je kan nog valsspelen door de afstand te gebruiken| Niet door plafond of muur gegaan, gooien ging goed| Makkelijk om te doen maar basketbal moet gelijk naar de speler zijn hand.|
| #8| Knoppenmanager | De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Geen issues|
| #8 | Blokken spawner| De knoppen gebruiken| Performance code| Speler kan drukken op de knoppen en het menu verschijnt| Werkt goed| Geen issues|

## Algemene info van testers:

### Tester 1:

Vind het lastig om VR te begrijpen:
pijltjes en bowling bal als je ze pakt gelijk naar je hand toe.
pijltjes iets dichterbij het bord, langs de reset button. Anders ben je te ver weg.
basketbal gaf punt terwijl je op de rand gooit.
cooldown op de basketbal minigame anders kan je heel snel punten scoren dood vals te spelen.
tutorial slaat op waar je gebleven was. Dat word gereset worden.

### Tester 2:

pakt snel Vr op.
heeft darten snel door. zelfde issue als tester 1 met de items oppakken.
heeft snel door hoe de minigames werken.
ook de issue met tutorial.
bowlen werkt niet goed met de bal.
gebruikt de bouw blokken goed. Werkt goed en kan het snel oppakken.
gooit de bouwblokken weg via prullenbak en werkt goed.
blokken blijven in de muur zitten (clipping).
blijft lang gamen, vindt het erg leuk.

### Tester 3:

vind Vr lastig.
gaat goed met basketbal.
zelfde issue met dingen vastpakken.
bouwblokken gaan gelijk door de grond heen.
vind de bouwblokken leuk om mee te spelen.
menu button werkt goed ook met de slider.
kan valsspelen met basketbal door bal vast te pakken en omhoog en naar beneden te doen.
vindt het ook heel leuk, blijft lang gamen.

### Tester 4:

Heeft Vr snel door.
valsspelen in basketbal.
begrijpt het bowlen goed en gaat makkelijk.
heeft ook dezelfde issues als de andere tester.
weet niet goed dat je knoppen hebt op de controller.
spamt bouwblokken (misschien langere cooldown)

### Tester 5:

kijkt naar controller voor info over wat alles doet.
gooit basketbal door de muur heen.
begrijpt VR goed.
weet ook niet dat er knoppen zijn op de controller.
vind het ook erg leuk.

### Tester 6:

vindt vr lastig.
vindt darten en leuk maar is wel lastig.
bowling bal gaat door de grond. issue komt vaak voor.

### Tester 7:

vindt het lastig.
begrijpt de controls niet.
gebruikt de button op de controller.
items oppakken ging lastig.

### Tester 8:

leest de controller buttons.
begrijpt de buttons goed op de controller.
begrijpt de controls niet zo goed.
bowlen gaat goed.
Darten snel opgepakt.

<div style="page-break-after: always;"></div>

## Eindconclusie

Playtest 1 (Halverwege project):

Game werkt in grote delen wel. Er waren geen problemen met code. Grootste problemen waren: Box colliders, bowling bal, valsspelen in basketbal, de uitleg/tutorial wordt niet gevonden enitems oppakken is verwarrend en kan je mee valsspelen.

De eisen en wensen van de opdrachtgever zijn verwerkt in de game. Er zijn nog fouten in de minigames die wij er nog uit gaan halen.

## Verbetervoorstellen

Dingen die wij nog moeten aanpassen en hoe wij dat gaan doen:

### Box Colliders (Clipping Issue)

Probleem: Bouwblokken gaan vaak gemakkelijk door elkaar of door de spelomgeving heen.

Oplossing:

• Zet de Collision Detection van de Rigidbody op Continuous (of Continuous Dynamic voor bewegende objecten).
• Implementeer een script dat de status monitort: zodra een blok 1 seconde stilligt, wordt de Rigidbody op Kinematic gezet. Dit stopt alle physics-berekeningen en voorkomt doorzakken.
• Zodra de speler het blok opnieuw oppakt, wordt de Kinematic-modus direct uitgeschakeld.

Dit zorgt ervoor dat blokken die stil liggen niet meer kunnen bewegen tenzij ze worden opgepakt door de speler.

### Basketbal Score (Infinite Points Exploit)

Probleem: Spelers kunnen de bal vasthouden en handmatig door de basket heen en weer bewegen om oneindig veel punten te scoren.

Oplossing:

• Snap-to-hand: Bij het oppakken van de bal wordt de positie direct hard naar de hand van de speler gesnapt (geen offset of afstand toegestaan), zodat het makkelijker te spelen is en zodat je niet kunt valsspelen.
• Score Cooldown: Een script cooldown (bijv. 1,5 tot 2 seconden) op de trigger van de basket, zodat er niet direct achter elkaar punten geregistreerd kunnen worden om valsspelen te voorkomen.

Dit zorgt ervoor dat je niet kunt valsspelen en dat het spelen makkelijker is.

### Darten (Verkeerde Grip & Logica)

Probleem: De pijl wordt bij de punt vastgepakt met de flight (achterkant) omhoog, waardoor deze vaak achterstevoren in het dartbord belandt.

Oplossing:

• Pas de Local Position & Rotation offset van de pijl aan, zodat de pijltjes goed in je hand liggen en je de pijltjes goed naar het bord kunt gooien.
• Zorg ervoor dat het rotatie-ankerpunt dwingt dat de pijl horizontaal in de hand ligt (met de punt naar voren gericht) Zodat de pijltjes vaker met de goede kant het bord in gaan.

Dit zorgt ervoor dat de pijltjes goed vliegen naar het bord en dat het met de punt van de pijl in het bord beland.

### Bowlingbal (Physics Balans)

Probleem: De bal stijgt te snel op bij het gooien, waardoor spelers over de pins heen gooien in plaats van ertegenaan.

Oplossing:

• Hoogte-cap: Begrens de maximale Y-waarde (hoogte) van de bowlingbal-velocity of positie zodra deze gegooid wordt.
• Berekening: De maximale hoogte wordt gecapped op 5% van de huidige maximale hoogte, zodat de bal strak over de baan blijft rollen en niet zo hoog de lucht in gaat.

Dit zorgt ervoor dat de bal niet hoog gegooid kan worden zodat het meer lijkt op echt bowlen.

### Tutorial Menu:

Probleem: Spelers moeten direct weten hoe ze de tutorial kunnen overslaan als ze de game al kennen of willen spelen zonder tutorial.

Oplossing:

• Zorg dat het tutorial-scherm automatisch opent bij de start van de game.
• Plaats op de allereerste kaart / UI-scherm een duidelijke knop of instructie, zodat spelers direct de UI zouden kunnen afsluiten als ze willen beginnen zonder een tutorial.

Dit zorgt ervoor dat de speler gelijk de uitleg kan lezen of wegdrukken, zodat ze weten dat de knoppen op de controller een functie hebben.