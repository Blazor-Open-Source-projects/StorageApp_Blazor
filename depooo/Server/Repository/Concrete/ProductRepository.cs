using depooo.Server.Data;
using depooo.Server.Repository.Abstract;
using depooo.Shared;
using depooo.Shared.DTO;
using depooo.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace depooo.Server.Repository.Concrete
{
    public class ProductRepository : IProductRepoistory
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<DataResponse<Product>> Add(Product product)
        {
            product.TotalPrice = product.Price * product.Quantity;
            await _context.Products.AddAsync(product);
            await Save();
            
            return new DataResponse<Product>
            {
                Data = product,
                Success = true,
                Message = "Product Added"
            };
        }

        public async Task<DataResponse<string>> Delete(int id)
        {
            var product =await _context.Products.FirstOrDefaultAsync(opt => opt.Id == id);
            if(product == null )
            {
                throw new ArgumentNullException(nameof(product));
            }
            _context.Products.Remove(product);
            await Save();
            return new DataResponse<string>
            {
                Data = "product is deleted",
                Success = true,
                Message = "Product is deleted"
            };
        }

        public async Task<DataResponse<IEnumerable<Product>>> GetAll()
        {
            var result =await _context.Products.ToListAsync();
            if(result == null)
            {
                throw new ArgumentNullException(nameof(result));
            }
            return new DataResponse<IEnumerable<Product>>
            {
                Data = result,
                Message = "Product List Getted",
                Success = true,
            };
        }

        public async Task<DataResponse<Product>> GetProductById(int id)
        {
            var product =await _context.Products.FirstOrDefaultAsync(opt => opt.Id == id);
            return new DataResponse<Product>
            {
                Data = product,
                Success= true,
                Message = "Product getted"
            };
        }

        public async Task<bool> Save()
        {
            var saved =await _context.SaveChangesAsync();
            return saved > 0 ? true : false;
        }

        public async Task<DataResponse<Product>> Update(Product product)
        {
            product.TotalPrice = product.Price * product.Quantity;
            _context.Products.Update(product);
            await Save();
            return new DataResponse<Product>
            {
                Data = product,
                Success = true,
                Message = "Product is Updated"
            };
        }
    }
}
