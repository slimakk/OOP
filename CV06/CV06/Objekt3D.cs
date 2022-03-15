using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    interface Objekt3D : GrObjekt
    {
        double SpoctiPovrch();
        double SpoctiObjem();
        //void Kresli();
    }
}
