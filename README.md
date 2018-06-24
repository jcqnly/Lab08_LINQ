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
List of all the neighborhoods:

![All Neighborhoods](/assets/allNeighborhoods.png)

List of neighborhoods with the empty neighborhood names removed:

![List With No Empty Neighborhood Names](/assets/nullsRemoved.png)

List of neighborhoods with duplicates removed:

![Dupes Removed](/assets/dupesRemoved.png)

List of neighborhoods output with a single Lambda query:

![single query](/assets/singleQuery.png)

List of neighborhoods with the final LINQ query:

![LINQ Query](/assets/finalQuery.png)


## Acknowledgements
- Many thanks to [taylorjoshuaw](https://github.com/taylorjoshuaw) 
for this README layout.
- [jaatay](https://github.com/jaatay), [IndigoShock](https://github.com/IndigoShock)
and I trudged through this together.
