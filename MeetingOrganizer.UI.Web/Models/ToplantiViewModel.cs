using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingOrganizer.Models
{
    public class ToplantiViewModel
    {
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

    }
}
