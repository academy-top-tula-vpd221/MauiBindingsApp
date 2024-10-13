namespace MauiBindingsApp;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();

		//entry2.BindingContext = entry1;
		//entry2.SetBinding(Entry.TextProperty, "Text", BindingMode.OneTime);
		//Binding binding = new Binding { Source = entry1, Path = "Text", Mode = BindingMode.TwoWay, StringFormat = "Message from Entry {0}" };
		//entry2.SetBinding(Entry.TextProperty, binding);
	}
}