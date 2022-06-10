namespace EditorPropertiesIssue;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		txtPassword.CursorPosition = 30;
		txtPassword.SelectionLength = 10;
	}
}

