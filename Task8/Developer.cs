namespace Task8
{
    public class Developer: Staff
    {
        private string level;
        public Developer(string name, int salary, string level): base(name, salary)
        {
            this.level = level;
        }
        public override string Name { get { return string.Format("{0}; {1} developer", base.Name, this.level); } }
        public override void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
