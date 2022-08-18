namespace PagesDemo;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

	private void BackButton_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());
    }
}