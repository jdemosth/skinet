﻿using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();

        Task<ProductBrand> GetProductBrandAsync(int id);

        Task<IReadOnlyList<ProductType>> GetProductTypesAsync(); 

        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
    }
}
