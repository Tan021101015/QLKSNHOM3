using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.DTO
{
    class QLtaikhoanDTO
    {
        private string _tentk;
        private string _manv;
        private string _matkhau;
        private string _loaitk;


        public string tentk
        {
            get
            {
                return _tentk;
            }
            set
            {
                _tentk = value;
            }
        }
        public string manv
        {
            get
            {
                return _manv;
            }
            set
            {
                _manv = value;
            }
        }
        public string matkhau
        {
            get
            {
                return _matkhau;
            }
            set
            {
                _matkhau = value;
            }
        }
        public string loaitk
        {
            get
            {
                return _loaitk;
            }
            set
            {
                _loaitk = value;
            }
        }

        public QLtaikhoanDTO()
        {
            _tentk = "";
            _manv = "";
            _matkhau = "";
            _loaitk = "";
        }
        public QLtaikhoanDTO(string tentk, string manv, string matkhau, string loaitk)
        {
            _tentk = tentk;
            _manv = manv;
            _matkhau = matkhau;
            _loaitk = loaitk;

        }
    }
}
