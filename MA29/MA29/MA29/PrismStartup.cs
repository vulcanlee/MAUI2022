using MA29.ViewModels;
using MA29.Views;

namespace MA29;

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

        containerRegistry.RegisterForNavigation<NextPage, NextPageViewModel>();
        containerRegistry.RegisterForNavigation<NaviPage, NaviPageViewModel>();
        containerRegistry.RegisterForNavigation<HasTitleView, HasTitleViewViewModel>();
    }
}
