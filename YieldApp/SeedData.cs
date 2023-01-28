using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldApp
{
    public static class SeedData
    {
        //Standard Way
        //public static IEnumerable<Person> GetPeople()
        //{
        //    List<Person> list = new List<Person>();

        //    list.Add(new Person("Adil", "Ahmadov"));
        //    list.Add(new Person("Ramil", "Ahmadov"));
        //    list.Add(new Person("Jhon", "Smith"));
        //    list.Add(new Person("Tim", "Corey"));
        //    list.Add(new Person("Nilay", "Ahmadova"));

        //   return list;
        //}
        //Yiled Return Way
        public static IEnumerable<Person> GetPeople()
        {

            yield return new Person("Adil", "Ahmadov");
            yield return new Person("Ramil", "Ahmadov");
            yield return new Person("Jhon", "Smith");
            yield return new Person("Tim", "Corey");
            yield return new Person("Nilay", "Ahmadova");
        }
    }
}
