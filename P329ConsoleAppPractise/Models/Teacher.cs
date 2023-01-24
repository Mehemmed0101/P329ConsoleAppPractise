namespace P329ConsoleAppPractise.Models
{
    internal class Teacher : Person
    {
        internal Group[] Groups { get; set; } = new Group[10];
        internal string StudySubject { get; set; }

        internal DateTime EntryDate { get; set; }


        public override string ToString()
        {
            string groups = "";
            foreach (var item in Groups)
            {
                if (item == null)
                    continue;

                groups += item + "\n";
            }

            return $"{Id} {Firstname} {Lastname} {StudySubject} {Age}\n{EntryDate}\nGroups:\n{groups}";
        }

    }
}
