using Maui9Bugs.Models;
using Maui9Bugs.PageModels;

namespace Maui9Bugs.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}