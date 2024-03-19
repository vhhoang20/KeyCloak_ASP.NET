using System.ComponentModel.DataAnnotations;

namespace KeyCloak.Data.Model
{
    public class Sprint
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
