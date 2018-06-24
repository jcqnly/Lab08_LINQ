# Lab08 LINQ in Manhatten

## Objective
Convert a given JSON file to C# objects, 
iterate through these objects by implementing LINQ and 
Lambda expressions to search and filter according to certain criteria.

---

## Dependencies
This application runs on .NET Core 2.1, which can be downloaded [here](https://www.microsoft.com/net/download/macos).
Additionally, the nuGet package [NewtonSoft](https://www.newtonsoft.com/json)
is needed in order to read JSON.

---
## Build
After installing the [.NET Core 2.1 SDK](https://www.microsoft.com/net/download/macos), clone this repo onto your machine. From a terminal interface, go to where this was cloned and type the following commands:

```
cd Lab08_LINQ
dotnet restore
dotnet run
```
---
## What this application does
This applcation will read in a JSON file, parse the contents into C# objects,
and then search through the objects based on search parameters.

---

## Screenshots
Proof of life that the JSON object can be displayed on the screen

![JSON Output](/assets/output.png)

This is how we envisioned breaking the objects
based on what we saw in the JSON file:

![How the classes should be divided](/assets/classMethod.jpg)

## Acknowledgements
- Many thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this README layout.
- [jaatay](https://github.com/jaatay), [IndigoShock](https://github.com/IndigoShock)
and I trudged through this together.
