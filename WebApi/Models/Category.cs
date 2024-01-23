using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Category
    {
        public int id { get; set; }
        public string category_name { get; set; }
        public string description { get; set;}
        [ForeignKey("shop_id")]
        public int shop_id { get; set; }
        public virtual Shop shop { get; set; }
        [ForeignKey("brand_Id")]
        public int brand_Id { get; set; }
        public virtual Brand brand { get; set; }
    }
}
