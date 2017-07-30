using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace User
{
    public class Task
    {
        public int id { get; set; }
        [Required(ErrorMessage="Name is Required")]
        public string name { get; set; }
        [Required(ErrorMessage="Description is needed")]
        public string description { get; set; }
        [Required(ErrorMessage="You can not ignore this field")]
        public DateTime dateCreated { get; set; }
        [Required(ErrorMessage="Date is required")]
        public DateTime dateUpdated { get; set; }
    }
}