using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class General_item_layout
    {
        public string Id { get; set; }
        public int DB_id {  get; set; }
        [DataType(DataType.Date)]
        public DateTime Dateofproduction { get; set; }

<<<<<<< HEAD
=======
        [DataType(DataType.Currency)]
>>>>>>> c9a41b98c59c8e3ec1e87670a939bc1cf604f78f
        public int Price { get; set; }

        public int rating { get; set; }
    }
}
