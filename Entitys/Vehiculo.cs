public abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public double VelocidadActual { get; set; }

    public abstract void Acelerar();
    public abstract void Frenar();
}