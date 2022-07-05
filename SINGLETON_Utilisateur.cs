using System;

public class Utilisateur
{
  static void Main(string[] args)
  {
    LiasseVierge liasseVierge = LiasseVierge.Instance();
    Document bonDeCommande = new BonDeCommande();
    Document certificatCession = new CertificatCession();
    Document demandeImmatriculation = new DemandeImmatriculation();
    liasseVierge.ajoute(bonDeCommande);
    liasseVierge.ajoute(certificatCession);
    liasseVierge.ajoute(demandeImmatriculation);
    // cr�ation d'une nouvelle liasse pour deux clients
    LiasseClient liasseClient1 = new LiasseClient(
      "Martin");
    LiasseClient liasseClient2 = new LiasseClient(
      "Durant");
    liasseClient1.affiche();
    liasseClient2.affiche();
    // Vendeur with singleton
    Vendeur vendeur = Vendeur.Instance();
    vendeur.ajoute(bonDeCommande);
    vendeur.ajoute(certificatCession);
    vendeur.ajoute(demandeImmatriculation);
    vendeur.imprime();
  }
}
