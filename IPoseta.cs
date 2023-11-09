using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivatnaOrdinacija_WindowsForms
{
    internal interface IPoseta
    {
        void upis(StreamWriter sw);
        string ispis();
        void citaj(string linija);

    }
}
