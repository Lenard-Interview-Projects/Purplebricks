using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using System;
using testapp.Core.ViewModels.Properties;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testapp.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxMasterDetailPagePresentation(Position = MasterDetailPosition.Detail, NoHistory = false)]
    public partial class PropertyDetailsPage : MvxContentPage<PropertyDetailsViewModel>
    {
        public PropertyDetailsPage()
        {
            InitializeComponent();

            photosButton.GestureRecognizers.Add(new TapGestureRecognizer()          { Command = new Command(() => LayoutView(true)), });
            mapButton.GestureRecognizers.Add(new TapGestureRecognizer()             { Command = new Command(() => LayoutView(false, true)), });
            streetviewButton.GestureRecognizers.Add(new TapGestureRecognizer()      { Command = new Command(() => LayoutView(false, false, true)), });
            floorplanButton.GestureRecognizers.Add(new TapGestureRecognizer()       { Command = new Command(() => LayoutView(false, false, false, true)), });
        }

        private void LayoutView(bool photos = false, bool map = false, bool streetview = false, bool floorplan = false)
        {
            Console.WriteLine("Button Clicked");
            photosLayout.IsVisible = photos;
            mapLayout.IsVisible = map;
            streetviewLayout.IsVisible = streetview;
            floorplanLayout.IsVisible = floorplan;
        }
    }
}