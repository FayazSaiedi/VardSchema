namespace VardSchema.Api.Models;

public class Employee
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public ProfessionalRole Role { get; set; }

    public EmploymentType EmploymentType { get; set; }

    public decimal ContractedHoursPerWeek { get; set; }

    public bool IsActive { get; set; } = true;
}