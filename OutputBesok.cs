using Microsoft.Azure.Functions.Worker.Extensions.Sql;
using Microsoft.Azure.Functions.Worker.Http;
namespace AzureSQL.Besok;

public class OutputType
{
  [SqlOutput("dbo.BESOKARE", connectionStringSetting: "SqlConnectionString")]
  public BesokareModel? BesokareItem { get; set; }
  public HttpResponseData? HttpResponse { get; set; }
}
public class BesokareModel
{
  public string Name { get; set; } = default!;
  public string Email { get; set; } = default!;
}