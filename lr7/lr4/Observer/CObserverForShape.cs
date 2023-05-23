using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        public void OnSubjectChangedX(CShape who, int dx, int width, int height)
        {

            //who - shape1
            shape.MoveX(dx, width, height);

        }
        public void OnSubjectChangedY(CShape who, int dy, int width, int height)
        {

            //who - shape1
            shape.MoveY(dy, width, height);

        }
    }
}
