namespace MauiBindingsApp;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();

		lblDate.BindingContext = datePicker;
		lblDate.SetBinding(Label.TextProperty, "Date",
			converter: new DateToStringConverter());
	}
}