// using System;

// namespace esgi_design_pattern
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

// #############################################################################################

// // Class Automobile
// public abstract class Automobile
// {
//     protected string modele;
//     protected string couleur;
//     protected int puissance;
//     protected double espace;

//     public Automobile(string modele, string couleur, int puissance, double espace)
//     {
//         this.modele = modele;
//         this.couleur = couleur;
//         this.puissance = puissance;
//         this.espace = espace;
//     }

//     public abstract void afficherCaracteristiques();
// }

// #############################################################################################

// // Class AutomobileElectrique : Automobile
// public class AutomobileElectrique : Automobile
// {
//     public AutomobileElectrique(string modele, string couleur, int puissance, double espace) : base(modele, couleur, puissance, espace)
//     {
//     }

//     public override void afficherCaracteristiques()
//     {
//         Console.WriteLine("Automobile électrique :");
//         Console.WriteLine("Modele : " + modele);
//         Console.WriteLine("Couleur : " + couleur);
//         Console.WriteLine("Puissance : " + puissance);
//         Console.WriteLine("Espace : " + espace);
//     }
// }

// #############################################################################################

// // Interface FabriqueAutomobile
// public interface FabriqueAutomobile
// {
//     public Automobile creerAutomobile(string modele, string couleur, int puissance, double espace){
//         return new AutomobileElectrique(modele, couleur, puissance, espace);
//     }
// }

// #############################################################################################

// // Class FabriqueAutomobileElectrique : FabriqueAutomobile
// public class FabriqueAutomobileElectrique : FabriqueAutomobile
// {
//     public Automobile creerAutomobile(string modele, string couleur, int puissance, double espace)
//     {
//         return new AutomobileElectrique(modele, couleur, puissance, espace);
//     }
// }

// // Class FabriqueAutomobileEssence : FabriqueAutomobile
// public class FabriqueAutomobileEssence : FabriqueAutomobile
// {
//     public Automobile creerAutomobile(string modele, string couleur, int puissance, double espace)
//     {
//         return new AutomobileEssence(modele, couleur, puissance, espace);
//     }
// }

// #############################################################################################

// // Class Catalogue
// public class Catalogue
// {
//     public static int vehicleNumber = 3;

//     static void Main(string[] args)
//     {
//         FabriqueAutomobile fabrique = new FabriqueAutomobileElectrique();
//         Automobile auto = fabrique.creerAutomobile("Renault", "Clio", 75, 1.0);
//         auto.afficherCaracteristiques();
//     }
// }

// #############################################################################################

