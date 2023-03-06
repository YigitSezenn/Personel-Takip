using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DataAccesObject;

namespace BLL
{
    public class DepartmanBLL
    {
        public static void DepartmanEkle(Departman dpt)
        {
            DepartmanDao.departmanekle(dpt);
        }

        public static List<Departman> DepartmanGetir()
        {
            return DepartmanDao.departmanGetir();
        }
    }
}
