using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class UnControll : IControllable
    {
        bool IControllable.Controll()
        {
            return false;
        }
    }

