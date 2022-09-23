using MauiLoginClassLib;

namespace MauiLoginApp;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
    private void Signin_Clicked(System.Object sender, System.EventArgs e)
    {
        // RegisterRouthe page to be able to Shell.Navigation
        //Routing.RegisterRoute("monkeydetails", typeof(Signin));

        LoginService service = new();
         if (service.signIn() != null)
          Application.Current.MainPage = new NavigationPage(new MainPage());

        // Routing.RegisterRoute("monkeydetails", typeof(Signin));
        //Shell.Current.GoToAsync("monkeydetails", true);

        // Once the Page is close it shoudl return the FirstName
        // and the LastName to the Labels on this Page.
        // Return the user details to the app;
        // return usr;

        // clos the Page;
        // Shell.Current.GoToAsync("..");
    }
}