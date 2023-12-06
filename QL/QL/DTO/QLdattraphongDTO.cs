using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.DTO
{
    class QLdattraphongDTO
    {
        private string _makh;
        private string _maphong;
        private string _madv;
        private string _ngaydat;
        private string _ngaytra;

        public string makh
        {
            get
            {
                return _makh;
            }
            set
            {
                _makh = value;
            }
        }
        public string maphong
        {
            get
            {
                return _maphong;
            }
            set
            {
                _maphong = value;
            }
        }
        public string madv
        {
            get
            {
                return _madv;
            }
            set
            {
                _madv = value;
            }
        }
        public string ngaydat
        {
            get
            {
                return _ngaydat;
            }
            set
            {
                _ngaydat = value;
            }
        }
        public string ngaytra
        {
            get
            {
                return _ngaytra;
            }
            set
            {
                _ngaytra = value;
            }
        }
        public QLdattraphongDTO()
        {
            _makh = "";
            _maphong = "";
            _madv = "";
            _ngaydat = "";
            _ngaytra = "";
        }
        public QLdattraphongDTO(string makh, string maphong, string madv, string ngaydat, string ngaytra)
        {
            _makh = makh;
            _maphong = maphong;
            _madv = madv;
            _ngaydat = ngaydat;
            _ngaytra = ngaytra;

        }
    }
}
