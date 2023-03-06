using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataAccesObject;
using BLL;
using DAL.DataTransfer;

namespace BLL
{
    public class Pozisyonbll
    {
        public static void PozisyonEkle(Position pz)
        {
            PozisyonDao.DepartmanEkle(pz);
        }

        public static List<PozisyonDto> PozisyonGetir()
        {
            return PozisyonDao.PozisyonGetir();
        }
    }
}
