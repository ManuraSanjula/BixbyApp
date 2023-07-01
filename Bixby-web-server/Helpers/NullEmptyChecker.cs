namespace Bixby_web_server.Helpers
{
    using System;
    using System.Collections;

    public static class NullEmptyChecker
    {
        public static bool HasNullEmptyValues(object? obj)
        {
            if (obj == null)
                return true;

            Type type = obj.GetType();

            if (type.IsClass)
            {
                // Check class attributes
                foreach (var property in type.GetProperties())
                {
                    if (property.CanRead)
                    {
                        var value = property.GetValue(obj);
                        if (value == null || IsNullOrEmpty(value))
                            return true;
                    }
                }

                // Check arrays
                foreach (var field in type.GetFields())
                {
                    if (field.FieldType.IsArray)
                    {
                        var array = field.GetValue(obj) as Array;
                        if (array == null || array.Length == 0)
                            return true;
                    }
                }

                // Check dictionaries
                foreach (var field in type.GetFields())
                {
                    if (typeof(IDictionary).IsAssignableFrom(field.FieldType))
                    {
                        var dictionary = field.GetValue(obj) as IDictionary;
                        if (dictionary == null || dictionary.Count == 0)
                            return true;
                    }
                }

                // Check nested classes
                foreach (var field in type.GetFields())
                {
                    if (field.FieldType.IsClass)
                    {
                        var nestedObj = field.GetValue(obj);
                        if (HasNullEmptyValues(nestedObj))
                            return true;
                    }
                }
            }

            return false;
        }

        private static bool IsNullOrEmpty(object value)
        {
            if (value == null)
                return true;

            if (value is string str)
                return string.IsNullOrEmpty(str);

            if (value is ICollection collection)
                return collection.Count == 0;

            return false;
        }
    }
}
