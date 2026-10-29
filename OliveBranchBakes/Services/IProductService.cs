using System;
using System.Collections.Generic;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
   

    public interface IProductService
    {
        IList<Product> GetAvailableProducts(DateTime asOfDate);
        IList<Product> GetAvailableProducts(DateTime asOfDate, string category);
        IList<string> GetCategories(DateTime asOfDate);
        Product GetById(int productId);
    }
}
