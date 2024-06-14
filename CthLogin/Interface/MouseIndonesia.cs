using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CthLogin.Interface
{
    internal class MouseIndonesia : MouseInterface
    {
        public string KlikKanan()
        {
            return "Klik Kanan";
        }

        public string KlikKiri()
        {
            return "Klik Kiri";
        }

        public string LeftClick()
        {
            return KlikKanan();
        }

        public string RightClick()
        {
            return LeftClick();
        }
    }
}
