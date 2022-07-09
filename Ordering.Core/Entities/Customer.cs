using Ordering.Core.Entities.Base;

namespace Ordering.Core.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string ContactNumber { get; set; } = default!;
        public string Address { get; set; } = default!;
    }
}
