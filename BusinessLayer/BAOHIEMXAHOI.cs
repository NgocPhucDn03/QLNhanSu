using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BAOHIEMXAHOI
    {
        QLNhanSuEntities3 db = new QLNhanSuEntities3();
        public DataLayer.BAOHIEMXAHOI getItem(int id)
        {
            return db.BAOHIEMXAHOIs.FirstOrDefault(x => x.ID == id);
        }


        public DataLayer.BAOHIEMXAHOI Add(DataLayer.BAOHIEMXAHOI BHXH)
        {
            try
            {
                db.BAOHIEMXAHOIs.Add(BHXH);
                db.SaveChanges();
                return BHXH;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public DataLayer.BAOHIEMXAHOI Update(DataLayer.BAOHIEMXAHOI BHXH)
        {
            try
            {
                var _BHXH = db.BAOHIEMXAHOIs.FirstOrDefault(x => x.ID == BHXH.ID);
                _BHXH.MABAOHIEM = BHXH.MABAOHIEM;
                _BHXH.NOICAP = BHXH.NOICAP;
                _BHXH.NGAYCAP= BHXH.NGAYCAP;
                _BHXH.THOIGIANDONGBH = BHXH.THOIGIANDONGBH;
                _BHXH.THOIGIANLAMVIEC = BHXH.THOIGIANLAMVIEC; 
                _BHXH.MANV = BHXH.MANV;
                _BHXH.LBH_ID = BHXH.LBH_ID;
                db.SaveChanges();
                return BHXH;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public List<DataLayer.BAOHIEMXAHOI> getList()
        {
            return db.BAOHIEMXAHOIs.ToList();

        }
        public void Delete(int id, int v)
        {
            var _BHXH = db.BAOHIEMXAHOIs.FirstOrDefault(x => x.ID == id);
            if (_BHXH!=null)
            {
               
                db.BAOHIEMXAHOIs.Remove(_BHXH);
                db.SaveChanges();
            }
            else
            {

                return;
            }
        }
    }
}
