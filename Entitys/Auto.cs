public class Auto : Vehiculo
{
    public override void Acelerar()
    {
        VelocidadActual += 20;
    }

    public override void Frenar()
    {
        VelocidadActual -= 5;
    }
}