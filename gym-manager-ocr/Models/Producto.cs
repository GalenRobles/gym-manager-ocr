namespace gym_manager_ocr.Models;

public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public decimal PrecioVenta { get; set; }
    public int StockActual { get; set; }
    public bool Activo { get; set; } = true;
}