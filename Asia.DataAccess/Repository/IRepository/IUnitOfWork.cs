using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiaFridges.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork

    {
        IFridgeTypeRepository FridgeType { get; } //
        void Save();
    }
}
