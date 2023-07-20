﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Heading // Başlık
	{
		[Key]
		public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
		public DateTime HeadingDate { get; set; }

		public int CategoryID { get; set; }
		public virtual Category Category { get; set; }


		public ICollection<Content> Contents { get; set; }


		public int WriterID { get; set; }
		public virtual Writer Writer { get; set; }


	}
}

