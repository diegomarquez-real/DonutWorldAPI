using DonutWorldAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonutWorldAPI.Data
{
    public class SqlDonutWorldRepo : IDonutWorldRepo
    {
        private readonly DonutWorldContext _context;

        public SqlDonutWorldRepo(DonutWorldContext context)
        {
            _context = context;
        }

        public void CreateDonut(Donut donut)
        {
            if(donut == null)
            {
                throw new ArgumentNullException(nameof(donut));
            }
            _context.Donuts.Add(donut);
        }

        public void DeleteDonut(Donut donut)
        {
            _context.Remove(donut);
        }

        public IEnumerable<Donut> GetAllDonuts()
        {
            return _context.Donuts.ToList();
        }

        public Donut GetDonutById(int id)
        {
            return _context.Donuts.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateDonut(Donut donut)
        {
            //Nothing
        }
    }
}
