public class Pelicula
{
    private string _titulo;
    public string Titulo
    {
        get { return _titulo; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _titulo = value;
            }
            else
            {
                throw new ArgumentException("El título no puede estar vacío.");
            }
        }
    }
    public string Director { get; set; }
    private int _anio;
    public int Anio
    {
        get { return _anio; }
        set
        {
            if (value >= 1850 && value <= DateTime.Now.Year) // La primera película se hizo en 1888
            {
                _anio = value;
            }
            else
            {
                throw new ArgumentException($"Ingresaste un año inválido.");
            }
        }
    }

    private int _duracion;// Duración en minutos
    public int Duracion
    {
        get { return _duracion; }
        set
        {
            if (value > 0 && value <= 51420) // la pelicula mas larga dura 51420min
            {
                _duracion = value;
            }
            else
            {
                throw new ArgumentException("La duración es invalida");
            }
        }
    }
    public double Puntaje { get; set; } // Puntaje de la película
    public Genero GeneroPelicula { get; set; } // Género de la película
    public Actor ActorPrincipal { get; set; }


    public enum Genero
    {
        Accion,
        Comedia,
        Drama,
        Terror,
        CienciaFiccion,
        Romance,
    }

    public Pelicula(string titulo, string director, int anio, int duracion, double puntaje, Genero genero, Actor actorPrincipal)
    {
        Titulo = titulo;
        Director = director;
        Anio = anio;
        Duracion = duracion;
        Puntaje = puntaje;
        GeneroPelicula = genero;
        ActorPrincipal = actorPrincipal;
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
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Director: {Director}");
        Console.WriteLine($"Año: {Anio}");
        Console.Write($"Duración: {Duracion} minutos/");
        CalcularDuracionEnHoras();
        ObtenerPuntaje();
        Console.WriteLine($"Género: {GeneroPelicula}");
        Console.WriteLine($"Actor Principal: {ActorPrincipal.Nombre}");
        Console.WriteLine("---------------------------\n");
        Console.ResetColor();
    }
}