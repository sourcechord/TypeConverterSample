using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConverterUwp
{
    [Windows.Foundation.Metadata.CreateFromString(MethodName = "TypeConverterUwp.Person.ConvertToPerson")]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static Person ConvertToPerson(string value)
        {
            var text = (string)value;
            var list = text.Split(',')
                           .Select(o => o.Trim())
                           .ToList();

            if (list.Count() != 2)
            {
                throw new ArgumentException($"'{value}' Invalid value. Person must contains 2 items.");
            }

            return new Person() { FirstName = list[0], LastName = list[1] };
        }
    }
}
