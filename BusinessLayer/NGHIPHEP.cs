using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NGHIPHEP
    {
        QLNhanSuEntities3 db = new QLNhanSuEntities3();
        public DataLayer.NGHIPHEP getItem(string id)
        {
            return db.NGHIPHEPs.FirstOrDefault(x => x.MANP == id);
        }

      
        public DataLayer.NGHIPHEP Add(DataLayer.NGHIPHEP NP)
        {
            try
            {
                db.NGHIPHEPs.Add(NP);
                db.SaveChanges();
                return NP;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public DataLayer.NGHIPHEP Update(DataLayer.NGHIPHEP NP)
        {
            try
            {
                var _NP = db.NGHIPHEPs.FirstOrDefault(x => x.MANP == NP.MANP);
                _NP.LOAINGHIPHEP = NP.LOAINGHIPHEP;
                _NP.MANP = NP.MANP;
                _NP.NGAYBATDAU= NP.NGAYBATDAU;
                _NP.NGAYKETTHUC= NP.NGAYKETTHUC;
                _NP.SONGAY= NP.SONGAY;
                _NP.TRANGTHAI= NP.TRANGTHAI;
                _NP.MANV= NP.MANV;
                db.SaveChanges();
                return NP;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public List<DataLayer.NGHIPHEP> getList()
        {
            return db.NGHIPHEPs.ToList();

        }
        public void Delete(string id)
        {
            try
            {
                var _NP = db.NGHIPHEPs.FirstOrDefault(x => x.MANP == id);
                db.NGHIPHEPs.Remove(_NP);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                return;     
            }
        }
    }
}
