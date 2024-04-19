using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class TONGIAO
    {
        QLNhanSuEntities3 db = new QLNhanSuEntities3();
        public DataLayer.TONGIAO getItem(string id)
        {
            return db.TONGIAOs.FirstOrDefault(x => x.MATG == id);
        }

        public List<DataLayer.TONGIAO> getList()
        {
            return db.TONGIAOs.ToList();

        }
        public DataLayer.TONGIAO Add(DataLayer.TONGIAO tg)
        {
            try
            {
                db.TONGIAOs.Add(tg);
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: "+ ex.Message);
            }
        }
        public DataLayer.TONGIAO Update(DataLayer.TONGIAO tg)
        {
            try
            {
                var _tg = db.TONGIAOs.FirstOrDefault(x => x.MATG == tg.MATG);
                _tg.TENTONGIAO = tg.TENTONGIAO;
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
            try
            {
                var _tg = db.TONGIAOs.FirstOrDefault(x => x.MATG == id);
                db.TONGIAOs.Remove(_tg); 
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                return;
            }
        }
    }
}
