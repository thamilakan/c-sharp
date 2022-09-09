/*
 * Crée par SharpDevelop.
 * Utilisateur: dharmapalan_t
 * Date: 09/09/2022
 * Heure: 15:00
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;

namespace banque
{
	class Program
	{
		
		static void Main()
		{ 
			Compte c, c1 ;
			c = new Compte(); 
			c1 = new Compte(12345,"toto",1000,-500); 
			Console.WriteLine(c.ToString()); 
			Console.WriteLine(c1.ToString());
		}
			
			
			
			
			
			
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Writeline("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		
	}
}