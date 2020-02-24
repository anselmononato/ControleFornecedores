

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sirb.Documents.BR.Enumeration;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            var teste = Sirb.Documents.BR.Validation.CNPJ.IsValid("12068131000190");
        }
    }
}

