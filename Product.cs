using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCTDL
{
	public class Product
	{
		private int id;
		private string productname;
		private int price;
		private int rate;
		private string description;


		public int getId()
		{
			return id;
		}
		public int setId()
		{
			return id;
		}
		public string getProductname()
		{
			return productname;
		}
		public string setProductname()
		{
			return productname;
		}

		public int getPrice()
		{
			return price;
		}
		public int setPrice()
		{
			return price;
		}
		public int getRate()
		{
			return rate;
		}
		public int setRate()
		{
			return rate;
		}
		public string getDescription()
		{
			return description;
		}
		public string setDescription()
		{
			return description;
		}
		public Product(int id, string productname, int price, int rate, string description)
		{
			this.id = id;
			this.productname = productname;
			this.price = price;
			this.rate = rate;
			this.description = description;
		}

		public virtual void productInfor()
		{
			Console.Write("\nId: " + id);
			Console.Write("\nName: " + this.productname);
			Console.Write("\nPrice: " + this.price);
			Console.Write("\nRate: " + this.rate);
			Console.Write("\nDescription: " + this.description);
			Console.Write("\n------------------------");
		}

	}
}