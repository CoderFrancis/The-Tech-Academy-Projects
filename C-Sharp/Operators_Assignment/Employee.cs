namespace EmployeeComparison
{
    // Create an Employee class with properties: Id, FirstName, and LastName
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the "==" operator to compare Employee objects based on their Id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if the Id values of the two employees are equal
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator to compare Employee objects based on their Id property
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Check if the Id values of the two employees are not equal
            return emp1.Id != emp2.Id;
        }
    }
}
