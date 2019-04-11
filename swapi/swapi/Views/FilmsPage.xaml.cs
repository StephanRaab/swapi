using swapi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace swapi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilmsPage : ContentPage
    {
        public FilmsPage()
        {
            InitializeComponent();
            var VM = new FilmsViewModel();
            BindingContext = VM;

            async void PopulatePicker()
            {
                await VM.GetFilmsAsync();
            }

            PopulatePicker();
        }
    }
}