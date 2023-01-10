namespace PROYECTO;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[][] matrizPeliculas = new string[10][];
        List<listaPeliculas> listPeliculas = new List<listaPeliculas>();


        using (StreamReader reader = new StreamReader("peliculas.txt"))
        {
            // Declara una lista para almacenar los elementos leídos
            List<string> elementos = new List<string>();

            // Lee cada línea del archivo
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                // Separa la línea por comas y agrega cada elemento a la lista
                string[] elementosLinea = linea.Split(',');
                elementos.AddRange(elementosLinea);
            }


            for (int i = 0; i < matrizPeliculas.Length; i++)
            {
                matrizPeliculas[i] = new string[6];
                for (int j = 0; j < matrizPeliculas[i].Length; j++)
                {
                    matrizPeliculas[i][j] = elementos[i * matrizPeliculas[i].Length + j];
                }
            }


        }

        //-----------------------------------------------------------------------------------------------------//
        //IMPRESION DE MATRIZ PELICULAS

        imprimirMatrizPeliculas(matrizPeliculas);


        //-----------------------------------------------------------------------------------------------------//
        //Inicializar Lista desde la matriz

        recorrerMatriz(matrizPeliculas, listPeliculas);

        //-----------------------------------------------------------------------------------------------------//
        //Imprimir Lista peliculas

        imprimirLista(listPeliculas);

        //Menu consola
        //












        /*







        foreach (string[] fila in matrizPeliculas)
        {
            ingresarPeliculas(fila, listaEnlazadaPeliculas);


        }

        foreach (listaPeliculas pelicula in listaEnlazadaPeliculas)
        {
            Console.WriteLine(pelicula);
        }



        string campo = "year"; // el campo por el que se debe ordenar (nombrePelicula, year o genero)
        List<listaPeliculas> values = new List<listaPeliculas>(listaEnlazadaPeliculas);
        values.Sort(new PeliculaComparer(campo));



        foreach (listaPeliculas pelicula in values)
        {
            Console.WriteLine(pelicula);
        }

        */




















    }




    /*
        public static void ingresarPeliculas(string[] fila, LinkedList<listaPeliculas> movies)
        {
            short idPelicula = short.Parse(fila[0]);
            string nombrePelicula = fila[1];
            short year = short.Parse(fila[2]);
            double calificacion = double.Parse(fila[3], CultureInfo.InvariantCulture);
            string genero = fila[4];
            string estado = fila[5];


            listaPeliculas peliculas = new listaPeliculas(idPelicula, nombrePelicula, year, calificacion, genero, estado);
            movies.AddLast(peliculas);

        }

        */

    public static void InicializarListaObjeto(string[] fila, List<listaPeliculas> movies)
    {


        short idPelicula = short.Parse(fila[0]);
        string nombrePelicula = fila[1];
        short year = short.Parse(fila[2]);
        double calificacion = double.Parse(fila[3], CultureInfo.InvariantCulture);
        string genero = fila[4];
        string estado = fila[5];

        listaPeliculas peliculas = new listaPeliculas(idPelicula, nombrePelicula, year, calificacion, genero, estado);
        movies.Add(peliculas);
    }


    public static void recorrerMatriz(string[][] peliculas, List<listaPeliculas> movies)
    {

        foreach (string[] fila in peliculas)
        {
            InicializarListaObjeto(fila, movies);


        }

    }

    private static void imprimirMatrizPeliculas(string[][] peliculas)
    {
        foreach (string[] fila in peliculas)
        {
            foreach (string elemento in fila)
            {
                Console.Write(elemento.PadRight(25));
            }
            Console.WriteLine();
        }


    }

    public static void imprimirLista(List<listaPeliculas> movies)
    {

        foreach (listaPeliculas pelicula in movies)
        {
            Console.WriteLine(pelicula);
        }

    }

    













    /*

    private static void mostrarPor(int opcion)
    {

        if (opc)













    }

    */




}














