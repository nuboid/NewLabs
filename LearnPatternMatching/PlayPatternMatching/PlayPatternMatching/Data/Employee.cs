namespace PlayPatternMatching.Data
{
    internal class Employee
    {
        public int EmpoyeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; internal set; }
        public int YearOfBirth { get; set; }
    }
}
