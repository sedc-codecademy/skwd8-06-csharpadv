using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Reflection;

namespace AuthorsCustom
{
    public static class SedcSerialization
    {
        //public static string Serialize(Author author)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("Author:");
        //    sb.AppendLine($@"    ID = {author.ID}");
        //    sb.AppendLine($@"    Name = ""{author.Name}""");
        //    sb.AppendLine($@"    Nominations = {author.Nominations}");
        //    sb.AppendLine($@"    Wins = {author.Wins}");
        //    return sb.ToString();
        //}

        //public static Task SerializeToFile(Author author, string filename)
        //{
        //    var content = Serialize(author);
        //    return File.WriteAllTextAsync(filename, content);
        //}
        public static async Task SerializeToFile2(Author author, string filename)
        {
            var content = Serialize(author);
            await File.WriteAllTextAsync(filename, content);
        }

        //public static string Serialize(Book book)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine("Book:");
        //    sb.AppendLine($@"    ID = {book.ID}");
        //    sb.AppendLine($@"    Title = ""{book.Title}""");
        //    sb.AppendLine($@"    Nominations = {book.Nominations}");
        //    sb.AppendLine($@"    Wins = {book.Wins}");
        //    sb.AppendLine($@"    Year = {book.Year}");
        //    sb.AppendLine($@"    ImageName = ""{book.ImageName}""");
        //    return sb.ToString();
        //}

        //public static Task SerializeToFile(Book book, string filename)
        //{
        //    var content = Serialize(book);
        //    return File.WriteAllTextAsync(filename, content);
        //}

        public static string Serialize<T>(T item)
        {
            // can we use foreach on the property?
            if (typeof(IEnumerable).IsAssignableFrom(item.GetType()))
            {
                return SerializeCollection(item as IEnumerable);
            }
            else
            {
                return SerializeSimpleObject(item);
            }
        }

        private static string SerializeCollection(IEnumerable collection)
        {
            var result = new StringBuilder();
            foreach (var item in collection)
            {
                var subItemValues = Serialize(item)
                    .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                    .Select(line => $"    {line}");
                result.AppendJoin(Environment.NewLine, subItemValues);
                result.AppendLine();
            }
            return result.ToString();
        }

        private static string SerializeSimpleObject<T>(T item)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{item.GetType().Name}:");

            var propertyInfos = item.GetType().GetProperties().Where(pi => !IsIgnored(pi));

            var intProperties = propertyInfos.Where(pi => pi.PropertyType == typeof(int));
            var stringProperties = propertyInfos.Where(pi => pi.PropertyType == typeof(string));
            var includedProperties = propertyInfos.Where(pi => HasIncludeAttribute(pi));

            foreach (var info in intProperties)
            {
                var value = info.GetValue(item);
                string propName = GetPropertyName(info);
                sb.AppendLine($@"    {propName} = {value}");
            }

            foreach (var info in stringProperties)
            {
                var value = info.GetValue(item);
                var propName = GetPropertyName(info);
                sb.AppendLine($@"    {propName} = ""{value}""");
            }

            foreach (var info in includedProperties)
            {
                var propName = GetPropertyName(info);
                sb.AppendLine($@"    {propName} =");
                var value = info.GetValue(item);
                sb.Append(Serialize(value));
            }
            return sb.ToString();
        }

        private static string GetPropertyName(PropertyInfo info)
        {
            var nameAttr = info.GetCustomAttributes(typeof(SsfFieldNameAttribute), false);
            var propName = info.Name;
            if (nameAttr.Length != 0)
            {
                var attr = nameAttr[0] as SsfFieldNameAttribute;
                propName = attr.PropertyName;
            }

            return propName;
        }

        private static bool HasIncludeAttribute(PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType == typeof(string))
            {
                return false;
            }
            if (propertyInfo.PropertyType == typeof(int))
            {
                return false;
            }

            var includeAttr = propertyInfo.GetCustomAttributes(typeof(SsfIncludeAttribute), false);
            return includeAttr.Length != 0;
        }

        private static bool IsIgnored(PropertyInfo propertyInfo)
        {
            var attrs = propertyInfo.GetCustomAttributes(typeof(SsfIgnoreAttribute), false);
            return attrs.Length != 0;
        }

        public static Task SerializeToFile<T>(T item, string filename)
        {
            var content = Serialize(item);
            return File.WriteAllTextAsync(filename, content);
        }

        internal static Author Deserialize(string content)
        {
            var lines = content.Split(Environment.NewLine);
            if (lines[0] != "Author:")
            {
                throw new Exception("Invalid format");
            }
            var propertyLines = lines.Skip(1).Where(l => !string.IsNullOrEmpty(l)).Select(l => l.Trim());

            int id = int.MinValue;
            int nominations = int.MinValue;
            int wins = int.MinValue;
            string name = string.Empty;

            foreach (var line in propertyLines)
            {
                var parts = line.Split(" = ");
                if (parts[0] == "ID")
                {
                    id = int.Parse(parts[1]);
                }
                else if (parts[0] == "Name")
                {
                    name = parts[1].Trim('"');
                }
                else if (parts[0] == "Nominations")
                {
                    nominations = int.Parse(parts[1]);
                }
                else if (parts[0] == "Wins")
                {
                    wins = int.Parse(parts[1]);
                }
                else
                {
                    throw new Exception($"{parts[0]} is not a valid property name");
                }
            }
            return new Author
            {
                ID = id,
                Name = name,
                Wins = wins,
                Nominations = nominations
            };
        }

        internal static async Task<Author> DeserializeFromFile(string filename)
        {
            var contents = await File.ReadAllTextAsync(filename);
            return Deserialize(contents);
        }
    }
}
