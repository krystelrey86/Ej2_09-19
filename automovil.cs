namespace FlotaVehicular.Models
{
    public class Automovil : Vehiculo
    {
        public int NumeroPuertas { get; set; }
        public Automovil(double litrosCombustible, int numeroPuertas) : base(litrosCombustible)
        {
            NumeroPuertas = numeroPuertas;
        }
        public override double CalcularAutonomiaKm()
        {
            double rendimientoPorLitro = 15.0;
            return LitrosCombustible * rendimientoPorLitro;
        }
    }
}