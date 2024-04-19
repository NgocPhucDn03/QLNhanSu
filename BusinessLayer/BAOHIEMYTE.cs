using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BAOHIEMYTE
    {
        QLNhanSuEntities3 db = new QLNhanSuEntities3();
        public DataLayer.BAOHIEMYTE getItem(int id)
        {
            return db.BAOHIEMYTEs.FirstOrDefault(x => x.ID == id);
        }


        public DataLayer.BAOHIEMYTE Add(DataLayer.BAOHIEMYTE BHYTE)
        {
            try
            {
                
                db.BAOHIEMYTEs.Add(BHYTE);
                db.SaveChanges();
                return BHYTE;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public DataLayer.BAOHIEMYTE Update(DataLayer.BAOHIEMYTE BHYTE)
        {
            try
            {
                var _BHYTE = db.BAOHIEMYTEs.FirstOrDefault(x => x.ID == BHYTE.ID);
                _BHYTE.MABAOHIEM = BHYTE.MABAOHIEM;
                _BHYTE.NOICAP = BHYTE.NOICAP;
                _BHYTE.GIATRISUDUNG = BHYTE.GIATRISUDUNG;
                _BHYTE.NOIKHAM = BHYTE.NOIKHAM;
                _BHYTE.MAVUNG = BHYTE.MAVUNG;
                _BHYTE.MANV = BHYTE.MANV;
                _BHYTE.LBH_ID = BHYTE.LBH_ID;
                db.SaveChanges();
                return BHYTE;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public List<DataLayer.BAOHIEMYTE> getList()
        {
            return db.BAOHIEMYTEs.ToList();

        }
        public void Delete(int id, int v)
        {
            try
            {
                var _BHYTE = db.BAOHIEMYTEs.FirstOrDefault(x => x.ID == id);
                db.BAOHIEMYTEs.Remove(_BHYTE);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                return;
            }
        }
    }
}
