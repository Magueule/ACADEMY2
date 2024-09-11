public class Exo1
{
  static void Main(string[] args)
  {
    Parcours parcours = new Parcours();
    CarteBancaire maCarte = new CarteBancaire(false, "Nouvelle carte créee.");
    parcours.ParcoursInitialisation(maCarte);
    while (true)
    {
      if (maCarte.IsActive) parcours.ParcoursActivation(maCarte);
      else parcours.ParcoursDésactivation(maCarte);
    }
  }
}