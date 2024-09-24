using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SNKRS.Models
{
	public class Portfolio
	{
		public Portfolio()
		{
			ProductGalleries = new HashSet<ProductGallery>();
			Categories = new HashSet<Category>();
		}

		public int Id { get; set; }

		public string Name { get; set; }

		public string Image { get; set; }

		public string Description { get; set; }

		public bool isVisible { get; set; }

		public string UserId { get; set; }  // Thêm thuộc tính UserId

		public virtual ICollection<ProductGallery> ProductGalleries { get; set; }

		public virtual ICollection<Category> Categories { get; set; }
	}
}
