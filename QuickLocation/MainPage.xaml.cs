using QuickLocation.Pages;

namespace QuickLocation;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void NewVehicleClicked(object sender, EventArgs e)
	{

        Navigation.PushAsync(new NewVehicle());



    }
    private void ViewVehicleClicked(object sender, EventArgs e)
	{


        Navigation.PushAsync(new ViewVehicle());




    }

    
}

