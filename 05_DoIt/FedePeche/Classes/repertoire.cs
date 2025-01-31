public class Repertoire 
{
    public List<Pecheur> Pecheurs { get; set; }

    public Repertoire()
    {
        Pecheurs = new List<Pecheur>();
    }

    public void AjouterPecheur(string nom, string prenom,MembreFederation createur)
    {   Pecheur pecheur = new Pecheur();
        pecheur.Nom = nom;
        pecheur.Prenom = prenom;
        pecheur.CreerPar = createur;

        Pecheurs.Add(pecheur);
    }

    public void SupprimerPecheur(Pecheur contact)
    {
        Pecheurs.Remove(contact);
    }

    public void AfficherPecheurs()
    {
        foreach (Pecheur pecheur in Pecheurs)
        {
            Console.WriteLine(pecheur);
        }
    }
}