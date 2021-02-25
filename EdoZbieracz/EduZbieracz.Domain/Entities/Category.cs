using System.Collections.Generic;

namespace EduZbieracz.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public string DisplayName { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
