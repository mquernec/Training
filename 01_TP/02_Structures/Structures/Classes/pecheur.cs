 /// <summary>
 /// Classe Pecheur
 /// </summary>
 public class Pecheur
 {

    private string _nom;
    private string _prenom;
    private string _numeroLicence;
    public string Nom
    {
        get { return _nom; }
        set { _nom = value; }
    }

    public string Prenom
    {
        get { return _prenom; }
        set { _prenom = value; }
    }
    public string Age
    {
        get;set;

    }
    
    public string NumeroLicence => _numeroLicence;
    public Pecheur(string nom, string prenom)
    {
        _nom = nom;
        _prenom = prenom;
    }

 }