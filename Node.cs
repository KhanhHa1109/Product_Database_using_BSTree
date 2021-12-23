using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCTDL
{
	public class Node
	{
		public Product product;
		public Node left;
		public Node right;

		public Node(Product product)
		{
			this.product = product;
			this.left = null;
			this.right = null;
		}

		public void Data()
		{
			product.productInfor();
		}

		public bool lessThanOrEqual(Product product)
		{
			return this.product.getId() <= product.getId();
		}

		public bool greaterThan(Product product)
		{
			return this.product.getId() > product.getId();
		}

		public bool lessThan(int productId)
		{
			return this.product.getId() < productId;
		}

		public bool hasproduct(int productId)
		{
			return this.product.getId() == productId;
		}
	}
}