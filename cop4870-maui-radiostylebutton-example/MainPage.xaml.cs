using cop4870_maui_radiostylebutton_example.ViewModels;

namespace cop4870_maui_radiostylebutton_example;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}