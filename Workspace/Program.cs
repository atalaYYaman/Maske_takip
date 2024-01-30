using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Atalay";
            person1.LastName = "Yaman";
            person1.DateOfBirthYear = 2004;
            person1.NationalIdentity = 55693232498;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

     
    }
}