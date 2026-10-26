namespace gym_manager_ocr.Models;

public class CorteCaja
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public decimal VentasInventarioCalculadas { get; set; }
    public decimal IngresoPlanesRegistrado { get; set; }
    public decimal TotalEsperado { get; set; }
    public decimal TotalEntregado { get; set; }
    public decimal Descuadre { get; set; }
}