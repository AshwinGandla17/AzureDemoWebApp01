using AzureDemoWebApp01.Models;

namespace AzureDemoWebApp01.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}