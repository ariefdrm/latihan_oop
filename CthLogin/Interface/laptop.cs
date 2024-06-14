using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CthLogin.Interface
{
    internal class laptop
    {
        MouseInterface MouseInterface { get; set; }
        public void SetMouse(MouseInterface mouse)
        {
            MouseInterface = mouse;
        }

        public string OnRightClick()
        {
            return MouseInterface.RightClick();
        }

        public string OnLeftClick()
        {
            return MouseInterface.LeftClick();
        }
    }
}
