using VardSchema.Api.Models;

namespace VardSchema.Tests;

public class EmployeeTests
{
    [Fact]
    public void CanCreateEmployeeWithBasicInformation()
    {
        var employee = new Employee
        {
            FirstName = "Test",
            LastName = "Person",
            Role = ProfessionalRole.Nurse,
            EmploymentType = EmploymentType.FullTime,
            ContractedHoursPerWeek = 40
        };

        Assert.Equal("Test", employee.FirstName);
        Assert.Equal("Person", employee.LastName);
        Assert.Equal(ProfessionalRole.Nurse, employee.Role);
        Assert.Equal(EmploymentType.FullTime, employee.EmploymentType);
        Assert.Equal(40, employee.ContractedHoursPerWeek);
        Assert.True(employee.IsActive);
        Assert.NotEqual(Guid.Empty, employee.Id);
    }
}