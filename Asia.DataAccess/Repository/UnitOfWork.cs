using AsiaFridges.DataAccess.Data;
using AsiaFridges.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiaFridges.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private  ApplicationDbContext _db;
        public IFridgeTypeRepository FridgeType { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            FridgeType = new FridgeTypeRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
