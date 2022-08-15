using MA20.ViewModels;
using MA20.Views;

namespace MA20;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
                .OnAppStart("/MainPage");
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<MainPage>()
                     .RegisterInstance(SemanticScreenReader.Default);

        // 進行新的頁面註冊
        containerRegistry.RegisterForNavigation<NextPage, NextPageViewModel>();
    }
}
