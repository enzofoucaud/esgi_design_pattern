using System.Collections.Generic;

// Class Vendeur in singleton
public class Vendeur
{
  private static Vendeur _instance = null;
  private static object _lock = new object();
  private List<Document> documents = new List<Document>();
  private Vendeur()
  {
  }
  public static Vendeur Instance()
  {
    if (_instance == null)
      _instance = new Vendeur();
    return _instance;
  }
  public void ajoute(Document doc)
  {
    documents.Add(doc);
  }
  public void imprime()
  {
    foreach (Document doc in documents)
      doc.imprime();
  }
}