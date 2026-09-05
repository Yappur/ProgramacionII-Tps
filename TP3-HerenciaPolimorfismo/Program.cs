Console.Clear();

List<ContenidoAudiovisual> catalogo = new List<ContenidoAudiovisual>();
Console.WriteLine("Bienvenido al programa de contenidos audiovisuales.\n");

catalogo.Add(new Pelicula("Inception", "Christopher Nolan", 2010, 148, 4.8, Pelicula.Genero.CienciaFiccion, new Actor("Leonardo DiCaprio")));
catalogo.Add(new Pelicula("Kill Bill: Volumen 1", "Quentin Tarantino", 2003, 111, 2.5, Pelicula.Genero.CienciaFiccion, new Actor("Uma Thurman")));
catalogo.Add(new Pelicula("The godfather", "Francis Ford Coppola", 1972, 175, 5.0, Pelicula.Genero.CienciaFiccion, new Actor("Marlon Brando")));
catalogo.Add(new Serie("Breaking Bad", 2008, 5));

int opcion;
do
{
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Agregar película");
    Console.WriteLine("2. Agregar serie");
    Console.WriteLine("3. Mostrar contenidos");
    Console.WriteLine("4. Salir");
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
            catalogo.Add(nuevaPelicula);

            Console.WriteLine("\nPelícula agregada exitosamente.\n");
            break;

        case 2:
            Console.Clear();
            Console.WriteLine("Ingrese los datos de la serie:\n");

            Console.Write("Título: ");
            string tituloSerie = Console.ReadLine();

            Console.Write("Año: ");
            int anioSerie = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de temporadas: ");
            int temporadas = int.Parse(Console.ReadLine());

            try
            {
                Serie nuevaSerie = new Serie(tituloSerie, anioSerie, temporadas);
                catalogo.Add(nuevaSerie);
                Console.WriteLine("\nSerie agregada exitosamente.\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}\n");
            }
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("Películas registradas:\n");
            foreach (var contenido in catalogo)
            {
                contenido.MostrarInformacion();
            }
            break;



        case 4:
            Console.WriteLine("Saliendo del programa...");
            return;
        default:
            Console.WriteLine("\nOpción inválida. Intente nuevamente.\n");
            break;
    }

} while (opcion != 4);

