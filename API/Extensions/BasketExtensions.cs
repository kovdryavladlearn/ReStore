using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Extensions;

public static class BasketExtensions
{
    public static BasketDto MapBasketToDto(this Basket basket)
    {
         return new BasketDto
        {
            Id = basket.Id,
            BuyerId = basket.BuyerId,
            PaymentIntentId = basket.PaymentIntentId,
            ClientSecret = basket.ClientSecret,
            Items = basket.Items.Select(x => new BasketItemDto
            {
                Id = x.Id,
                ProductId = x.ProductId,
                Name = x.Product.Name,
                Price = x.Product.Price,
                PictureUrl = x.Product.PictureUrl,
                Type = x.Product.Type,
                Brand = x.Product.Brand,
                Quantity = x.Quantity
            }).ToList()
        };
    }
}
