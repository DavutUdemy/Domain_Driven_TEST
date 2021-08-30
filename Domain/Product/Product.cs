using Domain.Base;

namespace Domain.Product
{
    public  partial  class Product :BaseEntity<int>
    {
        public string UserName { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string Address { get;  set; }

    
    }
}