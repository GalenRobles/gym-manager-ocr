namespace gym_manager_ocr.Models;

public class RegistroInventario
{
    public int Id { get; set; }
    public DateTime FechaCorte { get; set; }
    public int ProductoId { get; set; }
    public Producto? Producto { get; set; }
    public int InventarioInicial { get; set; }
    public int SurtidoCompras { get; set; }
    public int InventarioFinal { get; set; }
    public int CantidadVendida { get; set; }
    public decimal TotalRecaudado { get; set; }
}