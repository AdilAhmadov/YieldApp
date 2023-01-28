namespace YieldApp
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine($"Initialized: {FirstName } { LastName }");
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return string.Format($"Full Name: {FirstName} {LastName}");
        }
    }
}
