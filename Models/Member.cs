using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace MvcCrudSample.Models
{
    //member model
    public class Member
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birth { get; set; }
        public bool married { get; set; }
        public decimal age { get; set; }
        public int? cookie { get; set; }
        public string address { get; set; }
        public string memo { get; set; }
    }

}
