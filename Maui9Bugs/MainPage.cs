namespace Maui9Bugs;

public class MainPage : ContentPage
{
	public MainPage()
	{

		Content = new VerticalStackLayout
		{
			Padding=20,
			Spacing = 20,
			Children = 
			{
				new Label 
				{ 
					HorizontalOptions = LayoutOptions.Center, 
					VerticalOptions = LayoutOptions.Center, 
					FontSize = 30,	
					Text = "Select favourite sports from the picker below"
				},

				 new Picker
				 {
					FontSize=20, 
					HorizontalOptions = LayoutOptions.Center, 
					VerticalOptions = LayoutOptions.Center, 
					WidthRequest=400,
					Title="Select sports",
					 ItemsSource= new List<string>{"Badminton","Football","Cricket","Chess","Swimming"},
					 SelectedIndex=0	
					  }

			}
		};
	}
}