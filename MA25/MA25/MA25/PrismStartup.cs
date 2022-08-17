using MA25.ViewModels;
using MA25.Views;

namespace MA25;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
                .OnAppStart("NavigationPage/MainPage");
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<MainPage>()
                     .RegisterInstance(SemanticScreenReader.Default);

        containerRegistry.RegisterForNavigation<Page1, Page1ViewModel>();
        containerRegistry.RegisterForNavigation<Page2, Page2ViewModel>();
        containerRegistry.RegisterForNavigation<Page3, Page3ViewModel>();
    }
}
