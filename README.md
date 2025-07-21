# CS2AllCases.Console

![Static Badge](https://img.shields.io/badge/language-C%23-red)
![Static Badge](https://img.shields.io/badge/powered_by-.NET_9-blue)
![Static Badge](https://img.shields.io/badge/platforms-Windows,_Linux-purple)
![Static Badge](https://img.shields.io/badge/version-1.0-orange)
![Static Badge](https://img.shields.io/badge/developer-sergxlove-green)
![Static Badge](https://img.shields.io/badge/year-2025-green)


## Description 

CS2 Case Opener DLL — this is a library for automatically opening cases in Counter-Strike 2. It provides a simple API for integration into your programs, allowing you to simulate the opening of cases, receive dropped items and manage the logic of the drop.

## Install

1. Go to Releases in the GitHub repository.
2. Download it .zip archive.
3. Unpack.

Or clone repository :
```
git clone git@github.com:sergxlove/CS2AllCases.Consols.git
```

## Example using 

```CSharp
using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Models;

namespace CS2AllCases.Consols
{
  public class Program
  {
    
    static void Main(string[] args)
    {
      //Initialize 
      ICases cases = new Chroma2Case();
      //Getting drop
      var result = cases.GetDrop();
      //Output in console
      Console.WriteLine(result);
    }
}
```

## API Reference

### Methods class ICases

| Method            | Description                                            | Namespace              | Input                                                                                                                                                                                                       | Output       |
|-------------------|--------------------------------------------------------|------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------|
| GetDrop()         | Getting the object responsible for the skin parameters | CS2AllCases.Lib.Models | -                                                                                                                                                                                                           | ResultsItems |
| GetNameSkinsAll() | getting the names of all case skins                    | CS2AllCases.Lib.Models | bool IsSkinArmy - check skin army, bool isSkinForbidden - check skin forbidden, bool isSkinClassified - check skin classified, bool isSkinSecret - check skin secret, bool isSkinRareItem - check skin rare | string       |

### Structure class ResultItems

| Name Property | Type          | Description                 |
|---------------|---------------|-----------------------------|
| Name          | string        | Name skin                   |
| Rarity        | RarityItems   | Rarity skin                 |
| Quality       | QualityItems  | Quality skin                |
| Statrack      | StatrackItems | Indicate that statrack skin |
| Souvenir      | SouvenirItems | Indicate that statrack skin |

### Structure enum RarityItems
```CSharp
public enum RarityItems
{
    Crap = 0,
    Industrial = 1,
    Army = 2,
    Forbidden = 3,
    Classified = 4,
    Secret = 5,
    None = 6
}
```
### Structure enum QualityItems
```CSharp
public enum QualityItems
{
    BattleHardened = 0,
    Worn = 1,
    AfterFieldTesting = 2,
    SlightlyWorn = 3,
    StraightFromTheFactory = 4,
    None = 5
}
```
### Structure enum StatrackItems
```CSharp
public enum StatrackItems
{
    No = 0,
    Yes = 1
}
```
### Structure enum SouvenirItems
```CSharp
public enum SouvenirItems
{
    No = 0,
    Yes = 1
}
```


## Configuration options drop

A numerical weight (Probability*) is set for each skin quality. The total probability is calculated using the formula:
```
Probability of quality = (Weight of Quality) / (Sum of All weights)
```
Example:
```CSharp
var quality = new QualityRequest()
{
    ProbabilityBattleHardeend = 200,
    ProbabilityWorn = 200,
    ProbabilityAfterFieldTesting = 200,
    ProbabilitySlightlyWorn = 200,
    ProbabilityStraightFromTheFactory = 200
};
```
The sum of all the weights: 200 + 200 + 200 + 200 + 200 = 1000
The probability of each quality: 200 / 1000 = 20%

The configuration is configured using three classes: RarityRequest, QualityRequest, and StatrackRequest. These classes are passed to the constructor of the ProbabilitiesDropOptions class

## Aviable cases

```CSharp
public enum CasesEnum
{
    Chroma2Case = 1,
    Chroma3Case = 2,
    ChromaCase = 3,
    ClutchCase = 4,
    CS20Case = 5,
    CSGOWeaponCase = 6,
    CSGOWeapon2Case = 7,
    CSGOWeapon3Case = 8,
    DangerZoneCase = 9,
    DreamAndHightmaresCases = 10,
    ESports2013Case = 11,
    ESports2014WinterCase = 12,
    Esports2014SummerCase = 13,
    FalchionCase = 14,
    FractureCase = 15,
    GalleryCase = 16,
    Gamma2Case = 17,
    GammaCase = 18,
    GloveCase = 19,
    HorizonCase = 20,
    HuntsmanWeaponCase = 21,
    KilowattCase = 22,
    OperationBravoCase = 23,
    OperationBreakoutWeaponCase = 24,
    OperationBrokenFangCase = 25,
    OperationHydraCase = 26,
    OperationPhoenixWeaponCase = 27,
    OperationRiptideCase = 28,
    OperationVanguardWeaponCase = 29,
    OperationWildfireCase = 30,
    Prisma2Case = 31,
    PrismaCase = 32,
    RecoilCase = 33,
    RevolutionCase = 34,
    RevolverCase = 35,
    ShadowCase = 36,
    ShatteredWebCase = 37,
    SnakebiteCase = 38,
    Spectrum2Case = 39,
    SpectrumCase = 40,
    WinterOffensiveWeaponCase = 41
```









