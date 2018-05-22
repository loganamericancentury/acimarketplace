using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACI.Marketplace.Domain.Abstract
{
    public interface IRepository
    {
        T Insert<T>(T obj) where T : class;
        T Update<T>(T obj) where T : class;
    }
}
