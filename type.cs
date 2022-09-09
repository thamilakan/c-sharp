/*
 * Crée par SharpDevelop.
 * Utilisateur: dharmapalan_t
 * Date: 09/09/2022
 * Heure: 15:53
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;

namespace banque
{
	/// <summary>
	/// Description of type.
	/// </summary>
	public class type
	{
		private int code;
		private string libelle;
		
		//constructur avec les attributs
		public type(int code,string libelle)
		{
			this.code=code;
			this.libelle=libelle;	
		}
		
		//prpriétes
		public int Code
		{
			get{return code;}
			set{code=value;}
		}		
		
		public string Libelle
		{
			get{return libelle;}
			set{libelle=value;}
		}		
				
		public void Afficher ()
		{
			Console.WriteLine(""+this.Code);	
			Console.WriteLine(""+this.Libelle);		
		}	
				
		
		
	}
}
