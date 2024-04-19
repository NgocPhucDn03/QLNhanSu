using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CHUCVU
    {
        QLNhanSuEntities3 db = new QLNhanSuEntities3();
        public DataLayer.CHUCVU getItem(string id)
        {
            return db.CHUCVUs.FirstOrDefault(x => x.MACV == id);
        }

        public List<DataLayer.CHUCVU> getList()
        {
            return db.CHUCVUs.ToList();

        }
        public DataLayer.CHUCVU Add(DataLayer.CHUCVU QT)
        {
            try
            {
                db.CHUCVUs.Add(QT);
                db.SaveChanges();
                return QT;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public DataLayer.CHUCVU Update(DataLayer.CHUCVU QT)
        {
            try
            {
                var _QT = db.CHUCVUs.FirstOrDefault(x => x.MACV == QT.MACV);
                _QT.TENCHUCVU = QT.TENCHUCVU;
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
            var _QT = db.CHUCVUs.FirstOrDefault(x => x.MACV == id);
            if (_QT != null)
            {
                
                db.CHUCVUs.Remove(_QT);
                db.SaveChanges();
            }
            else
            {

                return;
            }
        }
    }
}
