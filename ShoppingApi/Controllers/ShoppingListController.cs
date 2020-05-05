using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoppingApi.Data;
using ShoppingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApi.Controllers
{
    public class ShoppingListController : ControllerBase
    {
        private readonly ShoppingDataContext DataContext;
        private readonly IMapper Mapper;
        private readonly MapperConfiguration MapperConfiguration;

        public ShoppingListController(ShoppingDataContext dataContext, IMapper mapper, MapperConfiguration mapperConfiguration)
        {
            DataContext = dataContext;
            Mapper = mapper;
            MapperConfiguration = mapperConfiguration;
        }

        [HttpGet("shoppinglist")]
        public async Task<ActionResult> GetShoppingList()
        {
            var response = new GetShoppingListResponse();
            response.Data = await DataContext.ShoppingItems
                .ProjectTo<ShoppingListItemResponse>(MapperConfiguration).ToListAsync();
                //.Select(item => Mapper.Map<ShoppingListItemResponse>(item)).ToListAsync();

             //.Select(item => new ShoppingListItemResponse
             // {
             //     Id = item.Id,
             //     Description = item.Description,
             //     Purchased = item.Purchased

             // }).ToListAsync();

            return Ok(response);
        }
    }
}
