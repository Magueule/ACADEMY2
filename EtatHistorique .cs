public class EtatHistorique
{
  public List<CarteBancaire> historique = new List<CarteBancaire>();

  public void ajoutHistorique(CarteBancaire carteBancaire)
  {
    historique.Add(carteBancaire);
  }

  public void voirHistorique()
  {
    Console.WriteLine("----------------------------");
    Console.WriteLine("Historique:");
    foreach (var etat in historique)
    {
      Console.WriteLine("Date: " + etat.Date);
      Console.WriteLine("Activée: " + etat.IsActive);
      Console.WriteLine("Description: " + etat.Description);
      Console.WriteLine("----------------------------");
    }
  }
}