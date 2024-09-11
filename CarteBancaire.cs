public class CarteBancaire(bool isActive, string description)
{
  public DateTime Date { get; set; } = DateTime.Now;
  public bool IsActive { get; set; } = isActive;
  public string Description { get; set; } = description;

  public void blockedCard()
  {
    IsActive = false;
  }
  public void activateCard()
  {
    IsActive = true;
  }
  public void newDescription(string description)
  {
    Description = description;
  }

  public void printCard()
  {
    Console.WriteLine("--------------------------------");
    Console.WriteLine($"Date: {Date}");
    Console.WriteLine($"Activation de la carte: {IsActive}");
    Console.WriteLine($"Description: {Description}");
    Console.WriteLine("--------------------------------");
  }
}