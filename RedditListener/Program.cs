var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

static void Main(string[] args)
{
    if (args.Length < 2)
    {
        Console.WriteLine("Usage: Example <Reddit App ID> <Reddit Refresh Token> [Reddit Access Token]");
    }
    else
    {
        string appId = args[0];
        string refreshToken = args[1];
        string accessToken = (args.Length > 2 ? args[2] : null);

        // Initialize the API library instance.  --Kris
        RedditClient reddit = new RedditClient(appId: appId, refreshToken: refreshToken, accessToken: accessToken);

        // Get info on the Reddit user authenticated by the OAuth credentials.  --Kris
        User me = reddit.Account.Me;

        Console.WriteLine("Username: " + me.Name);
        Console.WriteLine("Cake Day: " + me.Created.ToString("D"));
    }
}

        app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
