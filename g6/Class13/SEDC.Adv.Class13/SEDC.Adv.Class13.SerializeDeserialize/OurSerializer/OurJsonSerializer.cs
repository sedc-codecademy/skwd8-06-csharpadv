using SEDC.Adv.Class13.SerializeDeserialize.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class13.SerializeDeserialize.OurSerializer
{
    public class OurJsonSerializer
    {
        private const string _studentJsonTemplate = 
            "{\"FirstName\": {firstName},\"LastName\": {lastName},\"Age\": {age},\"IsPartTime\": {isPartTime} }";

        // Serializes only a student object
        public string SerializeStudent(Student student)
        {
            StringBuilder sb = new StringBuilder(_studentJsonTemplate);

            return sb.Replace("{firstName}", student.FirstName)
                .Replace("{lastName}", student.LastName)
                .Replace("{age}", student.Age.ToString())
                .Replace("{isPartTime}", student.IsPartTime.ToString())
                .ToString();

            //one way
            //sb.Append("{")
            //    .Append($"\"FirstName\" : \"{student.FirstName}\",")
            //    .Append($"\"LastName\" : \"{student.LastName}\",")
            //    .Append($"\"Age\" : {student.Age},")
            //    .Append($"\"IsPartTime\" : {student.IsPartTime}")
            //    .Append("}");
            //return sb.ToString();

            //string json = "{";
            //json += $"\"FirstName\" : \"{student.FirstName}\",";
            //json += $"\"LastName\" : \"{student.LastName}\",";
            //json += $"\"Age\" : {student.Age},";
            //json += $"\"IsPartTime\" : {student.IsPartTime}";
            //json += "}";
            //return json;
        }

        public Student DeserializeStudent(string json)
        {
            #region Proces
            // json = {"FirstName": "Bob","LastName": "Bobsky","Age": "40","IsPartTime": "false"}
            /*
            0 - remove brackets
            1 - Split on every ','
            [
                "FirstName": "Bob"
                "LastName": "Bobsky"
                "Age": "40"
                "IsPartTime": "false"
            ]
            2 - Split on every  ':'
            KEY: "FirstName" VALUE: "Bob"
            Map every property from student to value
             */
            #endregion

            string content = json
                .Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\r", "")
                .Replace("\t", "")
                .Replace("\n", "")
                .Replace("\"", "");
            var properties = content.Split(',');

            Dictionary<string, string> propertiesDictionary = new Dictionary<string, string>();
            foreach (var property in properties)
            {
                // FirstName:Bob
                var pair = property.Split(':');
                propertiesDictionary.Add(pair[0].Trim(), pair[1].Trim());
            }

            var student = new Student();
            // student.FirstName = propertiesDictionary[nameof(student.FirstName)]; // just an example :)
            student.FirstName = propertiesDictionary["FirstName"];
            student.LastName = propertiesDictionary["LastName"];
            student.Age = int.Parse(propertiesDictionary["Age"]);
            student.IsPartTime = bool.Parse(propertiesDictionary["IsPartTime"]);

            return student;
        }
    }
}

//{"FirstName": "Bob","LastName": "Bobsky","Age": "40","IsPartTime": "false"}
