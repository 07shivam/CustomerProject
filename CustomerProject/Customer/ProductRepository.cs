using System;

namespace CustomerProject.Customer
{
  public class ProductRepository
  { 
    public Product Retrieve(int productId)
    {
      Product product = new Product(productId);
      {
        product.ProductName = "Sunflowers";
        product.ProductDescription = "Set of 4 Sunflowers";
        product.CurrentPrice = 15.96M;
      }
      return product;
    }
    public bool Save(Product product)
    {
      return true;
    }

  }
}
