using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.Controlled_animals
{
    class Controll : IControllable
    {
        bool IControllable.Controll()
        {
            return false;
        }
    }
}
