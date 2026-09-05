Console.Clear();

List<Pelicula> PeliculasEnlistadas = new List<Pelicula>();
Console.WriteLine("Bienvenido al programa de películas.\n");

Pelicula pelicula1 = new Pelicula("Inception", "Christopher Nolan", 2010, 148, 4.8, Pelicula.Genero.CienciaFiccion, new Actor("Leonardo DiCaprio"));
PeliculasEnlistadas.Add(pelicula1);

Pelicula pelicula2 = new Pelicula("Kill Bill: Volumen 1", "Quentin Tarantino", 2003, 111, 2.5, Pelicula.Genero.CienciaFiccion, new Actor("Uma Thurman"));
PeliculasEnlistadas.Add(pelicula2);

Pelicula pelicula3 = new Pelicula("The godfather", "Francis Ford Coppola", 1972, 175, 5.0, Pelicula.Genero.CienciaFiccion, new Actor("Marlon Brando"));
PeliculasEnlistadas.Add(pelicula3);

int opcion;
do
{
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Agregar película");
    Console.WriteLine("2. Mostrar películas");
    Console.WriteLine("3. Salir");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Ingrese los datos de la película:\n");

            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Director: ");
            string director = Console.ReadLine();

            Console.Write("Año: ");
            int anio = int.Parse(Console.ReadLine());

            Console.Write("Duración (en minutos): ");
            int duracion = int.Parse(Console.ReadLine());

            Console.Write("Puntaje (0.0 a 5.0): ");
            double puntaje = double.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione el género de la película:");
            foreach (var genero in Enum.GetValues(typeof(Pelicula.Genero)))
            {
                Console.WriteLine($"{(int)genero} - {genero}");
            }
            int generoSeleccionado = int.Parse(Console.ReadLine());
            Pelicula.Genero generoPelicula = (Pelicula.Genero)generoSeleccionado;

            Console.Write("Nombre del actor principal: ");
            string nombreActor = Console.ReadLine();
            Actor actorPrincipal = new Actor(nombreActor);

            Pelicula nuevaPelicula = new Pelicula(titulo, director, anio, duracion, puntaje, generoPelicula, actorPrincipal);
            PeliculasEnlistadas.Add(nuevaPelicula);

            Console.WriteLine("\nPelícula agregada exitosamente.\n");
            break;

        case 2:
            Console.Clear();
            Console.WriteLine("Películas registradas:\n");
            foreach (var pelicula in PeliculasEnlistadas)
            {
                pelicula.MostrarInformacion();
            }
            break;

        case 3:
            Console.WriteLine("Saliendo del programa...");
            return;
        default:
            Console.WriteLine("\nOpción inválida. Intente nuevamente.\n");
            break;
    }

} while (opcion != 3);

