using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Model;

namespace _1.DAL.IRepositories
{
    public interface IChucVu_Repositories
    {
        bool Add(ChucVu obj);
        bool Update(ChucVu obj);
        bool Delete(ChucVu obj);
        List<ChucVu> GetAll();
        List<ChucVu> GetByName(string name);
    };
}
