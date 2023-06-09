﻿using Microsoft.EntityFrameworkCore;
using WebbApp.Helpers.Repositories;
using WebbApp.Models.Contexts;
using WebbApp.Models.Dtos;
using WebbApp.Models.Entities;
using Webbappen.Models.Entitites;
using Webbappen.Repositories;

namespace Webbappen.Services;

public class ProductService
{

    private readonly ProductRepository _productRepo;
    private readonly ProductTagRepository _productTagRepo;
    private readonly DataContext _context;


    public ProductService(ProductRepository productRepo, DataContext context, ProductTagRepository productTagRepo)
    {
        _productRepo = productRepo;
        _context = context;
        _productTagRepo = productTagRepo;
    }




    public async Task<IEnumerable<ProductModel>> GetAllAsync()
    {
       var products = new List<ProductModel>();
        var items = await _context.Products.ToListAsync();
        foreach (var item in items)
        {
            ProductModel productModel = item;
            products.Add(productModel);
        }
        return products;

    }



    public async Task<IEnumerable<ProductModel>> GetByCategoryAsync()
    {
        var products = new List<ProductModel>();
        var items = await _context.Products.Include(x => x.Category).ToListAsync();

        return products;
    }



    public async Task<bool> CreateAsync(ProductEntity entity)
    {
        var _entity = await _productRepo.GetAsync(x => x.Id == entity.Id);
        if(_entity == null)
        {
            _entity = await _productRepo.AddAsync(entity);
            if (_entity != null)
                return true;
        }
        return false;
    }

    public async Task<ProductModel> GetProductDetailsAsync(int id)
    {
        var detailedProduct = await _context.Products.FindAsync(id);

        if (detailedProduct == null)
        {
            return null;
        }

        return detailedProduct;
    }

    public async Task AddProductTagsAsync(ProductEntity entity, string[] tags)
    {
        var productEntity = await _productRepo.GetAsync(x => x.ArticleNumber == entity.ArticleNumber);
        foreach (var tag in tags)
        {
            await _productTagRepo.AddAsync(new ProductTagEntity
            {
                ProductId = productEntity.Id,
                TagId = int.Parse(tag)
            });
        }
    }





    public async Task<IEnumerable<ProductTagModel>> GetIfPopularAsync()
    {
        var productsTag = new List<ProductTagModel>();
        var items = await _context.ProductTags.Where(x => x.TagId == 1).Select(x => x.Product).ToListAsync();
        foreach (var item in items)
        {
            ProductTagModel model = item;
            productsTag.Add(model);
        }
        return productsTag;
    }

    public async Task<IEnumerable<ProductTagModel>> GetIfNewAsync()
    {
        var productsTag = new List<ProductTagModel>();
        var items = await _context.ProductTags.Where(x => x.TagId == 2).Select(x => x.Product).ToListAsync();
        foreach (var item in items)
        {
            ProductTagModel model = item;
            productsTag.Add(model);
        }
        return productsTag;
    }

    public async Task<IEnumerable<ProductTagModel>> GetIfFeaturedAsync()
    {
        var productsTag = new List<ProductTagModel>();
        var items = await _context.ProductTags.Where(x => x.TagId == 3).Select(x => x.Product).ToListAsync();
        foreach (var item in items)
        {
            ProductTagModel model = item;
            productsTag.Add(model);
        }
        return productsTag;
    }


}
