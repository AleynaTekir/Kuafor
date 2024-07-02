using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kuafor.Models
{
    public class islemmodel
    {
        internal List<islemmodel>joinAndViewModel;
        public müşteri müşterivm { get; set; }
        public işlemler işlemlervm { get; set; }
        public işlem_ücret işlemücretvm { get; set; }
        public Kuaför kuaförvm { get; set; }
        public List<T> işlemler { get; set; }
        public List<Kuaför> kuaför { get; set; }
      
        public değerlendirme değerlendirmevm { get; set; }
    }
}