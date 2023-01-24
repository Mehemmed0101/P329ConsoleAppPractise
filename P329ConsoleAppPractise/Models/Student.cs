namespace P329ConsoleAppPractise.Models
{
    internal class Student : Person
    {
        internal Group Group { get; set; }
        internal DateTime EntryDate { get; set; }
        internal int Course { get; set; }
        internal string[] Subjects { get; set; } = new string[10];

        public override string ToString()
        {
            string subjects = "";
            foreach (var item in Subjects)
            {
                if (item == null)
                    continue;

                subjects += item + "\n";
            }

            return $"{Id} {Firstname} {Lastname} {FatherName} {Age}\n{Group}\n{EntryDate}\n{Course}\nSubjects:\n{subjects}";
        }
    }
}
