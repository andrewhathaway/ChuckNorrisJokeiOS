// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace JokeGenerator
{
	[Register ("Main")]
	partial class Main
	{
		[Outlet]
		MonoTouch.UIKit.UITextField txtOutput { get; set; }

		[Action ("btnGrabJoke:")]
		partial void btnGrabJoke (MonoTouch.Foundation.NSObject sender);

		[Action ("btnTweet:")]
		partial void btnTweet (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (txtOutput != null) {
				txtOutput.Dispose ();
				txtOutput = null;
			}
		}
	}
}
