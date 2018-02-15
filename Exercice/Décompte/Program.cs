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
			Console.WriteLine("Bonjour veuillez entrer un nombre entier non nul");           // Demande une action à l'utilisateur
			bool validationOK = int.TryParse(Console.ReadLine(), out int nb);					// Vérification que la valeur saisi est bien un entier et "validationOk" = true

			if (validationOK)																	// Instruction dans le cas ou nous avons bien un chiffre entier
			{
				while (nb > 0)																		// Condition pour avoir un bouclage infini tant que "nb != 0"
				{                                                                                    
					nb--;																		  // Retirer -1 à la variable nb 
					Console.WriteLine(nb);														 // Affiche notre variable
				}
			}
			else                                                                             // Instruction dans le cas ou nous n'avons pas un chiffre entier
			{
				Console.WriteLine("Votre chiffre n'est pas valide");				      // Indiquer a l'utilisateur que son chiffre n'est pas valide
			}
																							     
			Console.ReadKey();														   // Attente de l'appuie d'une touche par l'utilisateur pour mettre fin au programme
		}
	}
}
