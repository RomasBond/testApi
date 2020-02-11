using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testUsersApi.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Email  { get; set; }
        public string Phone { get; set; }
        string _date;
        public string Date { get { return DateTime.Parse(_date).ToString("yyyy-MM-dd"); } set { _date = value; } }
        public string Large { get; set; }


    }
}