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
	/// Description of banque.
	/// </summary>
	public class banque
	{
		private List<Compte> mesComptes;
		private List<Type> mesTypes;
		private 
	//constructeur avec les attributs de la classe 
	public banque()
	{
		mesComptes = new List<Compte>();
		mesTypes = new List<Type>();
	}
	void ajouterType(string code, libelle)
	{
		mesTypes.Add(new Type(code, libelle));
	}
	void ajouterType(Type unType)
	{
	mesTypes.Add(unType);
	}
	
		
	}
		
}

