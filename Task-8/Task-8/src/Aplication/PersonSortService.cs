public class PersonSortService
{
    public static List<Person> SortPeopleByName(IEnumerable<Person> people)
    {
        return people.OrderBy(p => p.Name).ToList();
    }

    public static List<Staff> SortEmployeesBySalary(IEnumerable<Person> people)
    {
        return people.OfType<Staff>().OrderBy(e => e.Salary).ToList();
    }
}