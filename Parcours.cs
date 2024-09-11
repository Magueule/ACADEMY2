public class Parcours
{
  EtatHistorique etatHistorique = new EtatHistorique();

  public void ParcoursInitialisation(CarteBancaire maCarte)
  {
    Console.WriteLine("Bonjour. Vous venez de faire la demande pour une carte bancaire.");
    etatHistorique.ajoutHistorique(new CarteBancaire(false, "Création de la carte."));
  }
  public void ParcoursActivation(CarteBancaire maCarte)
  {
    Console.WriteLine("Votre carte est active. Voulez-vous la désactiver ?");
    Console.WriteLine("Pour désactiver, Taper 1.");
    Console.WriteLine("Pour voir l'historique, Taper 2.");
    string? response = Console.ReadLine();
    if (response == "1")
    {
      maCarte.IsActive = false;
      Console.WriteLine("Veuillez ajouter une description.");
      string? description = Console.ReadLine();
      maCarte.newDescription(description);
      etatHistorique.ajoutHistorique(new CarteBancaire(false, description));
    }
    else if (response == "2")
    {
      etatHistorique.voirHistorique();
    }
    else
    {
      Console.WriteLine("Commande Invalide.");
    }
  }

  public void ParcoursDésactivation(CarteBancaire maCarte)
  {
    Console.WriteLine("Votre carte est inactive. Voulez-vous l'activer ?");
    Console.WriteLine("Pour l'activer, Taper 1.");
    Console.WriteLine("Pour voir l'historique, Taper 2.");
    string? response = Console.ReadLine();
    if (response == "1")
    {
      maCarte.IsActive = true;
      Console.WriteLine("Veuillez ajouter une description.");
      string? description = Console.ReadLine();
      maCarte.newDescription(description);
      etatHistorique.ajoutHistorique(new CarteBancaire(true, description));
    }
    else if (response == "2")
    {
      etatHistorique.voirHistorique();
    }
    else
    {
      Console.WriteLine("Commande Invalide.");
    }
  }
}