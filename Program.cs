﻿//Register YOUR_API_KEY at https://www.goldapi.io/ FIRST before using thid below program
var client = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Get, "https://www.goldapi.io/api/XAU/USD");
request.Headers.Add("x-access-token", "YOUR_API_KEY");
var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());
