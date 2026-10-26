namespace gym_manager_ocr.Models;

public class RegistroTicket
{
    public int Id { get; set; }
    public DateTime FechaCorte { get; set; }
    public int PlanGimnasioId { get; set; }
    public PlanGimnasio? PlanGimnasio { get; set; }
    public int CantidadVendida { get; set; }
    public decimal TotalRecaudado { get; set; }
}