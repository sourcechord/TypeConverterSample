using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConverterWpf
{
    [TypeConverter(typeof(PersonTypeConverter))]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PersonTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
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
