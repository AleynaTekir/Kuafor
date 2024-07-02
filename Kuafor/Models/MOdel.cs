using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kuafor.Models
{
    public class MOdel : Controller
    {

        internal List<MOdel> sorgu;
        // GET: MOdel
        public int toplam { get; set; }
        public int sayı { get; set; }
    }
}