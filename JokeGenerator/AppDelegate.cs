using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace JokeGenerator {

	[Register ("AppDelegate")]

	public partial class AppDelegate : UIApplicationDelegate {
		UIWindow window;

		public override bool FinishedLaunching(UIApplication app, NSDictionary options) {
			this.window = new UIWindow(UIScreen.MainScreen.Bounds);

			var rootNavigationController = new UINavigationController();
			Main mainScreen = new Main();

			rootNavigationController.PushViewController(mainScreen, false);
			this.window.RootViewController = rootNavigationController;

			window.MakeKeyAndVisible();
			return true;
		}

	}

}

