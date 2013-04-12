
using System;
using System.IO;
using System.Net;
using System.Drawing;
using System.Web;	
using Newtonsoft.Json;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace JokeGenerator {
	
	public partial class Main : UIViewController {

		public const string API_BASE = "http://api.icndb.com/";
		
		public Main() : base ("Main", null) {}
		
		public override void DidReceiveMemoryWarning() {
			base.DidReceiveMemoryWarning ();
		}
		
		public override void ViewDidLoad() {
			base.ViewDidLoad();
		}

		partial void btnGrabJoke (MonoTouch.Foundation.NSObject sender) {
			var request = HttpWebRequest.Create(API_BASE + "jokes/random");
			request.Method = "GET";

			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse) {
					
				if(response.StatusCode == HttpStatusCode.OK) {
					using (StreamReader reader = new StreamReader(response.GetResponseStream())) {
						var content = reader.ReadToEnd();

						Joke new_jk = JsonConvert.DeserializeObject<Joke>(content);
						txtOutput.Text = HttpUtility.HtmlDecode(new_jk.value.joke.ToString());
					}
				} else {
					UIAlertView _notice = new UIAlertView("Response", "fucked it", null, "OKAY", null);
					_notice.Show();
				}

			}
		}
		
	}
	
}

