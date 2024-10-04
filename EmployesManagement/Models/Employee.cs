namespace EmployesManagement.Models
{
    public class Employee: UserActivity
    {
        public int Id { get; set; }

        public string EmployeeNumber { get; set; }

        public string FirstName { get; set; }


        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {MiddleName}  {LastName}";

        public string PhoneNumber { get; set; }

        public string EmailAddress{ get; set; }

        public string Country { get; set; }

        public string DataOfBirth{ get; set; }

        public string Address { get; set; }

        public string Departament { get; set; }


    }
}
