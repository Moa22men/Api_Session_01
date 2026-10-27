using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Presistence
{

    public class DataSeeding(StoreDbContext _dbContext) : IDataSeeding
    {
        public void DataSeed()
        {
            if (_dbContext.Database.GetPendingMigrations().Any())
            {
                _dbContext.Database.Migrate();
            }

            if (!_dbContext.ProductBrands.Any())
            {

                var productBrandsData = File.ReadAllText("");
                var productBrands = JsonSerializer.Deserialize<List<productBrands>>(ProductBrandData);
                if (productBrands is not null && productBrands.Any())
                {
                    _dbContext.ProductBrands.AddRange(productBrands);
                }
                _dbContext.SaveChanges();

            }

            if (!_dbContext.ProductType.Any())
            {

                var productTypeData = File.ReadAllText("");
                var ProductType = JsonSerializer.Deserialize<List<ProductType>>(ProductTypeData);
                if (ProductType is not null && ProductType.Any())
                {
                    _dbContext.ProductBrands.AddRange(ProductType);
                }
                _dbContext.SaveChanges();

            }
        }
    }
}