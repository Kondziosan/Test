using System.ComponentModel;
using Xamarin.Forms;
using Zakupy.ViewModels;

namespace Zakupy.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Stuff());
        }
    }
}