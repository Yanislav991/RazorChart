var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error").UseHsts();
}

app.UseHttpsRedirection()
   .UseStaticFiles()
   .UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
