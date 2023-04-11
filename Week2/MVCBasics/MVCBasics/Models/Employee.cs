namespace MVCBasics.Models
{
    public class Employee
    {
        //make a property for each column in the table
        public int Id { get; set; }
        //imagining that this table has a varchar column for FirstName and LastName
        public string FirstName { get; set; }
        //prop tab - shortcut for making properties
        public string LastName { get; set; }
        public string EmployeeId { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }

    }
}
