# .net-client
Jestor SDK for .NET - Version Beta

[![Nuget](https://img.shields.io/nuget/v/Jestor-SDK?style=for-the-badge)](https://www.nuget.org/packages/Jestor-SDK/1.0.1)


Jestor client library for .net.


## Documentation

Documentation with all available functions can be found [here](https://docs.jestor.com/docs/jestor-sdk-for-.net)

## Installation

Install from Nuget using [nuget](https://www.nuget.org/packages), a package manager for Python.

`dotnet add package Jestor `


## Getting Started

Getting started with the Jestor API couldn't be easier. Create a
`Jestor` instance and you're ready to go.

```.net
var jestor = new Jestor<<Class Instance>>(<account>, <api token>);
var filters = new List<Filter>();
filters.Add(new Filter(<field name>, <argument>, <type>, <operator>));

var dados = jestor.Tables(<tab name>).Get(filters);

