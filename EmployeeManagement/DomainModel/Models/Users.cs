using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{
    public enum gender
    {
        [EnumMember(Value = "Male")]
        Male,
        [EnumMember(Value = "Female")]
        Female
    }
    public enum status
    {
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Inactive")]
        Inactive
    }
    public class Users
        {
        public Users(int id, string name, string email, gender gender, status status, DateTime created_at, DateTime updated_at)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.gender = gender;
            this.status = status;
            this.created_at = created_at;
            this.updated_at = updated_at;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public gender gender { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public status status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        
    }

    public class UsersResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

}
