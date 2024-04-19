using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LOAIBAOHIEM
    {
        QLNhanSuEntities3 db = new QLNhanSuEntities3();
        public DataLayer.LOAIBAOHIEM getItem(int id)
        {
            return db.LOAIBAOHIEMs.FirstOrDefault(x => x.LBH_ID == id);
        }

        public List<DataLayer.LOAIBAOHIEM> getList()
        {
            return db.LOAIBAOHIEMs.ToList();

        }
        public DataLayer.LOAIBAOHIEM Add(DataLayer.LOAIBAOHIEM lbh)
        {
            try
            {
                db.LOAIBAOHIEMs.Add(lbh);
                db.SaveChanges();
                return lbh;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public DataLayer.LOAIBAOHIEM Update(DataLayer.LOAIBAOHIEM lbh)
        {
            try
            {
                var _lbh = db.LOAIBAOHIEMs.FirstOrDefault(x => x.LBH_ID == lbh.LBH_ID);
                _lbh.TENBAOHIEM = lbh.TENBAOHIEM;
                db.SaveChanges();
                return lbh;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(int id)
        {
            try
            {
                var _lbh = db.LOAIBAOHIEMs.FirstOrDefault(x => x.LBH_ID == id);
                db.LOAIBAOHIEMs.Remove(_lbh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                return;
            }
        }
    }
}
