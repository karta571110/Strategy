using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class CashFactory //收費物件產生工廠
    {
        public static CashSuper createCashAccept(string type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case "正常收費":
                    cs = new CashNormal();
                    break;
                case "滿300送100":
                    CashReturn cr1 = new CashReturn("300", "100");
                    cs = cr1;
                    break;
                case "打八折":
                    CashRebate cr2 = new CashRebate("0.8");
                    cs = cr2;
                    break;
            }
            return cs;
        }

    }
}
