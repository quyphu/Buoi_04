using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_04
{
    class HinhTron
    {
        private ToaDo _tam;

        internal ToaDo Tam
        {
            get { return _tam; }
            set { _tam = value; }
        }


        private double _banKinh;

        public double BanKinh
        {
            get { return _banKinh; }
            set { _banKinh = value; }
        }

        


        public HinhTron(ToaDo Tam, double banKinh)
        {
            this.Tam = Tam;
            this.BanKinh = banKinh;
        }


        public double DTHinhTron()
        {
            return  Math.PI * BanKinh * BanKinh;
        }

        public double CVHinhTron()
        {
            return 2 * Math.PI * BanKinh;
        }



        public void XuatTTHinhTron()
        {
            Console.WriteLine("Hinh Tron Co Tam: O({0},{1}) \t Voi Ban Kinh: {2} \t Co Dien Tich Va Chu Vi Lan Luot La: {3} \t {4}",Tam.X ,Tam.Y,BanKinh,DTHinhTron(),CVHinhTron());
        }
    }
}
