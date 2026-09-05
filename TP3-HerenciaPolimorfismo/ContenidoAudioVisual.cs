public abstract class ContenidoAudiovisual
{
    public string Titulo { get; set; }
    public int Anio { get; set; }

    public ContenidoAudiovisual(string titulo, int anio)
    {
        Titulo = titulo;
        Anio = anio;
    }

    public abstract void MostrarInformacion(); // cada hijo lo implementa distinto

}