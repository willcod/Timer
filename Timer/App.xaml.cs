using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;
using Timer.Views;

namespace Timer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }
    }
}