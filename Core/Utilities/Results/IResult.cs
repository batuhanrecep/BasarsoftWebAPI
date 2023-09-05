using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResult
    {

        //Yapılan işlem başarılı mı onu görmek için 
        bool Success { get; }

        //Yapılan işlemin mesajı
        string Message { get; }
    }
}

