using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhHoa1.Models
{
    public class TinhToanModel
    {

        public double so1 { get; set; }
        public double so2 { get; set; }
        public String pt { get; set; }
        public double ketqua()
        {
            double kq = 0;
            switch (pt)
            {
                case "+": kq = so1 + so2; break;
                case "-": kq = so1 - so2; break;
                case "*": kq = so1 * so2; break;
                case "/": kq = so1 / so2; break;
            }
            return kq;
        }
    }
}
