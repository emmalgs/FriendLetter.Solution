using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namesspace FriendLetter
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
      builder.Services.AddControllersWithViews();
      webApplication app = builder.Build();
      app.UseRouting();
      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );
      app.Run();
    }
  }
}