using kmz_api_coding_test.Core.Entities;
using kmz_api_coding_test.Core.IRepositories;
using kmz_api_coding_test.Core.RequestParameters;
using kmz_api_coding_test.Core.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace kmz_api_coding_test.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly ISalesUnitRepository _salesUnitRepository;
        private readonly ICategoryRepository _categoryRepository;


        public ProductsController(IProductRepository productRepository , ISalesUnitRepository salesUnitRepository , ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _salesUnitRepository = salesUnitRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public ActionResult GetProducts()
        {
            var GetProducts =  _productRepository.GetWhere(x=>x.SalesUnit.ID == 1).Select(x=> new ProductWithStockVM
            {
                Name=x.Name,
                Brand=x.Brand,
                Price=x.Price,
                RemainStock=x.RemainStock
            }).ToList();
            return Ok (GetProducts);
        }
        [HttpGet ("productDetails")]
        public ActionResult GetProduct([FromQuery] ProductDetailRP product)
        {
            if ( product.ProductAttributeId.HasValue )
            {
                var productDetails = _productRepository.GetAll()
    .Where(p => p.ProductId == product.ProductId || p.ProductAttributes.ProductAttributeId == product.ProductAttributeId)
    .Select(p => new ProductDetailVM
    {
        Name = p.Name,
        Desc = p.Description,
        Brand = p.Brand,
        Category = p.Category.Name ,
        UnitName = p.SalesUnit.UnitName,
        Price = p.Price,
        Stock = p.RemainStock
    })
    .ToList();

                return Ok (productDetails);
            }
            else
            {
                var productDetails = _productRepository.GetAll()
    .Where(p => p.ProductId == product.ProductId  )
    .Select(p => new ProductDetailVM
    {
        Name = p.Name,
        Desc = p.Description,
        Brand = p.Brand,
        Category = p.Category.Name ,
        UnitName = p.SalesUnit.UnitName,
        Price = p.Price,
        Stock = p.RemainStock
    })
    .ToList();

                return Ok (productDetails);

            }




        }
    }
}
