using BlazyEcom.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents(); // Ensure this is the correct package for your use case
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<CartService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode(); // Ensures server components render interactively

app.Run();
