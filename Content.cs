using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Content
	{
		[Key]
		public int ContentID { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; } // içeriğin değeri/metni
		public DateTime ContentDate { get; set; } // ne zaman yazıldı
												  // ContentYazar - kim tarafından
												  // ContentBaşlık - hangi başlığa

		public int HeadingID { get; set; }
		public virtual Heading Heading { get; set; }

		public int? WriterID { get; set; }
		public virtual Writer Writer { get; set; }


	}
}

