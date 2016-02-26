using System.Collections.Generic;

namespace LearningFives
{
    public static class Extensions
    {
        public static bool IsNumber(this object value)
        {
            return value is sbyte
                   || value is byte
                   || value is short
                   || value is ushort
                   || value is int
                   || value is uint
                   || value is long
                   || value is ulong
                   || value is float
                   || value is double
                   || value is decimal;
        }

        public static bool IsNumberDefault(this object value)
        {
            if (value == null) return false;

            return (value is sbyte && value.Equals(new sbyte()))
                   || (value is byte && value.Equals(new byte()))
                   || (value is short && value.Equals(new short()))
                   || (value is ushort && value.Equals(new ushort()))
                   || (value is int && value.Equals(new int()))
                   || (value is uint && value.Equals(new uint()))
                   || (value is long && value.Equals(new long()))
                   || (value is ulong && value.Equals(new ulong()))
                   || (value is float && value.Equals(new float()))
                   || (value is double && value.Equals(new double()))
                   || (value is decimal && value.Equals(new decimal()));
        }

        /// <summary>
        /// stuff
        /// </summary>
        public static List<T> FilterByObject<T>(this List<T> list, T filter)
        {
            var propertyList = typeof(T).GetProperties();

            foreach (var listObj in list)
            {
                foreach (var property in propertyList)
                {
                    if (property.GetValue(filter) == null) continue;
                    if(!property.GetValue(filter).Equals(property.GetValue(listObj)))
                    {
                        list.Remove(listObj);
                    }
                }
            }

            return list;
        } 
    }
}