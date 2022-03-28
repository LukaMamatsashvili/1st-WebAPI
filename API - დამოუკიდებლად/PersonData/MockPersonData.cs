using API___დამოუკიდებლად.Models;
using System;
using System.Collections.Generic;

namespace API___დამოუკიდებლად.PersonData
{
    public class MockPersonData : IPerson
    {
        private List<Person> People = new List<Person>()
        {
            new Person()
            {
                id = Guid.NewGuid(),
                Firstname = "Luka",
                Lastname = "Mamatsashvili",
                Age = 19
            },
            new Person()
            {
                id = Guid.NewGuid(),
                Firstname = "Roma",
                Lastname = "Liluashvili",
                Age = 20
            },
            new Person()
            {
                id = Guid.NewGuid(),
                Firstname = "Irakli",
                Lastname = "Bitsadze",
                Age = 23
            }
        };

        public List<Person> ShowAll()
        {
            return People;
        }

        public Person ShowOne(Guid id)
        {
            return People.Find(p => p.id == id);
        }

        public void RemovePerson(Guid id)
        {
            People.Remove(People.Find(p => p.id == id));
        }

        public Person AddPerson(Person p)
        {
            p.id = Guid.NewGuid();
            People.Add(p);
            return p;
        }

        public Person EditPerson(Guid id, Person p)
        {
            People.Find(p => p.id == id);
            foreach (Person i in People)
                if (i.id == id)
                {
                    i.Firstname = p.Firstname;
                    i.Lastname = p.Lastname;
                    i.Age = p.Age;
                }
            return p;
        }
    }
} 
