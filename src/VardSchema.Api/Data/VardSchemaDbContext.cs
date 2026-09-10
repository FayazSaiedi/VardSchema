using Microsoft.EntityFrameworkCore;
using VardSchema.Api.Models;

namespace VardSchema.Api.Data;

public class VardSchemaDbContext : DbContext
{
    public VardSchemaDbContext(
        DbContextOptions<VardSchemaDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees => Set<Employee>();

    public DbSet<WorkShift> WorkShifts => Set<WorkShift>();
}