var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var rand = new Random();
var id=rand.Next();
string sayHello(){

return $"api:{id} response=ok ok ok {DateTime.Now}";
}

app.MapGet("/", () => sayHello());

app.Run();
