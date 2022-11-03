# Corso .NET C# di CGM

Esercizi svolti usando C# .NET 5.0

## Esercizio Team.Exercise.Polimorfismo.Eurozone UML

``` mermaid
    classDiagram
    direction BT
    class Country{
        # Costituzione
        # Bandiera
        # Moneta
        # LinguaUfficiale
        # PIL
        # PenaMorte : bool
        + nome
        + List~City~ CitiesList
        + addCity(City) : void
        + removeCity(City) : void
    }
    class Territory{
        <<Abstract>>
        # Popolazione
        # AreaGeografica
        + Continente
    }
    class CountryUE
    class CountryEU_ONU
    class Country ONU
    class Continent{
        + List~Country~ CountryList
        + Nome
        + addCountry(Country)
        + removeCountry(Country)
    }
    class City{
        + Nome
        + List~Citizen~ CitizenList
        + List~Citizen~ comunecitizenList
        - Country
        + TimeSpan aperturaComune
        + massimoabitanti
        - RemoveCountry()
        + UpdateCountry(Country)
        + addCitizen(Citizen)
        + removeCitizen(Citizen)
        + IscriviaComune(Citizen)
        + removedaCoumune(Citizen)
    }
    class Citizen{
        + Nome
        + Cognome
        - City
        + DateTime date
        - ismaggiorenne : bool
        - RemoveCity()
        + UpdateCity(City)
        + InserisciData()
        + Apertura(City)
    }
    class CorteEuropea{
        <<Interface>>
        + penaMorte()
    }
    class EuroCentralBank{
        <<Interface>>
        + calculateSpread()
    }
    class ONU{
        <<Interface>>
        + OMS()
        + FMI()
    }
    class UnioneEuropea{
        <<Interface>>
        + monetaUnica()
        + costituzioneEuro()
        + EMA()
        checkEuroZona() : bool
    }

    Territory <|-- Country  : Inheritance
    Country <|-- CountryUE : Inheritance
    Country <|-- CountryONU : Inheritance
    Country <|-- CountryEU_ONU : Inheritance
    CountryUE <|.. EuroCentralBank : Implements
    CountryUE <|.. UnioneEuropea : Implements
    CountryUE <|.. CorteEuropea : Implements
    CountryONU <|.. ONU : Implements
    CountryONU <|.. CorteEuropea : Implements
    CountryEU_ONU <|.. ONU : Implements
    CountryEU_ONU <|.. EuroCentralBank : Implements
    CountryEU_ONU <|.. UnioneEuropea : Implements
    CountryEU_ONU <|.. CorteEuropea : Implements
    Continent *-- Country : Composition
    Country o-- City : Aggregation
    City o-- Citizen : Aggregation
```