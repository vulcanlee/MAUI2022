using MA31.ViewModels;
using MA31.Views;

namespace MA31;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        //builder.RegisterTypes(RegisterTypes)
        //        .OnAppStart("NavigationPage/MainPage");
        builder.RegisterTypes(RegisterTypes)
                .OnAppStart("MyTabbedPage?createTab=New1Page&createTab=NavigationPage|New2Page&createTab=New3Page&createTab=New4Page&createTab=New5Page&selectedTab=New3Page");

    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<MainPage>()
                     .RegisterInstance(SemanticScreenReader.Default);

        containerRegistry.RegisterForNavigation<MyTabbedPage, MyTabbedPageViewModel>();
        containerRegistry.RegisterForNavigation<New1Page, New1PageViewModel>();
        containerRegistry.RegisterForNavigation<New2Page, New2PageViewModel>();
        containerRegistry.RegisterForNavigation<New3Page, New3PageViewModel>();
        containerRegistry.RegisterForNavigation<New4Page, New4PageViewModel>();
        containerRegistry.RegisterForNavigation<New5Page, New5PageViewModel>();
    }
}
