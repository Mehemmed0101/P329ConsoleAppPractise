namespace P329ConsoleAppPractise.Models
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student[] Students { get; set; } = new Student[50];

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
