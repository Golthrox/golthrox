using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tirage_de_dés
{
	class Program
	{
		static void tirage()                                                          // Fonction tirage de nombre aléatoire entre 1 et 6
		{
			Random rand = new Random();                                             // Fonction Tirage
			int aleatoire = rand.Next(1, 7);                                       // Fonction Tirage
			Console.WriteLine(aleatoire);                                         // Fonction Tirage
		}

		static void Main(string[] args)
		{
			char answer;                                                                                     // Initialisation des variables
			bool start = true;                                                                              // Boolean pour rebouclage infini
			char confirm;

			Console.WriteLine("Appuyer sur une touche pour démarer le tirage de dés");                      // Démarrage du Programme
			Console.ReadKey();                                                                             // Attente d'une validation de l'utilisateur
			Console.Clear();                                                                              // Clear pour Meilleur Visibilité

			Console.WriteLine("Début du tirage.... ");                                                  // Début du tirage													                              
			tirage();                                                                                  // Appelle de ma fonction Tirage

			while (start)                                                                   // Verification de la condition de la Boolean start pour rebouclage infini.                                     
			{
				Console.WriteLine("Souhaitez vous recommencez le tirage ? \n Saisissez O pour OUI ou N pour NON ");       // Proposition pour rejouer    
				bool validationOK = char.TryParse(Console.ReadLine(), out answer);                                       // Acquisition de la réponse ( Variable : answer)

				if (validationOK && (int)answer == 79 || (int)answer == 111)                                                           //Condition si la valeur ascii de la réponse correspond à 'O' ou 'o'   
				{
					Console.Clear();                                                                                                 // Instruction réponse OUI
					Console.WriteLine("Début du nouveau tirage....");                                                               // Instruction réponse OUI
					tirage();                                                                                                      // Instruction réponse OUI
				}
				else if (validationOK && (int)answer == 78 || (int)answer == 110)                                                     // Condition si la valeur ascii de la réponse correspond à 'N' ou 'n'
				{
					Console.WriteLine("Êtes vous sûr de vouloir quitter l'application ? \n Saisissez O pour OUI ou N pour NON");    // Demande de Confirmation de la part de l'utilisateur
					bool ConfirmationOk = char.TryParse(Console.ReadLine(), out confirm);                                          // Acquisition de la réponse de confirmation ( Variable : confirm)                            			

					if (ConfirmationOk && (int)confirm == 79 || (int)confirm == 111)                         // Condition pour Confirmation Positive										                                               
					{
						Console.WriteLine("Appuyer sur une touche pour mettre fin au programme");          // Instruction réponse Confirmation OUI
						Console.ReadKey();                                                                // Instruction réponse Confirmation OUI
						Console.Clear();                                                                 // Instruction réponse Confirmation OUI
						start = false;                                                                  // Changement de Statut de la Boolean pour sortir de la condition de rebouclage infini et terminer le programme
					}
					else                                                                                             // Condition pour Confirmation Négative
					{
						Console.Clear();                                                                           // Instruction réponse Confirmation NON et début nouveau Tirage
						Console.WriteLine("Début du nouveau tirage....");                                         // Instruction réponse Confirmation NON et début nouveau Tirage
						tirage();                                                                                // Instruction réponse Confirmation NON et début nouveau Tirage
					}
				}
				else                                                                                                      // Condition Si aucune des valeurs ascii disponible n'est selectioner, retour proposition tirage
				{
					Console.Clear();                                                                                    // Instruction réponse NON VALIDE
					Console.WriteLine("Je n'ai pas compris votre réponse ! \n\n");                                     // Instruction réponse NON VALIDE
					Console.WriteLine("Veuillez appuyer sur une touche pour avoir à nouveau le choix \n");            // Instruction réponse NON VALIDE
					Console.ReadKey();                                                                               // Instruction réponse NON VALIDE
					Console.Clear();                                                                                // Instruction réponse NON VALIDE
				}
			}
		}
	}
}
