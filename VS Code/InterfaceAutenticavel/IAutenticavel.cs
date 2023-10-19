using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public interface IAutenticavel
    {
        bool Autentica(int senha);
    }
}