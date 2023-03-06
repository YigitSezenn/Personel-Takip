using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataTransfer;

namespace DAL.DataAccesObject
{
    public class PozisyonDao : PersonelDataContent
    {
        public static void DepartmanEkle(Position pz)
        {
            try
            {
                db.Position.InsertOnSubmit(pz);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<PozisyonDto> PozisyonGetir()
        {
            try
            {
                var list = (from p in db.Position
                            join d in db.Departman on p.DepartmanID equals d.ID
                            select new
                            {
                                PozisyonID = p.ID,
                                pozisyonAD = p.PositionName,
                                DepartmanID = p.DepartmanID,
                                departmanADd = d.DepartmanName
                            }
                            ).OrderBy(x => x.PozisyonID).ToList();
                List<PozisyonDto> liste = new List<PozisyonDto>();
                foreach (var item in list)
                {
                    PozisyonDto pzt = new PozisyonDto();
                    pzt.ID = item.PozisyonID;
                    pzt.PositionName = item.pozisyonAD;
                    pzt.DepartmanID = item.DepartmanID;
                    pzt.DepartmanAD = item.departmanADd;
                    liste.Add(pzt);

                }
                return liste;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
    }


