using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class CashReturn:CashSuper
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;

        public CashReturn(string moneyCondition,string moneyReturn)
        {
            this.moneyCondition = Double.Parse(moneyCondition);
            this.moneyReturn = Double.Parse(moneyReturn);
        }

        public override double acceptCash(double money)
        {
            double result = money;
            if (money >= moneyCondition)
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;//Math.Floor 除去小數
            return result;
        }
    }
}
