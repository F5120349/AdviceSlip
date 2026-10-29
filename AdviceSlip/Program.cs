using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using AdviceSlip.Dtos;

// Set base URL for the web service API
const string baseUrl = "https://api.adviceslip.com/";

// Match JSON property names regardless of uppercase or lowercase
var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

// Set the main website address so later calls only need the path (e.g. "advice")
var client = new HttpClient
{
    BaseAddress = new Uri(baseUrl)
};

try
{
    // Send a GET request to the endpoint and get the response
    HttpResponseMessage response = client.GetAsync("testing").Result;

    // Ensure the request was successful (throws an exception if not)
    response.EnsureSuccessStatusCode();

    // Read the response content as a string
    string responseBody = response.Content.ReadAsStringAsync().Result;

    // Convert the JSON string to an Advice object
    var advice = JsonSerializer.Deserialize<AdviceResponse>(responseBody, options);

    // Check if the advice object is null
    if (advice != null)
    {
        // Display the advice in the console
        Console.WriteLine("Here's some advice for you:");
        Console.WriteLine(advice.slip.advice);
        Console.WriteLine($"Advice ID: {advice.slip.id}");
    }
    else
    {
        Console.WriteLine("Failed to fetch the advice.");
    }
}
catch (HttpRequestException e)
{
    // Handle any HTTP request errors
    Console.WriteLine($"Request error: {e.Message}");
}