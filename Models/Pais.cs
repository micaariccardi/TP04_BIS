 class Pais
{
    public string nombre {get;} = "";
    public string imgBandera {get;} = "";
    public int poblacion {get;}
    public DateTime fechaIndependencia {get;}
    public string atractivosTuristicos {get;} = "";

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
