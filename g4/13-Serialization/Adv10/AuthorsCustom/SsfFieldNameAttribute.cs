using System;

namespace AuthorsCustom
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal class SsfFieldNameAttribute : Attribute
    {
        public SsfFieldNameAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }

        public string PropertyName { get; set; }
    }
}