namespace Task8
{
    public class Teacher: Staff
    {
        private readonly string subject;
        public Teacher(string name, int salary, string subject): base(name, salary)
        {
            this.subject = subject;
        }
        public override string Name {  get { return base.Name + " as Teacher"; } }
        public override void Print()
        {
            Console.WriteLine("{0} on {1}", Name, this.subject);
        }
    }
}
