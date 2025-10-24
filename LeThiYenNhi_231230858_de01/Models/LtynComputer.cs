using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeThiYenNhi_231230858_de01.Models
{
    public class LtynComputer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int ltynComId { get; set; }
        public string ltynComName { get; set; }
        public decimal ltynComPrice { get; set; }
        public string ltynComImage { get; set; }
        public bool ltynComStatus   { get; set; }


    }
}
