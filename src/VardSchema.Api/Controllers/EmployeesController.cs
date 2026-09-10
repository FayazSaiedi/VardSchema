using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VardSchema.Api.Data;
using VardSchema.Api.Models;

namespace VardSchema.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly VardSchemaDbContext _dbContext;

    public EmployeesController(VardSchemaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<List<Employee>>> GetEmployees()
    {
        List<Employee> employees =
            await _dbContext.Employees.ToListAsync();

        return Ok(employees);
    }
    [HttpPost]
    public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
    {
        _dbContext.Employees.Add(employee);

        await _dbContext.SaveChangesAsync();

        return StatusCode(201, employee);
    }
}