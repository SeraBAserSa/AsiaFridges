using AsiaFridges.DataAccess.Data;
using AsiaFridges.DataAccess.Repository.IRepository;
using AsiaFridges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AsiaFridges.DataAccess.Repository
{
    public class FridgeTypeRepository : Repository<FridgeType>, IFridgeTypeRepository 
    {
        private ApplicationDbContext _db;

        public FridgeTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

       

        public void Update(FridgeType obj)
        {
            _db.FridgeTypes.Update(obj);
        }
    }
}
