public class Moto : Vehiculo
    {
        // La moto es más rápida, así que acelera más que el auto
        public override void Acelerar()
        {
            VelocidadActual += 20; 
        }

        // Y frena distinto también
        public override void Frenar()
        {
            VelocidadActual -= 10;
        }
    }