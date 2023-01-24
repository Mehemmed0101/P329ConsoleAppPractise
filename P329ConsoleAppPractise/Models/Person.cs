
namespace P329ConsoleAppPractise.Models
{
    internal class Person : Entity
    {
        internal string Firstname { get; set; }
        internal string Lastname { get; set; }
        internal string FatherName { get; set; }
        internal int Age { get; set; }

        public override string ToString()
        {
            return $"{Id} {Firstname} {Lastname} {FatherName}";
        }
    }
}
