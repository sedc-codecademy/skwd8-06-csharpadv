using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace SEDC.ADVCS11.SerializeDeserialize.Entities
{
    public class Student
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty]
        public int Age { get; set; }

        [JsonProperty]
        public string[] Pets {get; set;}

        [OnSerializing]
        internal void OnSerializeMethod(StreamingContext context)
        {
            FirstName = FirstName.ToLower();
            LastName = LastName.ToLower();
        }
    }

    /*
     * {
     *      "FirstName" : "John",
     *      "LastName"  : "Doe",
     *      "Age"  : "35",
     *      "Pets" : [ "Dog1", "Dog2", "Dog3"]
     * }
     */

    /*
     * ID, MenuName, URL, Parent, ISVisible
     * 1, 3, /, nullable, bool
     * 1, file, /file, NULL, TRUE
     * 2, open, /file/open, 1, TRUE
     */
}
