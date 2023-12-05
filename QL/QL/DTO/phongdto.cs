using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL.DTO
{
    class phongdto
    {
        private string _maphong;
        private string _tenphong;
        private string _loaiphong;
        private string _tinhtrang;
        private string _dongia;


        public string maphong
        {
            get { return _maphong; }
            set { _maphong = value; }
        }
        public string tenphong
        {
            get { return _tenphong; }
            set { _tenphong = value; }
        }
        public string loaiphong
        {
            get { return _loaiphong; }
            set { _loaiphong = value; }
        }
        public string tinhtrang
        {
            get { return _tinhtrang; }
            set { _tinhtrang = value; }
        }
        public string dongia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }


        public phongdto()
        {
            _maphong = "";
            _tenphong = "";
            _loaiphong = "";
            _tinhtrang = "";
            _dongia = "";

        }
        public phongdto(string maphong, string tenphong, string loaiphong, string tinhtrang, string dongia)
        {
            _maphong = maphong;
            _tenphong = tenphong;
            _loaiphong = loaiphong;
            _tinhtrang = tinhtrang;
            _dongia = dongia;
        }
    }
}

    


    

