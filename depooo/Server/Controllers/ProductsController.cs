using AutoMapper;
using depooo.Server.Repository.Abstract;
using depooo.Shared.DTO;
using depooo.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace depooo.Server.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepoistory _productRepository;
        private readonly IMapper _mapper;

        public ProductsController(IProductRepoistory productRepoistory, IMapper mapper)
        {
            _productRepository = productRepoistory;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> Create(ProductCreateDTO productDTO) 
        {
             var product = _mapper.Map<Product>(productDTO);
             var result = await _productRepository.Add(product);
             return Ok(result);
        }
        [HttpPut]
        public async Task<ActionResult> Create(Product product)
        {
            var result = await _productRepository.Update(product);
            return Ok(result);
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _productRepository.GetAll();

            return Ok(result);
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var result =await _productRepository.Delete(id);
            return Ok(result);
        }
        [HttpGet("getbyid")]
        public async Task<ActionResult> GetById(int id)
        {
            var result = await _productRepository.GetProductById(id);

            return Ok(result);
        }
    }
}
