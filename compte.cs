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
	/// <summary>
	/// Description of compte.
	/// </summary>
	public class compte
	{
		private int numero;
		private string nom;
		private double solde;
		private double decouvertautorise;
		
		
		//constructeur avec les attributs de la classe 
		public compte(int numero,string nom,double solde,double decouvertautorise)
		{
			this.numero=numero;
			this.nom=nom;
			this.solde=solde;
			this.decouvertautorise=decouvertautorise;
		}
		
		//prpriétes
		public int Numero
		{
			get{return numero;}
			set{numero=value;}
		}
		
		public string Nom
		{
			get{return nom;}
			set{nom=value;}
		}
		
		public double Solde
		{
			get{return solde;}
			set{solde=value;}
		}
		
		public double Decouvertautorise
		{
			get{return decouvertautorise;}
			set{decouvertautorise=value;}
		}
		
		//méthodes 
		public void Crediter(double montant){
			
			this.solde += montant;
		}
		
		public void Debiter(double montant){
			
			this.solde -= montant;
		}

		public void Afficher (){
		
			Console.WriteLine("\nNuméro de compte : "+this.Numero);
			Console.WriteLine("Solde de compte : "+this.Solde);
			Console.WriteLine("Propriétaire du compte : "+this.Nom);
			Console.WriteLine("Propriétaire du compte : "+this.Decouvertautorise);
		}

	}
}
