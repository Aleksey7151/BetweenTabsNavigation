using System;
using System.Linq;
using BetweenTabsNavigation.Core.ViewModels;
using FlexiMvvm.Views;
using UIKit;

namespace BetweenTabsNavigation.iOS.Views
{
    internal sealed class BottomTabBarViewController : BindableTabBarController<BottomTabBarViewModel>
    {
        public NavigationController FirstTabNavigationController { get; private set; }

        public NavigationController SecondTabNavigationController { get; private set; }

        public NavigationController ThirdTabNavigationController { get; private set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            FirstTabNavigationController = new NavigationController
            {
                TabBarItem = new UITabBarItem("Tab 1", null, null)
            };

            SecondTabNavigationController = new NavigationController
            {
                TabBarItem = new UITabBarItem("Tab 2", null, null)
            };

            ThirdTabNavigationController = new NavigationController
            {
                TabBarItem = new UITabBarItem("Tab 2", null, null)
            };

            ViewControllers = new[]
            {
                FirstTabNavigationController,
                SecondTabNavigationController,
                ThirdTabNavigationController
            };

            ShouldSelectViewController = ShouldSetContent;
            this.ViewControllerSelectedWeakSubscribe(BottomTabBarViewController_ViewControllerSelected);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            NavigationController.NavigationBarHidden = true;
        }

        public void SetContent(NavigationController tabNavigationController, Func<ViewController> tabContentViewControllerFactory)
        {
            if (!tabNavigationController.ViewControllers.Any())
            {
                tabNavigationController.PushViewController(tabContentViewControllerFactory(), false);
            }

            SelectedViewController = tabNavigationController;
        }

        private bool ShouldSetContent(UITabBarController tabBarController, UIViewController viewController)
        {
            var item = (BottomTabBarItem)Array.IndexOf(ViewControllers, viewController);

            return ViewModel.NavigateToItemCommand.CanExecute(item);
        }

        private void BottomTabBarViewController_ViewControllerSelected(object sender, UITabBarSelectionEventArgs e)
        {
            var item = (BottomTabBarItem)Array.IndexOf(ViewControllers, e.ViewController);

            ViewModel.NavigateToItemCommand.Execute(item);
        }
    }
}