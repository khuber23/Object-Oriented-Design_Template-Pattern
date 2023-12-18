using System;

namespace TemplatePattern
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

		public override bool CustomerWantsCondiment()
		{
			string answer = this.GetUserInput();

			return answer == "y" ? true : false;
		}

		private string GetUserInput()
		{
			bool exit = true;

			string answer = "n";

			Console.Write("Would you like lemon with your tea? (y/n) ");

			while (exit)
			{
				answer = Console.ReadLine().Substring(0, 1).ToLower();

				if (answer.CompareTo("n") == 0 || answer.CompareTo("y") == 0)
				{
					exit = false;
				}
				else
				{
					Console.WriteLine("Please enter either y or n.");
				}
			}

			return answer;
		}
	}
}