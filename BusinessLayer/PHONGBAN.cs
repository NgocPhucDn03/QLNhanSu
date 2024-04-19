using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Diagnostics.Eventing.Reader;

namespace BusinessLayer
{
    public class PHONGBAN
    {
        QLNhanSuEntities3 db = new QLNhanSuEntities3();
        public DataLayer.PHONGBAN getItem(string id)
        {
            return db.PHONGBANs.FirstOrDefault(x => x.MAPB == id);
        }

        public List<DataLayer.PHONGBAN> getList()
        {
            return db.PHONGBANs.ToList();

        }
        public DataLayer.PHONGBAN Add(DataLayer.PHONGBAN tg)
        {
            try
            {
                db.PHONGBANs.Add(tg);
                db.SaveChanges();
                return tg;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public DataLayer.PHONGBAN Update(DataLayer.PHONGBAN tg)
        {
            try
            {
                var _tg = db.PHONGBANs.FirstOrDefault(x => x.MAPB == tg.MAPB);
                _tg.TENPHONGBAN = tg.TENPHONGBAN;
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
            var _tg = db.PHONGBANs.FirstOrDefault(x => x.MAPB == id);
            if (_tg != null)
            {
                db.PHONGBANs.Remove(_tg);
                db.SaveChanges();
            }
            else
            {
                return;

            }
        }
    }
}
