using MA19.ViewModels;
using MA19.Views;

namespace MA19;

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

        // 進行新的頁面註冊
        containerRegistry.RegisterForNavigation<NextPage, NextPageViewModel>();

    }
}
