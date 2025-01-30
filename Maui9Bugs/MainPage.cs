namespace Maui9Bugs;

public class MainPage : ContentPage
{
	public MainPage()
	{

		MenuBarItem account = new MenuBarItem { Text = "Settings" };

            MenuFlyoutItem changePasswordFlyoutItem = new MenuFlyoutItem { Text = "Profile" };
          

            MenuFlyoutItem couponMenuFlyout = new MenuFlyoutItem { Text = "Change Password" };
           

            account.Add(changePasswordFlyoutItem);
            account.Add(couponMenuFlyout);
            this.MenuBarItems.Add(account);
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}