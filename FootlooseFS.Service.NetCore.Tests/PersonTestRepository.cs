﻿using FootlooseFS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootlooseFS.Service.Tests
{
    public class PersonTestRepository : TestRepository<Person>, IPersonRepository
    {
        public PersonTestRepository(List<Person> persons) : base(persons) { }

        Person IPersonRepository.Find(int personId, PersonIncludes personIncludes)
        {
            return repository.Where(p => p.PersonID == personId).FirstOrDefault();
        }

        public override Person Update(Person person)
        {
            repository.RemoveAll(p => p.PersonID == person.PersonID);
            repository.Add(person);

            return person;
        }
    }    
}
