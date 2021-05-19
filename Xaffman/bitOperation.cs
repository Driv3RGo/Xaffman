using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xaffman
{
    public class bitOperation
    {
        public int bitNumber;   //Номер бита

        public bitOperation()
        {
            bitNumber = 0;
        }

        public void setbit(ref byte b, char code)
        {
            switch(bitNumber)
            {
                case 0:
                    {
                        if (code == '1') b = 1;
                        else b = 0;
                        bitNumber++;
                    }
                    break;
                case 1:
                    {
                        if (code == '1') b = (byte)(b | 1 << 1);
                        bitNumber++;
                    }
                    break;
                case 2:
                    {
                        if (code == '1') b = (byte)(b | 1 << 2);
                        bitNumber++;
                    }
                    break;
                case 3:
                    {
                        if (code == '1') b = (byte)(b | 1 << 3);
                        bitNumber++;
                    }
                    break;
                case 4:
                    {
                        if (code == '1') b = (byte)(b | 1 << 4);
                        bitNumber++;
                    }
                    break;
                case 5:
                    {
                        if (code == '1') b = (byte)(b | 1 << 5);
                        bitNumber++;
                    }
                    break;
                case 6:
                    {
                        if (code == '1') b = (byte)(b | 1 << 6);
                        bitNumber++;
                    }
                    break;
                case 7:
                    {
                        if (code == '1') b = (byte)(b | 1 << 7);
                        bitNumber = 0;
                    }
                    break;
            }
        }

        public void readbit(byte b, ref char code)
        {
            switch(bitNumber)
            {
                case 0:
                    {
                        if ((b & 1) == 0) code = '0';
                        else code = '1';
                        bitNumber++;
                    }
                    break;
                case 1:
                    {
                        if ((b & 1 << 1) == 0) code = '0';
                        else code = '1';
                        bitNumber++;
                    }
                    break;
                case 2:
                    {
                        if ((b & 1 << 2) == 0) code = '0';
                        else code = '1';
                        bitNumber++;
                    }
                    break;
                case 3:
                    {
                        if ((b & 1 << 3) == 0) code = '0';
                        else code = '1';
                        bitNumber++;
                    }
                    break;
                case 4:
                    {
                        if ((b & 1 << 4) == 0) code = '0';
                        else code = '1';
                        bitNumber++;
                    }
                    break;
                case 5:
                    {
                        if ((b & 1 << 5) == 0) code = '0';
                        else code = '1';
                        bitNumber++;
                    }
                    break;
                case 6:
                    {
                        if ((b & 1 << 6) == 0) code = '0';
                        else code = '1';
                        bitNumber++;
                    }
                    break;
                case 7:
                    {
                        if ((b & 1 << 7) == 0) code = '0';
                        else code = '1';
                        bitNumber = 0;
                    }
                    break;
            }
        }
    }
}
