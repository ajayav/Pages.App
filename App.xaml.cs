namespace PagesDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        var navPage = new NavigationPage(new MainPage());
        navPage.BarBackgroundColor = Colors.Gold;
        navPage.BarTextColor = Colors.Honeydew;
        MainPage = new FlyoutPageDemo();
        //MainPage = navPage;

    }
}
