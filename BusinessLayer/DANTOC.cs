using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class DANTOC
    {

        QLNhanSuEntities3 db = new QLNhanSuEntities3();
        public DataLayer.DANTOC getItem(string id)
        {
            return db.DANTOCs.FirstOrDefault(x => x.MADT == id);
        }

        public List<DataLayer.DANTOC> getList()
        {
            return db.DANTOCs.ToList();

        }
        public DataLayer.DANTOC Add(DataLayer.DANTOC QT)
        {
            try
            {
                db.DANTOCs.Add(QT);
                db.SaveChanges();
                return QT;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public DataLayer.DANTOC Update(DataLayer.DANTOC QT)
        {
            try
            {
                var _QT = db.DANTOCs.FirstOrDefault(x => x.MADT == QT.MADT);
                _QT.TENDANTOC = QT.TENDANTOC;
                db.SaveChanges();
                return QT;
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
                var _QT = db.DANTOCs.FirstOrDefault(x => x.MADT == id);
                db.DANTOCs.Remove(_QT);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                return;
            }
        }
    }
}
