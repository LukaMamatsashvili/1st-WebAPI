using API___დამოუკიდებლად.Models;
using System;
using System.Collections.Generic;

namespace API___დამოუკიდებლად.PersonData
{
    public interface IPerson
    {
        List<Person> ShowAll();
        Person ShowOne(Guid id);
        void RemovePerson(Guid id);
        Person AddPerson(Person p);
        Person EditPerson(Guid id, Person p);

    }
}
