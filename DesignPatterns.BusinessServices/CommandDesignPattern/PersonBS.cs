using DesignPatterns.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BusinessServices
{
    public class PersonBS
    {
        private Person m_Person;

        public PersonBS(Person person)
        {
            this.m_Person = person;
        }

        public void AddPerson(Person person)
        {

        }

        public void DeletePerson(long? Id)
        {

        }
    }
}
