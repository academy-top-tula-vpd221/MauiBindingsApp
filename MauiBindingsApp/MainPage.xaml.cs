namespace MauiBindingsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // BindingContext
            Label labelName = new();
            Entry entryName = new();

            labelName.BindingContext = entryName;
            labelName.SetBinding(Label.TextProperty, "Text");

            //StackLayout stack = new();
            stack.Children.Add(labelName);
            stack.Children.Add(entryName);


            // Binding
            Label labelCity = new();
            Entry entryCity = new();

            Binding bindingCity = new();
            bindingCity.Source = entryCity;
            bindingCity.Path = "Text";

            labelCity.SetBinding(Label.TextProperty, bindingCity);

            stack.Children.Add(labelCity);
            stack.Children.Add(entryCity);

            EntryTag entryTag = new();
            Entry entry = new();

            entryTag.BindingContext = entry;
            entryTag.SetBinding(EntryTag.TextProperty, "Text");
            entryTag.SetBinding(EntryTag.TagProperty, "Text");
            stack.Children.Add(entryTag);
            stack.Children.Add(entry);

            Label labelTag = new();
            labelTag.BindingContext = entryTag;
            labelTag.SetBinding(Label.TextProperty, "Tag");
            stack.Children.Add(labelTag);


            this.Content = stack;
        }

        
    }

}
