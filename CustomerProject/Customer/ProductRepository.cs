﻿using System;

namespace CustomerProject.Customer
{
  public class ProductRepository
  { 
    public Product Retrieve(int productId)
    {
      Product product = new Product(productId);
      {
        product.ProductName = "Sunflowers";
        product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
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
