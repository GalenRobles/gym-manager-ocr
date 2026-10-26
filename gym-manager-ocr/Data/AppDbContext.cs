using gym_manager_ocr.Models;
using Microsoft.EntityFrameworkCore;

namespace gym_manager_ocr.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Producto> Productos { get; set; }
    public DbSet<PlanGimnasio> PlanesGimnasio { get; set; }
    public DbSet<RegistroInventario> RegistrosInventario { get; set; }
    public DbSet<RegistroTicket> RegistrosTickets { get; set; }
    public DbSet<CorteCaja> CortesCaja { get; set; }
}