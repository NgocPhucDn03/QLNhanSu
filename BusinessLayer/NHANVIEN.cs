using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DTO;
using DataLayer;
namespace BusinessLayer
{
    public class NHANVIEN
    {
        QLNhanSuEntities3 db = new QLNhanSuEntities3();
        public DataLayer.NHANVIEN getItem(string id)
        {
            return db.NHANVIENs.FirstOrDefault(x => x.MANV == id);
        }

        public List<DataLayer.NHANVIEN> getList()
        {
            return db.NHANVIENs.ToList();

        }
        public List<NHANVIEN_DTO> getListFull()
        {
            var lstNV = db.NHANVIENs.ToList();
            List<NHANVIEN_DTO> lstNVDTO = new List<NHANVIEN_DTO>();
            NHANVIEN_DTO nvDTO;
            foreach (var item in lstNV)
            {
                nvDTO = new NHANVIEN_DTO();
                nvDTO.MANV = item.MANV;
                nvDTO.CCCD = item.CCCD;
                nvDTO.HOTEN = item.HOTEN;
                nvDTO.GIOITINH = item.GIOITINH;
                nvDTO.NOISINH = item.NOISINH;
                nvDTO.SDT   = item.SDT; 
                nvDTO.EMAIL = item.EMAIL;
                nvDTO.GHICHU = item.GHICHU;
                nvDTO.MACV = item.MACV;
                nvDTO.NGAYSINH = item.NGAYSINH;
               var cv = db.CHUCVUs.FirstOrDefault(b=>b.MACV ==item.MACV);
               nvDTO.TENCHUCVU = cv.TENCHUCVU;
                nvDTO.MADT = item.MADT;
             var dt = db.DANTOCs.FirstOrDefault(b => b.MADT == item.MADT);
               nvDTO.TENDANTOC = dt.TENDANTOC;
              nvDTO.MAPB = item.MAPB;
               var pb = db.PHONGBANs.FirstOrDefault(b => b.MAPB == item.MAPB);
               nvDTO.TENPHONGBAN = pb.TENPHONGBAN;
               nvDTO.MAQT = item.MAQT;
                var qt = db.QUOCTICHes.FirstOrDefault(b => b.MAQT == item.MAQT);
            nvDTO.TENQUOCTICH = qt.TENQUOCTICH;
              nvDTO.MATD = item.MATD;
               var td = db.TRINHDOes.FirstOrDefault(b => b.MATD == item.MATD);
              nvDTO.TENTRINHDO = td.TENTRINHDO;
                nvDTO.MATG = item.MATG;
                var tg = db.TONGIAOs.FirstOrDefault(b => b.MATG == item.MATG);
                nvDTO.TENTONGIAO = tg.TENTONGIAO;
                lstNVDTO.Add(nvDTO);
            }
            return lstNVDTO;
        }
        public DataLayer.NHANVIEN Add(DataLayer.NHANVIEN nv)
        {
            try
            {
                db.NHANVIENs.Add(nv);
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {

                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public DataLayer.NHANVIEN Update(DataLayer.NHANVIEN nv)
        {
            try
            {
                var _nv = db.NHANVIENs.FirstOrDefault(x => x.MANV == nv.MANV);

                _nv.HOTEN = nv.HOTEN;
                _nv.CCCD = nv.CCCD;
                _nv.NOISINH = nv.NOISINH;
                _nv.GIOITINH = nv.GIOITINH;
                _nv.SDT = nv.SDT;
                _nv.NGAYSINH=nv.NGAYSINH;
                _nv.EMAIL   = nv.EMAIL;
                _nv.MACV = nv.MACV;
                _nv.MATD    = nv.MATD;
                _nv.MAPB = nv.MAPB;
                _nv.MAQT = nv.MAQT;
                _nv.MADT = nv.MADT;
                _nv.MATG = nv.MATG;
                _nv.GHICHU  = nv.GHICHU; 

                db.SaveChanges();
                return nv;
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
                var _nv = db.NHANVIENs.FirstOrDefault(x => x.MANV == id);
                db.NHANVIENs.Remove(_nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                return;
            }
        }
    }
}
