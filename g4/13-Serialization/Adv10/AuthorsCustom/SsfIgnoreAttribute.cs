using System;

namespace AuthorsCustom
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal class SsfIgnoreAttribute : Attribute
    {
    }
}