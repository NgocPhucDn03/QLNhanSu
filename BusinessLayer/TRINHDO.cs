using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLayer
{
    public class TRINHDO
    {
        QLNhanSuEntities3 db = new QLNhanSuEntities3();
        public DataLayer.TRINHDO getItem(string id)
        {
            return db.TRINHDOes.FirstOrDefault(x => x.MATD == id);
        }

        public List<DataLayer.TRINHDO> getList()
        {
            return db.TRINHDOes.ToList();

        }
        public DataLayer.TRINHDO Add(DataLayer.TRINHDO QT)
        {
            try
            {
                db.TRINHDOes.Add(QT);
                db.SaveChanges();
                return QT;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public DataLayer.TRINHDO Update(DataLayer.TRINHDO QT)
        {
            try
            {
                var _QT = db.TRINHDOes.FirstOrDefault(x => x.MATD == QT.MATD);
                _QT.TENTRINHDO = QT.TENTRINHDO;
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
                var _QT = db.TRINHDOes.FirstOrDefault(x => x.MATD == id);
                db.TRINHDOes.Remove(_QT);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                return;
            }
        }
    }
}
