using ADOPMAUI_Lessons.ViewModels;

namespace ADOPMAUI_Lessons.Views
{

    public partial class Lesson03a : ContentPage
    {
        public Lesson03a()
        {
            InitializeComponent();
        }
        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

            if (args.SelectedItem != null)
            {
                Lesson03aViewModel pageData = args.SelectedItem as Lesson03aViewModel;
                Page page = (Page)Activator.CreateInstance(pageData.Type);
                //await Navigation.PushAsync(page);
                await Shell.Current.GoToAsync(pageData.Route);
            }
        }
    }
}