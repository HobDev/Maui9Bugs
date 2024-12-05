namespace Maui9Bugs.Pages;

public partial class ManageMetaPage : ContentPage
{
	public ManageMetaPage(ManageMetaPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}