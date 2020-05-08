using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ajax.Models
{
    public class UserLogin
    {
        public int Uid { get; set; }
        public string Uname { get; set; }
        public string Upwd { get; set; }
        public string Upwds { get; set; }
    }
}