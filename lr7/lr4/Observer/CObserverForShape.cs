using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lr4.Shapes;

namespace lr4.Observer
{
    public class CObserverForShape
    {
        CShape shape;

        // shape2
        public CObserverForShape(CShape shape)
        {
            // для shape2
            this.shape = shape;
        }

        // shape1
        public void OnSubjectChanged(CShape who)
        {
            //int dx = who.GetOriginal().x - shape.GetOriginal().x;
            //int dy = who.GetOriginal().y - shape.GetOriginal().y;
            // who - shape1
            //shape.GetOriginal().x = who.GetOriginal().x +dx;
           // shape.GetOriginal().y = who.GetOriginal().y +dy;
           
        }
    }
}
