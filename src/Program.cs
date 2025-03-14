using OpenDKPShared.DBModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<OpenDkpContext>();
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/openapi/v1.json", "v1");
});

app.MapGet(
    "/",
    async (OpenDkpContext ctx) =>
    {
        return ctx.Characters.ToList();
    }
);

app.Run();
