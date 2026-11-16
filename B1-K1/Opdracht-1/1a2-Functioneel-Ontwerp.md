# Functioneel Ontwerp

Versienummer : 1.3

Auteur : Thijmen, Marijn

Studentnummer : 0266883, 0265825

Klas : 24SDG

Datum : 2026-11-16

<div style="page-break-after: always;"></div>

## Versiebeheer

| Datum      | Versie | Wie | Wijzigingen |
| ---------- | ------ | --- | ----------- |
| 2026-10-05 | 1.0    | Thijmen | functioneel ontwerp ingevuld |
| 2026-10-05 | 1.0    | Marijn  | functioneel ontwerp ingevuld |
| 2026-10-29 | 1.1    | Thijmen | Uitleg opdrachtgever verbeterd|
| 2026-10-05 | 1.2    | Marijn  | Spelfouten en interpunctie verbeterd|
| 2026-11-16 | 1.3    | Marijn  | Actoren beter uitgewerkt|

<div style="page-break-after: always;"></div>

## Inhoudsopgave

- [Functioneel Ontwerp](#functioneel-ontwerp)
  - [Versiebeheer](#versiebeheer)
  - [Inhoudsopgave](#inhoudsopgave)
  - [Inleiding](#inleiding)
    - [Over dit document](#over-dit-document)
    - [Over het project en de opdrachtgever](#over-het-project-en-de-opdrachtgever)
  - [Actoren](#actoren)
    - [Functionele eisen en omschrijving](#functionele-eisen-en-omschrijving)
  - [Definition of Done](#definition-of-done)

<div style="page-break-after: always;"></div>

## Inleiding

### Over dit document

In dit document worden de verschillende actoren, de user stories en de definition of done  van te bouwen applicatie vastgelegd.

### Over het project en de opdrachtgever

De opdrachtgever van ons project heet Marjan de Jonge en ze is van van Ruby Campus. Je kan bij Ruby langskomen als je vragen hebt over wat digitale ontwikkeling in jouw leven kan betekenen. Bij Ruby ondersteunen ze ondernemers met slimme adviezen om processen te verbeteren, bereik te vergroten en kansen te grijpen. En ze helpen studenten door hen opdrachten te geven om hun digitale skills sterker te maken. Ze hebben bijvoorbeeld een workshop gehad over hoe je met AI kan werken en ze hebben een toeristische databank genaamd Touripedia officieel gelanceerd bij Ruby zelf.

## Actoren

Omdat ons project een singleplayer game is, is de enige actor een gast, omdat die de game speelt zonder dat andere actoren iets kunnen doen.

De gast staat centraal in de game en voert de volgende kernacties uit:

- Een robot samenstellen: De gast gebruikt onderdelen van de robot die verspreid liggen over de kamer om een robot te maken in een robot makermachine. In de kamer liggen: Benen, torso's, hoofden, hoeden en brillen die je in de machine kunt stoppen. De hoeden en brillen zijn optioneel, als je een torso, hoofd en benen in de machine hebt kan je door middel van een knop de robot maken.

- Interactie met de robot: Na het bouwen van de robot speelt de gast ermee. De robot krijgt bij het bouwen een eigen persoonlijkheid (Blij, enthousiast, zielig, bang). De robot kan praten en reageert op acties die de gast uitvoerd. Wanneer de gast iets goed doet in een minigame reageert de robot erop. Hierdoor bouwt de gast tijdens het spelen een band op met de AI.

## Definition of Done

1. **Functionele Vereisten**:
    - Alle functionaliteiten zoals beschreven in de user story zijn geïmplementeerd.
    - De functionaliteiten voldoen aan de specificaties en acceptatiecriteria.
2. **Code Kwaliteit**:
    - De code is geschreven volgens de vastgestelde afspraken (camelCase, veel notities).
    - Er zijn geen onbehandelde compilerwaarschuwingen of -fouten.
    - De code is goed leesbaar en gedocumenteerd.
3. **Code Testing**:
    - De code van groepsgenoten wordt door elkaar getest.
    - Als code fout is, wordt deze aangepast door groepsgenoten met notitie erachter van wat is aangepast.
    - Alle tests slagen zonder fouten.
4. **Integratietesting**:
    - De nieuwe code is geïntegreerd in de bestaande codebase zonder conflicten.
    - Integratietests zijn uitgevoerd en alle tests slagen zonder fouten.
5. **Gebruikersacceptatietesting (UAT)**:
    - De functionaliteiten zijn getest in de productieachtige omgeving.
    - De gebruikersacceptatietests zijn succesvol afgerond.
6. **Documentatie**:
    - Alle benodigde documentatie is bijgewerkt, inclusief gebruikershandleidingen, README, projectplan, afwijkingen, enz.
7. **Deployment**:
    - De code is klaar voor implementatie naar de productieomgeving.
    - De game build moet makkelijk te downloaden zijn vanuit de repository.
8. **Code Review**:
    - Code reviews zijn uitgevoerd en eventuele feedback is geïmplementeerd.
9. **Product Owner Goedkeuring**:
    - De leidinggevende/opdrachtgever heeft de functionaliteit gecontroleerd en goedgekeurd.
10. **Geen Blokkerende Problemen**:
    - Er zijn geen bekende blokkerende problemen die de implementatie van de functionaliteit zouden verhinderen.