static class Info
{
    static List<Pais> listaPaises = new List<Pais>();
    
    static void InicializarLista()
    {
        DateTime fechaIn = new DateTime(1810, 07, 09); 
        Pais argentina = new Pais("Argentina", "banderaArg.png", 45810000,  fechaIn, "Obelisco");
        listaPaises.Add(argentina);
        
        fechaIn = new DateTime(1648, 01, 30);
        Pais holanda = new Pais("Holanda", "banderaHola.png", 17530000, fechaIn,"Casa de Ana Frank");
        listaPaises.Add(holanda);

        fechaIn = new DateTime(1948, 05, 14);
        Pais israel = new Pais("Israel", "banderaIsra.jpg", 9367000, fechaIn,"El Kotel");
        listaPaises.Add(israel);

        fechaIn = new DateTime(1849, 08, 22);
        Pais italia = new Pais("Italia", "banderaItalia.png", 58800000, fechaIn,"Coliseo de Roma");
        listaPaises.Add(italia);

        fechaIn = new DateTime(1821, 09, 27);
        Pais mexico = new Pais("México", "banderaMex.png", 126705138, fechaIn,"Chichén Itzá");
        listaPaises.Add(mexico);

        fechaIn = new DateTime(1961, 05, 31);
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