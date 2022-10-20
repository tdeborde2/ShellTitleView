namespace ShellNavPageTitleView;

public partial class TitleView : ContentView
{
	public TitleView()
	{
		InitializeComponent();
	}

    void Menu_Tapped(object sender, EventArgs e)
    {
		App.Shell.FlyoutIsPresented = !App.Shell.FlyoutIsPresented;
    }
}
