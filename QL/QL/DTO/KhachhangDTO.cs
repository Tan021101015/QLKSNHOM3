using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.DTO
{
    class KhachhangDTO
    {
        private string _makh;
        private string _diachi;
        private string _tenkh;
        private string _ngaysinh;
        private string _gioitinh;
        private string _sodt;

        public string makh
        {
            get { return _makh; }
            set { _makh = value; }
        }
        public string diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        public string tenkh
        {
            get { return _tenkh; }
            set { _tenkh = value; }
        }
        public string ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        public string gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        public string sodt
        {
            get { return _sodt; }
            set { _sodt = value; }
        }

        public KhachhangDTO()
        {
            _makh = "";
            _diachi = "";
            _tenkh = "";
            _ngaysinh = "";
            _gioitinh = "";
            _sodt = "";
        }
        public KhachhangDTO(string makh, string tenkh, string diachi, string ngaysinh, string gioitinh, string sodt)
        {
            _makh = makh;
            _diachi = diachi;
            _tenkh = tenkh;
            _ngaysinh = ngaysinh;
            _gioitinh = gioitinh;
            _sodt = sodt;
        }
    }
}
