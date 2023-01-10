public class listaPeliculas
{
    // Atributos de la clase
    private short idPelicula;
    public string nombrePelicula;
    public short year;
    private double calificacion;
    public string genero;
    private string estado;

    // Constructor de la clase
    public listaPeliculas(short idPelicula, string nombrePelicula, short year, double calificacion, string genero, string estado)
    {
        // Inicialización de atributos
        this.idPelicula = idPelicula;
        this.nombrePelicula = nombrePelicula;
        this.year = year;
        this.calificacion = calificacion;
        this.genero = genero;
        this.estado = estado;

    }

    public listaPeliculas()
    {

    }

    public void setIdPelicula(short idPelicula)
    {
        this.idPelicula = idPelicula;
    }

    public void setNombrePelicula(string nombrePelicula)
    {
        this.nombrePelicula = nombrePelicula;
    }

    public void setYear(short year)
    {
        this.year = year;
    }

    public void setCalificacion(float calificacion)
    {
        this.calificacion = calificacion;
    }

    public void setGenero(string genero)
    {
        this.genero = genero;
    }

    public void setEstado(string estado)
    {
        this.estado = estado;
    }


    // Métodos de la clase
    public string obtenerEstado()
    {
        return estado;
    }

    public override string ToString()
    {
        return this.idPelicula + " " + this.nombrePelicula + " "+  this.year +" " +this.calificacion +" "+ this.genero +" "+ this.estado;
    }

   


}


