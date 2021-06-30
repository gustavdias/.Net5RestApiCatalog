using System.Collections.Generic;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace Catalog.Controllers
{
    // GET /items
    [ApiController] //mark this class as a API controller: it brings a bunch of additional default behaviors for you controller class
    [Route("[items")]  // what is inside is going to be the route
    public class ItemsController : ControllerBase // you always want to inherit from ControllerBase
    {
        private readonly InMemItemsRepository repository;
        //constructor
        public ItemsController()
        {
            repository = new InMemItemsRepository();
        }

        //GET /items
        //route to retrive all the items
        [HttpGet] // If someone goes to perform a GET against /items this is the method that will react to that
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }
    }
}
