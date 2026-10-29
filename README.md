# AdviceSlip

A C# console application that consumes the public [Advice Slip API](https://api.adviceslip.com) to demonstrate calling a REST web service and deserialising JSON. It follows the structure of the Joke API tutorial it is based on.

> ## 🚧 Project status: work in progress
> This project is **not finished yet**. The core plumbing (HTTP client, JSON deserialisation, DTOs, error handling) is in place, but the two required features are still being built. See the checklist below for exactly what works and what doesn't.

## Project goal

Develop a C# console application that demonstrates the use of the Advice Slip API by:

1. Displaying a random advice slip
2. Displaying a list of advice related to the search term **"work"**

## Progress

- [x] Project set up (.NET 10 console app, solution file)
- [x] `HttpClient` configured with the API base URL
- [x] DTO classes created to model the JSON response (`Dtos/Advice.cs`)
- [x] JSON deserialisation with `System.Text.Json` (case-insensitive property matching)
- [x] Basic error handling for failed HTTP requests
- [x] Displays an advice slip (text and ID) in the console
- [ ] Call the correct endpoint for a **random advice slip** (`/advice`) – currently calls a placeholder endpoint (`/testing`)
- [ ] **Search** for advice with the term "work" (`/advice/search/work`) and display the list of results
- [ ] DTO for the search response (`total_results`, `query`, `slips[]`)
- [ ] Handle the "no results" case from the API
- [ ] Refactor into async methods (replace `.Result` with `async`/`await`)
- [ ] Tidy up console output and add a simple menu

## Tech stack

- C# / .NET 10
- `HttpClient` for web requests
- `System.Text.Json` for JSON parsing

## Project structure

```
AdviceSlip/
├── Program.cs        # Entry point: makes the API request and prints the result
├── Dtos/
│   └── Advice.cs     # AdviceResponse and Slip classes matching the API JSON
└── AdviceSlip.csproj
```

## Getting started

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download)

### Run it

```bash
git clone https://github.com/f5120349/AdviceSlip.git
cd AdviceSlip/AdviceSlip
dotnet run
```

## Expected output (once complete)

```
Here's some advice for you:
<random advice text>
Advice ID: 42

Advice related to "work":
1. ...
2. ...
```

## What I'm learning

- Consuming a REST API from C# with `HttpClient`
- Mapping JSON to C# classes and deserialising with `System.Text.Json`
- Handling errors from network requests

## API reference

- Random advice: `GET https://api.adviceslip.com/advice`
- Search advice: `GET https://api.adviceslip.com/advice/search/{query}`

Full documentation: https://api.adviceslip.com
