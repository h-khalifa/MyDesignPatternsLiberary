using FactoryMethod.MessageRequestProducts;
using FactoryMethod.MessageRequestSupplies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.MessageRequestFactory
{
    public class WarningMessageRequestFactory : MessageRequestFactory
    {
        public override MessageRequestProduct ConstructMessageRequest(MessageRequestSupply supply)
        {
            if(supply is not WarningMessageRequestSupply)
                throw new ArgumentException();

            var input = supply as WarningMessageRequestSupply;
            var res = new MessageRequestProducts.WarningMessageRequestProduct()
            {
                PhoneNumber = input.PhoneNumber,
                MSGTypeCode = "WARN",
                Address = $"{input.Street} {input.LCode}, {input.City} - {input.District}",//logic to define address based on user input fields
            };
            return res;
        }
    }
}
