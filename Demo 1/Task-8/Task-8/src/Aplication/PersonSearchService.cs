using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class PersonSearchService
{
    public static Person SearchByName(List<Person> people, string searchQuery)
    {
         Person foundPerson = people.FirstOrDefault(p =>
        {
            string fullName = (p is Staff) ?  (searchQuery + " Staff") : searchQuery;
            return fullName.Equals(p.Name, StringComparison.OrdinalIgnoreCase);
        });
        return foundPerson;
    }
}
