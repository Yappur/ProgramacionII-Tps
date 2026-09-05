public class Actor
{
    private string _nombre;
    public string Nombre
    {
        get { return _nombre; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _nombre = value;
            }
            else
            {
                throw new ArgumentException("El nombre del actor no puede estar vacío.");
            }
        }
    }

    public Actor(string nombre)
    {
        Nombre = nombre;
    }
}