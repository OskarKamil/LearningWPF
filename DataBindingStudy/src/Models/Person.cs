namespace Learning.src.Models
{
    public enum Sex
    {
        Undefined,
        Male,
        Female
    }

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Sex Sex { get; set; }

        public Person(string name, int age, Sex sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public Person()
        {
            Name = "new person";
            Age = 0;
            Sex = Sex.Undefined;
        }

        public override string ToString()
        {
            return $"{Name}, {nameof(Age)}: {Age}, {Sex}";
        }
    }
}