using System;
using System.ComponentModel.DataAnnotations;


namespace PMW.Entities
{
    public class Machinery
    {
        [Key]
        public int MachinID { get; set; }
        [Required]
        [MaxLength(250)]
        public string MachinName { get; set; }
        [Required]
        [MaxLength(10)]
        public string MachinCode { get; set; }
        public DateTime? RegisterInCompany { get; set; }
        public DateTime? InstallationDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string Location { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public bool StatusPurchase { get; set; }


    }
}
