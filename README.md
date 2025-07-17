# CS2AllCases.Console

![Static Badge](https://img.shields.io/badge/language-C%23-red)
![Static Badge](https://img.shields.io/badge/powered_by-.NET_9-blue)
![Static Badge](https://img.shields.io/badge/platforms-Windows,_Linux-purple)
![Static Badge](https://img.shields.io/badge/version-1.0-orange)
![Static Badge](https://img.shields.io/badge/developer-sergxlove-green)
![Static Badge](https://img.shields.io/badge/year-2025-green)


## Description 

CS2 Case Opener DLL — это библиотека для автоматического открытия кейсов в Counter-Strike 2. Она предоставляет простой API для интеграции в ваши программы, позволяя симулировать открытие кейсов, получать выпавшие предметы и управлять логикой дропа.

## Install

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
      ICases cases = new Chroma2Case();
      var result = cases.GetDrop();
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








