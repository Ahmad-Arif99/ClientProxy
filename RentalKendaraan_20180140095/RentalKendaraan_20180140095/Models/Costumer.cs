using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140095.Models
{
    public partial class Costumer
    {
        public Costumer()
        {
            Peminjaman = new HashSet<Peminjaman>();          
        }
        

        public int IdCostumer { get; set; }
        [Required(ErrorMessage = "nama Customer tidak boleh kosong")]
        public string NamaCostumer { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage ="Hanya Boleh Diisi Dengan Angka")]
        public string Nik { get; set; }
        public string Alamat { get; set; }
        [MinLength(10, ErrorMessage ="No HP Minimal 10 Angka")]
        [MaxLength(13, ErrorMessage ="No HP Maximal 13 Angka")]
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
