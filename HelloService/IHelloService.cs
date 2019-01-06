using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloService" in both code and config file together.

    [ServiceContract] // By Decorating this interface with ServiceContract we are turning this into WCF Service
    public interface IHelloService
    {
        [OperationContract] // By Decorating it we are making this Method available as part of Service to the Client
        string GetMessage(string name);
    }
}
