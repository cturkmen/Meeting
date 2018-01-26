using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingOrganizer.Models
{
    [Table("Toplantilar")]
    public class Toplanti
    {
        [Key]
        public int ToplantiId { get; set; }
        [Required]
        public string ToplantiKonusu { get; set; }
        [Required]
        public DateTime Tarih { get; set; } = DateTime.Now;
        [Required]
        public string BaslangicSaati { get; set; } = DateTime.Now.ToString("hh:mm");
        [Required]
        public string BitisSaati { get; set; } = DateTime.Now.ToString("hh:mm");
        [Required]
        public string Katilimcilar { get; set; }
        [Display(Name = "Olusturulma Tarihi")]
        public DateTime OlusturulmaTarihi { get; set; }

    }
}
