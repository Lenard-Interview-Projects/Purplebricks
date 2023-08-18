using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace testapp.Core.ViewModels.About
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            // Passing the method into the command instead of a Lamba expression to keep things simple and more organized
            VisitWebsiteCommand = new Command(PurpleBricksWebsiteUri);
        }

        private void PurpleBricksWebsiteUri()
        {
            Device.OpenUri(new Uri("http://www.purplebricks.com/"));
        }

        public ICommand VisitWebsiteCommand { get; private set; }
    }
}
