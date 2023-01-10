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
        menu(listPeliculas);

























































    }




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



    private static void ordenarPor(string parametroOrdenamiento, List<listaPeliculas> movies)
    {

        if (parametroOrdenamiento == "nombre")
        {

            movies.Sort(new PeliculaComparer(parametroOrdenamiento));



        }
        else if (parametroOrdenamiento == "year")
        {
            movies.Sort(new PeliculaComparer(parametroOrdenamiento));



        }
        else if (parametroOrdenamiento == "genero")
        {
            movies.Sort(new PeliculaComparer(parametroOrdenamiento));



        }
        else if (parametroOrdenamiento == "calificacion")
        {
            movies.Sort(new PeliculaComparer(parametroOrdenamiento));


        }



    }

    public static void listarPorAnio(short year, List<listaPeliculas> movies)
    {
        int count = 0;
        foreach (listaPeliculas pelicula in movies)
        {

            if (pelicula.year == year)
            {
                Console.WriteLine(pelicula);
            }
            else
            {
                count++;
                if (count == movies.Count)
                {
                    Console.WriteLine("No existen peliculas en el año ingresado!");
                }
            }


        }

    }

    public static void listarPorGenero(string genero, List<listaPeliculas> movies)
    {
        int count = 0;
        foreach (listaPeliculas pelicula in movies)
        {

            if (pelicula.genero == genero)
            {
                Console.WriteLine(pelicula);
            }
            else
            {
                count++;
                if (count == movies.Count)
                {
                    Console.WriteLine("No existen peliculas en el genero ingresado!");
                }
            }

        }

    }

    public static void imprimirPrimerasPeliculasNumeroPersonalizado(List<listaPeliculas> movies , int numeroFilas)
    {
        int contador = 0;
        foreach (listaPeliculas pelicula in movies)
        {
            Console.WriteLine(pelicula);
            contador++;
            if (contador == numeroFilas)
            {
                break;
            }

        }





    }





    public static int buscarPelicula(string nombrePelicula, List<listaPeliculas> lista)
    {
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].nombrePelicula.CompareTo(nombrePelicula) == 0)
            {
                Console.WriteLine(lista[i]);
                return i;
            }
        }
        return -1;

    }

    private static void menu(List<listaPeliculas> movies)
    {
        while (true)
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Mostrar la peliculas: ");
            Console.WriteLine("2. Ordenar por nombre: ");
            Console.WriteLine("3. Ordenar por año: ");
            Console.WriteLine("4. Ordener por genero: ");
            Console.WriteLine("5. Ingresar pelicula:");
            Console.WriteLine("6. Eliminar pelicula: ");
            Console.WriteLine("7. Listar peliculas por año de creacion: ");
            Console.WriteLine("8. Listar peliculas por genero: ");
            Console.WriteLine("9. Buscar una pelicula: ");
            Console.WriteLine("10. Imprimir las 10 peliculas con mejor puntuacion: ");
            Console.WriteLine("11. Seleccionar peliculas (maximo 5 peliculas)");
            Console.WriteLine("12. Salir");

            string Opcion = Console.ReadLine();

            switch (Opcion)
            {
                case "1":
                    {
                        imprimirLista(movies);
                        break;
                    }
                case "2":
                    {
                        string parametroOrdenamiento = "nombre";
                        ordenarPor(parametroOrdenamiento, movies);
                        imprimirLista(movies);
                        break;

                    }
                case "3":
                    {
                        string parametroOrdenamiento = "year";
                        ordenarPor(parametroOrdenamiento, movies);
                        imprimirLista(movies);
                        break;
                    }
                case "4":
                    {
                        string parametroOrdenamiento = "genero";
                        ordenarPor(parametroOrdenamiento, movies);
                        imprimirLista(movies);
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("ESTA ES LA OPCION 5");
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine("ESTA ES LA OPCION 6");
                        break;
                    }
                case "7":
                    {

                        short year = 0;
                        Console.WriteLine("Ingrese el año a buscar:");
                        year = short.Parse(Console.ReadLine());
                        listarPorAnio(year, movies);
                        break;
                    }
                case "8":
                    {
                        string genero = "";
                        Console.WriteLine("Ingrese el genero a buscar:");
                        genero = Console.ReadLine();
                        listarPorGenero(genero, movies);
                        break;
                    }
                case "9":
                    {
                        string pelicula = "";
                        var aux = 0;
                        Console.WriteLine("Ingrese el nombre de la pelicula a buscar:");
                        pelicula = Console.ReadLine();
                        aux = buscarPelicula(pelicula, movies);
                        if (aux == -1)
                        {
                            Console.WriteLine("La pelicula no se ha encontrado:");
                        }
                        break;
                    }
                case "10":
                    {

                        string campo = "calificacion";
                        ordenarPor(campo, movies);
                        imprimirPrimerasPeliculasNumeroPersonalizado(movies,10);
                        break;
                    }
                case "11":
                    {
                        


                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción inválida");
                        break;
                    }
            }

        }
    }











}














