using System;
using System.Collections.Generic;


namespace JokeGenerator {

	public class Joke {
		public string type { get; set; }
		public Value value { get; set; }
	}
	
	public class Value {
		public int id { get; set; }
		public string joke { get; set; }
		public List<string> categories { get; set; }
	}

}

