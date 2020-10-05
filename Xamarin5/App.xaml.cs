using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Xamarin5
{
    [AutoRegisterForNavigation]
    public partial class App: PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }


       

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

    }
}
