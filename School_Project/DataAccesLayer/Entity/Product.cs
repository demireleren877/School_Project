using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School_Project.Entity
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Barkod { get; set; }
        public string ModelKod { get; set; }
        public string Marka { get; set; }
        [DefaultValue("3015")]
        public string Kategori { get; set; }
        public string ParaBirimi { get; set; }
        public string ÜrünAd { get; set; }
        public string Acıklama { get; set; }
        public string PiyasaFiyat { get; set; }
        public string TrendyolFiyat { get; set; }
        public string StokAdedi { get; set; }
        public string StokKodu { get; set; }
        public string KDVOranı { get; set; }
        public string Desi { get; set; }
        public string GörselLink { get; set; }
        public string SevkiyatSüresi { get; set; }
        public string WebColor { get; set; }
        public string AraçMarka { get; set; }
        public string AraçModel { get; set; }
    }
}
