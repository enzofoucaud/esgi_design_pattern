using System;

public class Utilisateur
{
  static void Main(string[] args)
  {
    LiasseVierge liasseVierge = LiasseVierge.Instance();
    Vendeur vendeur = Vendeur.Instance();
    liasseVierge.ajoute(new BonDeCommande());
    liasseVierge.ajoute(new CertificatCession());
    liasseVierge.ajoute(new DemandeImmatriculation());
    // cr�ation d'une nouvelle liasse pour deux clients
    LiasseClient liasseClient1 = new LiasseClient(
      "Martin");
    LiasseClient liasseClient2 = new LiasseClient(
      "Durant");
    liasseClient1.affiche();
    liasseClient2.affiche();
    // vendeur
    vendeur.ajoute(new BonDeCommande());
    vendeur.ajoute(new CertificatCession());
    vendeur.ajoute(new DemandeImmatriculation());
    vendeur.imprime();
  }
}
