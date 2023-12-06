using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.DTO
{
    class QLTBDTO
    {
        private string _matb;
        private string _maphong;
        private string _tentb;
        private string _gia;
       
        public string matb
        {
            get
            {
                return _matb;
            }
            set
            {
                _matb = value;
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
        public string tentb
        {
            get
            {
                return _tentb;
            }
            set
            {
                _tentb = value;
            }
        }
        public string gia
        {
            get
            {
                return _gia;
            }
            set
            {
                _gia = value;
            }
        }
      
        public QLTBDTO()
        {
            _matb = "";
            _maphong = "";
            _tentb = "";
            _gia = "";
          
        }
        public QLTBDTO(string matb, string maphong, string tentb, string gia)
        {
            _matb = matb;
            _maphong = maphong;
            _tentb = tentb;
            _gia = gia;
            

        }
    }
}
