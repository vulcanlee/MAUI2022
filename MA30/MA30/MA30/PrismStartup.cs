using MA30.ViewModels;
using MA30.Views;

namespace MA30;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
                .OnAppStart("/FlyPage/NaviPage/MainPage");
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<MainPage>()
                     .RegisterInstance(SemanticScreenReader.Default);

        containerRegistry.RegisterForNavigation<FlyPage, FlyPageViewModel>();
        containerRegistry.RegisterForNavigation<NaviPage, NaviPageViewModel>();
        containerRegistry.RegisterForNavigation<New3Page, New3PageViewModel>();
        containerRegistry.RegisterForNavigation<New2Page, New2PageViewModel>();
        containerRegistry.RegisterForNavigation<New1Page, New1PageViewModel>();
    }
}
