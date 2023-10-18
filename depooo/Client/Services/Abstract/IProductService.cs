using depooo.Shared;
using depooo.Shared.DTO;
using depooo.Shared.Model;

namespace depooo.Client.Services.Abstract
{
    public interface IProductService
    {
        Task<DataResponse<Product>> Add(ProductCreateDTO productDTO);
        Task<DataResponse<Product>> Update(Product product);
        Task<DataResponse<IEnumerable<Product>>> GetAll();
        Task<DataResponse<string>> Delete(int id);
        Task<DataResponse<Product>> GetById(int id);
    }
}
