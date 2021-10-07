using System;
using System.Collections.Generic;
using System.Text;

namespace WeeklylAssignment5._3
{
    interface IGeneric<T>
    {
        T Validate();
        T Inspect();
    }
}
