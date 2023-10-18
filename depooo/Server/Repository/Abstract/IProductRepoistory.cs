using depooo.Shared;
using depooo.Shared.DTO;
using depooo.Shared.Model;

namespace depooo.Server.Repository.Abstract
{
    public interface IProductRepoistory
    {
        Task<DataResponse<Product>> Add(Product product);
        Task<DataResponse<Product>> Update(Product product);
        Task<DataResponse<IEnumerable<Product>>> GetAll();
        Task<DataResponse<string>> Delete(int id);
        Task<DataResponse<Product>> GetProductById(int id); 
        Task<bool> Save();
    }
}
