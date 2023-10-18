using depooo.Client.Services.Abstract;
using depooo.Shared;
using depooo.Shared.DTO;
using depooo.Shared.Model;
using System.Net.Http;
using System.Net.Http.Json; // Add this using directive

namespace depooo.Client.Services.Concrete
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task<DataResponse<Product>> Add(ProductCreateDTO productDTO)
        {
            var result = await _http.PostAsJsonAsync("api/products", productDTO);
            return await result.Content.ReadFromJsonAsync<DataResponse<Product>>();
        }

        public async Task<DataResponse<string>> Delete(int id)
        {
            var result = await _http.DeleteAsync($"api/products?id={id}");
            return await result.Content.ReadFromJsonAsync<DataResponse<string>>();
        }

        public async Task<DataResponse<IEnumerable<Product>>> GetAll()
        {
            return await _http.GetFromJsonAsync<DataResponse<IEnumerable<Product>>>("api/products");
        }

        public async Task<DataResponse<Product>> GetById(int id)
        {
            return await _http.GetFromJsonAsync<DataResponse<Product>>($"api/products/getbyid?id={id}");
        }

        public async Task<DataResponse<Product>> Update(Product product)
        {
            var result = await _http.PutAsJsonAsync("api/products", product);
            return await result.Content.ReadFromJsonAsync<DataResponse<Product>>();
        }
    }
}