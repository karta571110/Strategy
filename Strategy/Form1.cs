using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
    public partial class Form1 : Form
    {
        double total = 0.0d;
        public Form1()
        {
            InitializeComponent();
            cbxType.Items.AddRange(new object[]{ "正常收費","打八折","滿300送100"});
            cbxType.SelectedIndex = 0;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            /*//簡單工廠模式
            try
            {
                CashSuper csuper = CashFactory.createCashAccept(cbxType.SelectedItem.ToString());//根據選項，選擇出應該要New出哪個Class
                double totalPrices = 0d;

                totalPrices = csuper.acceptCash(Double.Parse(txtPrice.Text)*Double.Parse(txtNum.Text));

                total = total + totalPrices;

                lbxList.Items.Add("單價：" + txtPrice.Text + "數量：" + txtNum.Text + "合計：" + totalPrices.ToString());

                lblResult.Text = total.ToString();
            }
            catch(Exception ex)
            {
                lbxList.Items.Add("不能這樣輸入" + ex.Message);
            }
            */
            //簡單工廠模式加上策略模式
            CashContext csuper = new CashContext(cbxType.SelectedItem.ToString());

            double totalPrices = 0d;

            totalPrices = csuper.GetResult(Double.Parse(txtPrice.Text) * Double.Parse(txtNum.Text));

            lbxList.Items.Add("單價：" + txtPrice.Text + "數量：" + txtNum.Text + "合計：" + totalPrices.ToString());

            total = total + totalPrices;

            lblResult.Text = total.ToString();

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            lbxList.Items.Clear();
            total = 0;
            lblResult.Text = "0";
        }
    }
}
