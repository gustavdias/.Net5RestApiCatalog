using System;
namespace Catalog.Entities
{
    public record Item
    {
        public Guid Id { get; init; } // ini-only property .net 5, only allow setting a value during initialization
        //*set after you create the object, you can just modify the ID in this case, at any time.
        //*private set for immutable
        public string Name { get; set; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}


//*You can do this
// Item item = new()
// {
//     Id = Guid.NewGuid()
// };
//*But not this
// item.ID = Guid.NewGuid(),