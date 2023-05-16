static class Info
{
    static List<Pais> listaPaises = new List<Pais>();
    
    static void InicializarLista()
    {
        DateTime fechaIn = new DateTime(9/7/1810); 
        Pais argentina = new Pais("Argentina", "banderaArg.png", 45810000,  fechaIn, "Obelisco");
        listaPaises.Add(argentina);
        
        fechaIn = new DateTime(30/01/1648);
        Pais holanda = new Pais("Holanda", "banderaHola.png", 17530000, fechaIn,"Casa de Ana Frank");
        listaPaises.Add(holanda);

        fechaIn = new DateTime(14/05/1948);
        Pais israel = new Pais("Israel", "banderaIsra.jpg", 9367000, fechaIn,"El Kotel");
        listaPaises.Add(israel);

        fechaIn = new DateTime(22/08/1849);
        Pais italia = new Pais("Italia", "banderaItalia.png", 58800000, fechaIn,"Coliseo de Roma");
        listaPaises.Add(italia);

        fechaIn = new DateTime(27/09/1821);
        Pais mexico = new Pais("México", "banderaMex.png", 126705138, fechaIn,"Chichén Itzá");
        listaPaises.Add(mexico);

        fechaIn = new DateTime(31/05/1961);
        Pais sudafrica = new Pais("Sudafrica", "banderaSuda.png", 60604000, fechaIn,"Parque Nacional Kruger");
        listaPaises.Add(sudafrica);
    }

    public static List<Pais> ListarPaises()
    {
        if (listaPaises.Count() == 0)
        {
            InicializarLista();
        }
        return listaPaises;
    }

    public static Pais DetallePais(string nombre)
    {
        Pais buscado = new Pais();
        
        foreach (Pais pais in listaPaises)
        {
            if(nombre == pais.nombre)
            {
                buscado = pais;
            }
        }
        
        return buscado;
    }

}