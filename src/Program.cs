using OpenDKPShared.DBModels;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<OpenDkpContext>();
var app = builder.Build();

app.MapGet(
    "/",
    async (OpenDkpContext ctx) =>
    {
        return ctx.Characters.ToList();
    }
);

app.Run();
