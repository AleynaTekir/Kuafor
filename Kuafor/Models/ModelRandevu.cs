﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kuafor.Models
{
    
        // GET: modelsaat
        public class ModelRandevu
        {
        public List<string> işlemlerlist { get; set; }
        public string tarih { get; set; }
        public List<SelectListItem> CheckBoxValues { get; set; }
        public List<int> SelectedValues { get; set; }
        public int SelectedId{ get; set; }
        public List<SelectListItem> Items { get; set; }
    }
    
}