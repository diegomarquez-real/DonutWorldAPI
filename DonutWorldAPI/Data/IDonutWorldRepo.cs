using DonutWorldAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonutWorldAPI.Data
{
    public interface IDonutWorldRepo
    {
        bool SaveChanges();

        IEnumerable<Donut> GetAllDonuts();

        Donut GetDonutById(int id);

        void CreateDonut(Donut donut);

        void DeleteDonut(Donut donut);

        void UpdateDonut(Donut donut);
    }
}
