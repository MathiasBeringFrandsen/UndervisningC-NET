namespace WebApplication1.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }

        public Person(string name, int age, DateTime birthday)
        {
            Name = name;
            Age = age;
            Birthday = birthday;
        }
    }
}
