namespace FlotaVehicular.Models
{
    public class Camion : Vehiculo
    {
        public double CapacidadCargaTon { get; set; }
        public Camion(double litrosCombustible, double capacidadCargaTon) : base(litrosCombustible)
        {
            CapacidadCargaTon = capacidadCargaTon;
        }
        public override double CalcularAutonomiaKm()
        {
            double rendimientoPorLitro = 4.0 - (CapacidadCargaTon * 0.2);
            if (rendimientoPorLitro < 1.0) rendimientoPorLitro = 1.0;

            return LitrosCombustible * rendimientoPorLitro;
        }
    }
}