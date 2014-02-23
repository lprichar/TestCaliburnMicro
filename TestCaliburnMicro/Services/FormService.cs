using System.Collections.Generic;
using TestCaliburnMicro.LibPcl.Model;

namespace TestCaliburnMicro.Services
{
    public class FormService
    {
        public IEnumerable<Form> GetProducts()
        {
            return new List<Form>
            {
                new Form {ProductId = 1, ProductName = "Chai"},
                new Form {ProductId = 2, ProductName = "Beer"},
                new Form {ProductId = 3, ProductName = "Wings"},
                new Form {ProductId = 4, ProductName = "Latte"},
                new Form {ProductId = 5, ProductName = "Light Beer"},
            };
        }
    }
}
