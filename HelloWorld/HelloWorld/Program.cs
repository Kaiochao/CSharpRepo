using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
	class Program {
		static void Main(string[] args) {
			Console.Write("What's your name? ");
			string name = Console.ReadLine();

			Console.Write("What is your age? ");
			int age = int.Parse(Console.ReadLine());

			Console.WriteLine("You are a {0}-year-old poop named {1}.", age, name);

			Console.ReadKey();
		}
	}
}
