using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IAdd
    {
        int Add(int x, int y);
    }
    interface ISub
    {
        int Sub(int x, int y);
    }
    interface IProd
    {
        int Prod(int x, int y);
    }
    interface IDiv
    {
        int Div(int x, int y);
    }

    interface IAll : IAdd, ISub, IDiv, IProd
    {

    }

    interface ISubProd : ISub, IProd
    {

    }

    interface IAddProd : IAdd, IProd
    {

    }
}
