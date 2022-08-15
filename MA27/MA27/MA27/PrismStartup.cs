using MA27.ViewModels;
using MA27.Views;

namespace MA27;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
                .OnAppStart("NaviPage/MainPage");
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<MainPage>()
                     .RegisterInstance(SemanticScreenReader.Default);

        // 註冊這個新的導航頁面
        containerRegistry.RegisterForNavigation<NaviPage, NaviPageViewModel>();
    }
}
