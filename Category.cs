using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Category
	{
		[Key]
		public int CategoryID { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }
		public bool CategoryStatus { get; set; } // aktif/pasif durumunu belirleme


		public ICollection<Heading> Headings  { get; set; } // Heading ile ilişki kurma
	}
}

