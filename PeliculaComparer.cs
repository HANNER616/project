class PeliculaComparer : IComparer<listaPeliculas>
{
    private string campo;

    public PeliculaComparer(string campo)
    {
        this.campo = campo;
    }

    public int Compare(listaPeliculas x, listaPeliculas y)
    {
        int result = 0;
        if (campo == "nombrePelicula")
        {
            result = x.nombrePelicula.CompareTo(y.nombrePelicula);
        }
        else if (campo == "year")
        {
            result = x.year.CompareTo(y.year);
        }
        else if (campo == "genero")
        {
            result = x.genero.CompareTo(y.genero);
        }
        return result;
    }
}