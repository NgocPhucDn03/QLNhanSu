using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class QUOCTICH
    {


        QLNhanSuEntities3 db = new QLNhanSuEntities3();
        public DataLayer.QUOCTICH getItem(string id)
        {
            return db.QUOCTICHes.FirstOrDefault(x => x.MAQT == id);
        }

        public List<DataLayer.QUOCTICH> getList()
        {
            return db.QUOCTICHes.ToList();

        }
        public DataLayer.QUOCTICH Add(DataLayer.QUOCTICH tg)
        {
            try
            {
                db.QUOCTICHes.Add(tg);
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public DataLayer.QUOCTICH Update(DataLayer.QUOCTICH tg)
        {
            try
            {
                var _tg = db.QUOCTICHes.FirstOrDefault(x => x.MAQT == tg.MAQT);
                _tg.TENQUOCTICH = tg.TENQUOCTICH;
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(string id)
        {
             var _tg = db.QUOCTICHes.FirstOrDefault(x => x.MAQT == id);
            if (_tg != null)
            {
                db.QUOCTICHes.Remove(_tg);
                db.SaveChanges();
                
            }
            else
            {
                return;
            }

        }
    }
}