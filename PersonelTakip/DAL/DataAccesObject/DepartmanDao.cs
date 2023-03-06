using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccesObject
{
    public class DepartmanDao : PersonelDataContent
    {
        public static void departmanekle(Departman dpt)
        {
            try
            {
                db.Departman.InsertOnSubmit(dpt);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
            
        }

        public static List<Departman> departmanGetir()
        {
            try
            {
                return db.Departman.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
