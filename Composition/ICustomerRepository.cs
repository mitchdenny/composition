using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composition
{
    public interface ICustomerRepository : IQueryableRepository<Customer>
    {
    }
}
