using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.DTO
{
    class hoaDontDTO
    {
        private string _mahd;
        private string _makh;
        private string _madv;
        private string _soluong;
        private string _tongtien;
        private string _ngaydat;
        private string _ngaytra;
       
        public string mahd
        {
            get { return _mahd; }
            set { _mahd = value; }
        }
        public string makh
        {
            get { return _makh; }
            set { _makh = value; }
        }
        public string madv
        {
            get { return _madv; }
            set { _madv = value; }
        }
        public string soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        public string tongtien
        {
            get { return _tongtien; }
            set { _tongtien = value; }
        }
        public string ngaydat
        {
            get { return _ngaydat; }
            set { _ngaydat = value; }
        }
        public string ngaytra
        {
            get { return _ngaytra; }
            set { _ngaytra = value; }
        }

        public hoaDontDTO()
        {
            _mahd = "";
            _makh ="";
            _madv = "";
            _soluong = "";
            _tongtien = "";
            _ngaydat = "";
            _ngaytra = "";
        }

        public hoaDontDTO(string mahd, string makh, string madv, string soluong, string tongtien, string ngaydat, string ngaytra)
        {
            _mahd = mahd;
            _makh = makh;
            _madv = madv;
            _soluong = soluong;
            _tongtien = tongtien;
            _ngaydat = ngaydat;
            _ngaytra = ngaytra;
        }
    }
}
