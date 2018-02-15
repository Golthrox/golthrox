using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme_1
{
	class Program
	{
		static void Main(string[] args)
		{
			int nb;
			Console.WriteLine("Bonjour veuillez entrer un nombre entier svp");

			bool validationOK = int.TryParse(Console.ReadLine(), out nb);
			if (validationOK)
			{
				while (nb > 0)                              // Condition pour redescendre à 0
				{

					nb--;
					Console.WriteLine(nb);
				}
			}
			else
			{
				Console.WriteLine("Votre chiffre n'est pas valide");
			}

			Console.ReadKey(); // Touche de Validation pour fermer la fenetre a la fin
		}
	}
}
