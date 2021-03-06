using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingListController : ControllerBase
    {
        ShoppingDatabase Database { get; set; }

        public ShoppingListController(ShoppingDatabase database)
        {
            Database = database;
        }

        [HttpGet(Name = "GetShoppingList")]
        public ShoppingListItem[] Get()
        {
            return Database.ShoppingListItems.ToArray();
        }
    }
}
