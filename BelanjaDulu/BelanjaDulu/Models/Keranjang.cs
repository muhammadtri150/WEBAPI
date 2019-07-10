using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BelanjaDulu.Models
{
    public class Keranjang
    {
        [Required(ErrorMessage = "Id barang jangan di kosongin napa elah")]
        public int BarangId { get; set; }
        [Required(ErrorMessage = "Beli apaan lu kagak ada namanya")]
        [StringLength(8, ErrorMessage = "Namanya gausah panjang - panjang ribet nanti", MinimumLength = 1)]
        public string NamaBarang { get; set; }
        [Required(ErrorMessage = "Isi lah gamau bayar apa lu")]
        [Range(0, 10000, ErrorMessage = "Gausah mahal - mahal kaya punya duit aja luu")]
        public int HargaBarang { get; set; }
        [Required(ErrorMessage = "beli berapa biji")]
        [Range(1, 10, ErrorMessage = "jangan banyak - banyak")]
        public int JumlahBarang { get; set; }
        public int SubTotal { get; set; }
        public int TotalHarga { get; set; }
    }
}