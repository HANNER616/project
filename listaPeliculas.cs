public class listaPeliculas
{
    // Atributos de la clase
    public short idPelicula;
    public string nombrePelicula;
    public short year;
    public double calificacion;
    public string genero;
    public string estado;

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


