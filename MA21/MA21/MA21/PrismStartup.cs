using MA21.ViewModels;
using MA21.Views;

namespace MA21;

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

        // 記得要註冊新的頁面，否則 XAML 導航宣告將會無效用
        containerRegistry.RegisterForNavigation<NextPage, NextPageViewModel>();
    }
}
