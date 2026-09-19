namespace FlotaVehicular.Models
{
    public class Vehiculo
    {
        public double LitrosCombustible { get; set; }
        public Vehiculo(double litrosCombustible)
        {
            LitrosCombustible = litrosCombustible;
        }
        public virtual double CalcularAutonomiaKm()
        {
            return LitrosCombustible * 10.0;
        }
    }
}