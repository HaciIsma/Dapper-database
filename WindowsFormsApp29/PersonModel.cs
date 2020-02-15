namespace WindowsFormsApp29
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public string FullName
        {
            get
            {
                return $"{Name} {Lastname}";
            }
        }
    }
}
