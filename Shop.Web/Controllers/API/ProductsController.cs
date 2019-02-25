﻿
using Microsoft.AspNetCore.Mvc;
using Shop.Web.Data;

[Route("api/[Controller]")]
public class ProductsController : Controller
{
    private readonly IProductRepository productRepository;

    public ProductsController(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        return this.Ok(this.productRepository.GetAllWithUsers());
    }
}
