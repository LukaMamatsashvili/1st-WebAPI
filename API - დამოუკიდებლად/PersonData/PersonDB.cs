using API___დამოუკიდებლად.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API___დამოუკიდებლად.PersonData
{
    public class PersonDB : IPerson
    {
        PersonContext Person_DB;
        public PersonDB(PersonContext PC)
        {
            Person_DB = PC;
        }

        public List<Person> ShowAll()
        {
            return Person_DB.PersonTbl.ToList();
        }

        public Person ShowOne(Guid id)
        {
            return Person_DB.PersonTbl.Find(id);
        }

        public void RemovePerson(Guid id)
        {
            Person_DB.PersonTbl.Remove(Person_DB.PersonTbl.Find(id));
            Person_DB.SaveChanges();
        }

        public Person AddPerson(Person p)
        {
            p.id = Guid.NewGuid();
            Person_DB.PersonTbl.Add(p);
            Person_DB.SaveChanges();
            return p;
        }

        public Person EditPerson(Guid id, Person p)
        {
            Person_DB.PersonTbl.Find(id);
            foreach (Person i in Person_DB.PersonTbl)
                if (i.id == id)
                {
                    i.Firstname = p.Firstname;
                    i.Lastname = p.Lastname;
                    i.Age = p.Age;
                }
            Person_DB.SaveChanges();
            return p;
        }
    }
}
