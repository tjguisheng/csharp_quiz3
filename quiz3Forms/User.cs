using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz3Forms
{
    class User
    { 
        private string fname { get; set; }
        private string lname { get; set; }
        private string tel { get; set; }
        public User(string fname, string lname, string tel)
        {
            this.fname = fname;
            this.lname = lname;
            this.tel = tel;
        }
        public override string ToString()
        {
            return $"'first name': {this.fname}, 'last name':{this.lname}, 'telephone':{this.tel}'";
        }
    }
}
