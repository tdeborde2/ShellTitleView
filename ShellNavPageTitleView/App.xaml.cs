namespace ShellNavPageTitleView;

public partial class App : Application
{
	public static Shell Shell { get; private set; }
	public App()
	{
		InitializeComponent();

		Shell = new AppShell();
		MainPage = new NavigationPage(Shell);
	}
}

