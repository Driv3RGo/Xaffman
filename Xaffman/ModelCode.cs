using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xaffman
{
    public class ModelCode
    {
        public byte? symbol;     //Символ
        public string code;     //Код символа

        public ModelCode(byte? symbol, string code)
        {
            this.symbol = symbol;
            this.code = code;
        }   
    }
}
