using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreData
{
    public class CDateTypeConverter : TypeConverter
    {
        public CDateTypeConverter() : base()
        {
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string str = (string)value;
            DateTime dtValue = new DateTime();
            DateTime.TryParse(str, out dtValue);

            return dtValue;
        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            try
            {
                DateTime dt = (DateTime)value;
                if (dt.Equals(DateTime.MinValue)) return "";
                return dt.ToShortDateString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType.Equals(typeof(string));
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType.Equals(typeof(DateTime));
        }
    }
}
