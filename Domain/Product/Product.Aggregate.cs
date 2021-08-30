using Domain.Base;

namespace Domain.Product
{
    public partial class Product:IAggregateRoot
    {
        public Product(string userName, string firstName, string lastName, string address)
        {
            UserName = userName;
            this.Update(
                firstName
                , lastName
                , address
            );
        }

        public void Update(string firstName
                , string lastName
                , string address)
            {
                FirstName = firstName;
                LastName = lastName;
                Address = address;
            }
        


        
    }
}