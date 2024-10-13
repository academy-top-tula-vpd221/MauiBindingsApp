namespace MauiBindingsApp;

public partial class NewPage1 : ContentPage
{
    Flight flight;

    public NewPage1()
	{
		InitializeComponent();

        flight = new() { Name = "ABC-123", From = "Moscow", To = "Irkutsk", Day = 15 };

        vstack.BindingContext = flight;

  //      lblName.SetBinding(Label.TextProperty, "Name");

  //      lblFrom.SetBinding(Label.TextProperty, "From");

  //      lblTo.SetBinding(Label.TextProperty, "To");

  //      lblDay.SetBinding(Label.TextProperty, "Day");
    }

    private void btnChange_Clicked(object sender, EventArgs e)
    {
        flight.Name = "XYZ-009";
        flight.From = "St. Peterburg";
        flight.Day = 28;
    }
}