using FactoryMethod.MessageRequestProducts;
using FactoryMethod.MessageRequestSupplies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.MessageRequestFactory
{
    public abstract class MessageRequestFactory
    {
        public abstract MessageRequestProduct ConstructMessageRequest(MessageRequestSupply supply);
    }
}
