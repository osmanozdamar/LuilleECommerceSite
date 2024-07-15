namespace LuilleWebAPI.Entities.Concreate
{
    public class Employee
    {   
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Street { get; set; }
        public string? SiteName { get; set; }
        public string? ApartmentNumber { get; set; }
        public string? IndoorNumber { get; set; }

    }
}
