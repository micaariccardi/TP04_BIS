class Pais
{
    public string nombre {get;} = "";
    public string imgBandera {get;} = "";
    int poblacion {get;}
    DateTime fechaIndependencia {get;}
    string atractivosTuristicos {get;} = "";

    public Pais() {}
    public Pais(string nom, string imgB, int pob, DateTime fechaIn, string atractivosT)
    {
        nombre = nom;
        imgBandera = imgB;
        poblacion = pob;
        fechaIndependencia = fechaIn;
        atractivosTuristicos = atractivosT;
    }
}
