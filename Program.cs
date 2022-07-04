using System;

namespace esgi_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

#############################################################################################

// Class Automobile
public abstract class Automobile
{
    protected string modele;
    protected string couleur;
    protected int puissance;
    protected double espace;

    public Automobile(string modele, string couleur, int puissance, double espace)
    {
        this.modele = modele;
        this.couleur = couleur;
        this.puissance = puissance;
        this.espace = espace;
    }

    public abstract void afficherCaracteristiques();
}

#############################################################################################

// Class AutomobileElectrique : Automobile
public class AutomobileElectrique : Automobile
{
    public AutomobileElectrique(string modele, string couleur, int puissance, double espace) : base(modele, couleur, puissance, espace)
    {
    }

    public override void afficherCaracteristiques()
    {
        Console.WriteLine("Automobile électrique :");
        Console.WriteLine("Modele : " + modele);
        Console.WriteLine("Couleur : " + couleur);
        Console.WriteLine("Puissance : " + puissance);
        Console.WriteLine("Espace : " + espace);
    }
}

#############################################################################################