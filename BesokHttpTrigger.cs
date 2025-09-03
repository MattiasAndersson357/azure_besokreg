using System.Text.Json;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace AzureSQL.Besok;

public class Besok
{
    private readonly ILogger<Besok> _logger;
    private static readonly JsonSerializerOptions JsonOpts = new() { PropertyNameCaseInsensitive = true };

    public Besok(ILogger<Besok> logger)
    {
        _logger = logger;
    }

    public record BesokDto(string Name, string Email);

    [Function("Besokreg")]
    public async Task<OutputType> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequestData req)
    {
        var dto = await JsonSerializer.DeserializeAsync<BesokDto>(req.Body, JsonOpts);

        var name  = (dto?.Name  ?? "").Trim();
        var email = (dto?.Email ?? "").Trim();

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
        {
            var bad = req.CreateResponse(HttpStatusCode.BadRequest);
            await bad.WriteAsJsonAsync(new { ok = false, error = "Name and email required to function" });
            return new OutputType { HttpResponse = bad };
        }

        var response = req.CreateResponse(HttpStatusCode.OK);
        await response.WriteAsJsonAsync(new { ok = true, saved = new { name, email } });

        return new OutputType
        {
            BesokareItem = new BesokareModel { Name = name, Email = email },
            HttpResponse = response
        };
    }
}

