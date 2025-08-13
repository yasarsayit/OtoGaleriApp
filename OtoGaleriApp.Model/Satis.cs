using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleriApp.Model
{
    public class Satis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }

        public int AracId { get; set; }
        public int AliciId { get; set; }
        public int SaticiId { get; set; }

        public decimal SatisFiyati { get; set; }
        public DateTime Tarih { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual Kisi Alici { get; set; }

        public virtual Kullanici Satici { get; set; }
    }



}
