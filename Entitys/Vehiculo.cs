public abstract class Vehiculo
{

    private string marca = "";
    private string modelo = "";
    private double velocidadActual;

    public string Marca { get => marca; set => marca = value; }
    public string Modelo { get => modelo; set => modelo = value; }
    public double VelocidadActual { get => velocidadActual; set => velocidadActual = value; }

    public abstract void Acelerar();
    public abstract void Frenar();

} 