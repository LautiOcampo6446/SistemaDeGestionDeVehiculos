public class Moto : Vehiculo
{
    public override void Acelerar()
    {
        VelocidadActual += 30;
    }

    public override void Frenar()
    {
        VelocidadActual -= 15;
    }
}