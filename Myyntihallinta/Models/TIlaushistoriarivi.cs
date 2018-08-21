using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myyntihallinta.Models
{

    public class TilaushistoriaRivi
    {
        /// <summary>
        /// Tilauspäivä
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? Pvm { get; set; }
        /// <summary>
        /// Montako kappaletta tuotetta on tilattu
        /// </summary>
        public int? Lkm { get; set; }
        /// <summary>
        /// Laskutettava summa, kpl * aHinta - alennus
        /// </summary>
        public decimal? Laskutus { get; set; }
        /// <summary>
        /// tilatun tuotteen nimi
        /// </summary>
        public string Tuote { get; set; }

    }
}
