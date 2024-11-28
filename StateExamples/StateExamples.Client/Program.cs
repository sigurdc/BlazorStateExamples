using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StateExamples.Client.State;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<PersonStateBasic>();
builder.Services.AddScoped<PersonStateIntermediate>();
builder.Services.AddScoped<PersonStateINotify>();

await builder.Build().RunAsync();