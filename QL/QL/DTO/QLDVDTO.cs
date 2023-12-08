using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL.DTO
{
    class QLDVDTO
    {
        public QLDVDTO(string madv, string tendv, string giadv)
        {
            _madv = madv;
            _tendv = tendv;
            _giadv = giadv;
        }

        public QLDVDTO()
        {
            _madv = "";
            _tendv = "";
            _giadv = "";
        }
        private string _madv;
        private string _tendv;
        private string _giadv;

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

        public string tendv
        {
            get
            {
                return _tendv;
            }

            set
            {
                _tendv = value;
            }
        }

        public string giadv
        {
            get
            {
                return _giadv;
            }

            set
            {
                _giadv = value;
            }
        }
    }
}
