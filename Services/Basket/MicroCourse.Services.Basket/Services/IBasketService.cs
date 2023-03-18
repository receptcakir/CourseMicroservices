using MicroCourse.Services.Basket.Dtos;
using MicroCourse.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroCourse.Services.Basket.Services
{
    public interface IBasketService
    {
        Task<Response<BasketDto>> GetBasket(string userId);

        Task<Response<bool>> SaveOrUpdate(BasketDto basketDto);

        Task<Response<bool>> Delete(string userId);
    }
}