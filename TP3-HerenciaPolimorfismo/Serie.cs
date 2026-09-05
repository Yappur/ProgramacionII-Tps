public class Serie : ContenidoAudiovisual
{
    public int CantidadTemporadas { get; set; }

    public Serie(string titulo, int anio, int cantidadTemporadas)
        : base(titulo, anio)
    {
        if (cantidadTemporadas <= 0)
            throw new ArgumentException("Una serie debe tener al menos 1 temporada.");

        CantidadTemporadas = cantidadTemporadas;
    }

    public override void MostrarInformacion()
    {
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Serie: {Titulo}");
        Console.WriteLine($"Año: {Anio}");
        Console.WriteLine($"Temporadas: {CantidadTemporadas}");
        Console.WriteLine("---------------------------\n");
        Console.ResetColor();
    }
}