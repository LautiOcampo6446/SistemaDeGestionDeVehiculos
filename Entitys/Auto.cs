public class Auto : Vehiculo
    {
        public override void Acelerar()
        {
            VelocidadActual += 10;
        }

        public override void Frenar()
        {
            VelocidadActual -= 5;
        }
    }