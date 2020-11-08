using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Models
{

    public class Pagination
    {
        public int total { get; set; }
        public int pages { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
    }

    public class Meta
    {
        public Pagination pagination { get; set; }
    }

    public class Users1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class JsonResponses
    {
        public int code { get; set; }
        public Meta meta { get; set; }
        public IEnumerable<UsersResponse> data { get; set; }
    }

    public class Datum
    {
        public string field { get; set; }
        public string message { get; set; }
    }

    public class JsonPostResponse
    {
        public int code { get; set; }
        public object meta { get; set; }
        public IEnumerable<Datum> data { get; set; }
    }
}
