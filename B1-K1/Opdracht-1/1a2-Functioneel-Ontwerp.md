# Functioneel Ontwerp

Versienummer : 1

Auteur : Thijmen, Marijn

Studentnummer : 0266883, 0265825

Klas : 24SDG

Datum : 2026-10-05

<div style="page-break-after: always;"></div>

## Versiebeheer

| Datum      | Versie | Wie | Wijzigingen |
| ---------- | ------ | --- | ----------- |
| 2026-10-05 | 1.0    | Thijmen | functioneel ontwerp ingevuld |
| 2026-10-05 | 1.0    | Marijn | functioneel ontwerp ingevuld |
|            |        |     |             |

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

De opdrachtgever heet Marjan de Jonge van Ruby Campus. Bij Ruby proberen ze inwoners en MKB bedrijven in Noord-Nederland te digitaliseren. Ruby wil het gebouw ontwikkelen tot een inspirerende plek waar kunst, technologie en innovatie samenkomen. Onze game gaat gebruikt worden om basis school studenten te introduceren aan VR.

## Actoren

Omdat ons project een singleplayer game is is de enige actor een gast, omdat die de game speelt zonder dat andere actoren iets kunnen doen.

### Functionele eisen en omschrijving

| Titel              | Robot maker machine                 |
| ------------------ | ----------------------------------- |
| Als een...         | Gebruiker                           |
| Wil ik...          | Een robot maken                     |
| Zodat ik...        | Met een robot kan spelen            |
| Prioriteit         | Medium                              |
| Acceptatiecriteria | Benen, torso en hoofd in machine, optioneel hoed en/of gezicht accessoire |
| Scenario           | Pak robot onderdeel, stop in machine, wanneer 3 lichaamsdelen erin zitten druk je de knop in, robot word gemaakt |
| Bijzonderheden     | nvt                                 |

| Titel              | Robot persoonlijkheid |
| ------------------ | ----------------------------------- |
| Als een...         | Gebruiker                           |
| Wil ik...          | Een robot die kan praten            |
| Zodat ik...        | Een bond vorm met AI                |
| Prioriteit         | Medium                              |
| Acceptatiecriteria | Een robot die verschillende dingen kan zeggen en reageert |
| Scenario           | Als je met de robot speelt of iets goed doet in een minigame |
| Bijzonderheden     | nvt                                 |

## Definition of Done

1. **Functionele Vereisten**:
    - Alle functionaliteiten zoals beschreven in de user story zijn geïmplementeerd.
    - De functionaliteiten voldoen aan de specificaties en acceptatiecriteria.
2. **Code Kwaliteit**:
    - De code is geschreven volgens de vastgestelde afspraken (camelcase, veel notities).
    - Er zijn geen onbehandelde compilerwaarschuwingen of -fouten.
    - De code is goed leesbaar en gedocumenteerd.
3. **Code Testing**:
    - De code van groepsgenoten wordt door elkaar getest.
    - Als code fout is, word deze aangepast door groepsgenoten met notitie erachter van wat is aangepast.
    - Alle tests slagen zonder fouten.
4. **Integratietesting**:
    - De nieuwe code is geïntegreerd in de bestaande codebase zonder conflicten.
    - Integratietests zijn uitgevoerd en alle tests slagen zonder fouten.
5. **Gebruikersacceptatietesting (UAT)**:
    - De functionaliteiten zijn getest in de productieachtige omgeving.
    - De gebruikersacceptatietests zijn succesvol afgerond.
6. **Documentatie**:
    - Alle benodigde documentatie is bijgewerkt, inclusief gebruikershandleidingen, ReadMe, Project-plan afwijkingen, enz.
7. **Deployment**:
    - De code is klaar voor implementatie naar de productieomgeving.
    - Game build moet makkelijk te downloaden zijn vanuit de repository.
8. **Code Review**:
    - Code reviews zijn uitgevoerd en eventuele feedback is geïmplementeerd.
9. **Product Owner Goedkeuring**:
    - De leidinggevende/opdrachtgever heeft de functionaliteit gecontroleerd en goedgekeurd.
10. **Geen Blokkerende Problemen**:
    - Er zijn geen bekende blokkerende problemen die de implementatie van de functionaliteit zouden verhinderen.