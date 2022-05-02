namespace TecnoCarWash.Models
{
    public class Historial
    {
        public Empleado Empleado { get; set; }
        public string Vehiculo { get; set; }
        public int Valor { get; set; }
        public DateTime Dia { get; set; }
        public DateTime Hora { get; set; }
    }
}
