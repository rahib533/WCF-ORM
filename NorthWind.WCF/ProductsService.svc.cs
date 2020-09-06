using NorthWind.DTO;
using NorthWind.Entity.Model;
using NorthWind.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NorthWind.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductsService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductsService.svc or ProductsService.svc.cs at the Solution Explorer and start debugging.
    public class ProductsService : ServiceBase<ProductsRepository,Products,ProductsDTO>
    {
        
    }
}
