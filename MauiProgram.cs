using MauiApp1.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            //makes a copy and stores in memory
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModal>();

            //creates a new page every single time
            builder.Services.AddTransient<DetailPage>();
            builder.Services.AddTransient<DetailViewModel>();
            

            return builder.Build();
        }
    }
}
