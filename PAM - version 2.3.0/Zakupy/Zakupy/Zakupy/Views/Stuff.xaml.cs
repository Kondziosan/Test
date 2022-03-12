using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zakupy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Stuff : ContentPage
    {
        
        public Stuff()
        {
            InitializeComponent();
        }

        int lblValue = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            lblValue++;
            lblDecrement.Text = lblValue.ToString();
        }

        private void lblDecrement_Clicked(object sender, EventArgs e)
        {
            lblValue--;
            lblDecrement.Text = lblValue.ToString();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            
        }
    }
}