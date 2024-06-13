using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CthLogin.Interface
{
    internal class LogitechMouse : MouseInterface
    {
        public string RightClick()
        {
            return "Right Click";
        }

        public string LeftClick()
        {
            return "Left Click";
        }
    }
}
