Console.Clear();
Console.WriteLine("Bienvenido al programa de películas.\n");

Pelicula pelicula1 = new Pelicula("Inception", "Christopher Nolan", 2010, 148, 4.8);
pelicula1.MostrarInformacion();

Pelicula pelicula2 = new Pelicula("Kill Bill: Volumen 1", "Quentin Tarantino", 2003, 111, 2.5);
pelicula2.MostrarInformacion();

Pelicula pelicula3 = new Pelicula("The godfather", "Francis Ford Coppola", 1972, 175, 5.0);
pelicula3.MostrarInformacion();

public class Pelicula
{
    public string Titulo { get; set; }
    public string Director { get; set; }
    public int Anio { get; set; }
    public int Duracion { get; set; } // Duración en minutos
    public double Puntaje { get; set; } // Puntaje de la película

    public Pelicula(string titulo, string director, int anio, int duracion, double puntaje)
    {
        Titulo = titulo;
        Director = director;
        Anio = anio;
        Duracion = duracion;
        Puntaje = puntaje;
    }

    public void CalcularDuracionEnHoras()
    {
        double duracionEnHoras = Duracion / 60.0;
        duracionEnHoras = Math.Round(duracionEnHoras, 2); // Redondea a 2 decimales

        Console.WriteLine($"{duracionEnHoras} hs.");
    }
    public void ObtenerPuntaje()
    {
        if (Puntaje == 5)
        {
            Console.WriteLine($"Puntaje Excelente: {Puntaje}");
        }
        else if (Puntaje >= 4)
        {
            Console.WriteLine($"Puntaje Muy Bueno: {Puntaje}");
        }
        else if (Puntaje >= 3)
        {
            Console.WriteLine($"Puntaje Bueno: {Puntaje}");
        }
        else if (Puntaje >= 2)
        {
            Console.WriteLine($"Puntaje Regular: {Puntaje}");
        }
        else if (Puntaje >= 1)
        {
            Console.WriteLine($"Puntaje Malo: {Puntaje}");
        }
        else
        {
            Console.WriteLine("La película aún no tiene puntaje.");
        }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Director: {Director}");
        Console.WriteLine($"Año: {Anio}");
        Console.Write($"Duración: {Duracion} minutos/");
        CalcularDuracionEnHoras();
        ObtenerPuntaje();
        Console.WriteLine("---------------------------\n");
    }
}