//using System.Collections.Generic;

internal class Program
{
  class Student
  {
    public int Id { get; }
    public string Name { get; }

    public Student(int id, string name)
    {
      Id = id;
      Name = name;
    }

    public override bool Equals(object? otherObject)
    {
      if (this == otherObject)
        return true;
      if (otherObject == null || otherObject.GetType() != typeof(Student))
        return false;
      Student otherStudent = (Student)otherObject;
      return Id == otherStudent.Id && Name == otherStudent.Name;
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode() ^ (Name?.GetHashCode() ?? 0);
    }

    public static HashSet<Student> GetCommonStudents(List<Student> list1, List<Student> list2)
    {
      HashSet<Student> commonStudents = new(list1);
      commonStudents.IntersectWith(list2);
      return commonStudents;
    }
  }


  private static void Main(string[] args)
  {
    Student student1 = new(1, "alvaro ballero");
    Student student2 = new(2, "alvaro basurero");
    Student student3 = new(3, "alvaro repartidordepizza");
    Student student4 = new(4, "alvaro famoso");

    Student student5 = new(1, "alvaro ballero");

    List<Student> list1 = new() { student1, student2, student3 };
    List<Student> list2 = new() { student1, student2, student4 };

    Console.WriteLine("EXPECTED: Student 1 and 2\nRESULT: ");
    foreach (Student student in Student.GetCommonStudents(list1, list2))
    {
      Console.WriteLine(student.Id + " " + student.Name + "\t");
    }


    Console.Write("\nEXPECTED: True\tRESULT: ");
    Console.WriteLine(student1.Equals(student1));

    Console.Write("EXPECTED: False\tRESULT: ");
    Console.WriteLine(student1.Equals(student2));

    Console.Write("EXPECTED: False\tRESULT: ");
    Console.WriteLine(student1.Equals(student3));

    Console.Write("EXPECTED: True\tRESULT: ");
    Console.WriteLine(student1.Equals(student4));

    Console.Write("\nEXPECTED: True\tRESULT: ");
    Console.WriteLine(student1.GetHashCode() == student5.GetHashCode());
  }
}