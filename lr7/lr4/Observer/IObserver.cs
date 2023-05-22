using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lr4.Shapes;

namespace lr4.Observer
{
    public  interface IObserver
    {
        void OnSubjectChanged();
    }
}
