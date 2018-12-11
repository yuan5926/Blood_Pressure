using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPHomework.BloodPressure
{
    public partial class WfrmBloodPressure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
        }

        protected void btn送出資料_Click(object sender, EventArgs e)
        {
            string str訊息 = "";
            int int收縮壓 = 0;
            int int舒張壓 = 0;

            if ((tb收縮壓.Text != "") && (tb舒張壓.Text != ""))
            {
                bool if收縮壓 = false;
                bool if舒張壓 = false;

                if收縮壓 = System.Int32.TryParse(tb收縮壓.Text, out int收縮壓);
                if舒張壓 = System.Int32.TryParse(tb舒張壓.Text, out int舒張壓);

                if ((if收縮壓 == true) && (if舒張壓 == true))
                {
                    if ((int收縮壓 < 120) && (int舒張壓 < 80))
                    {
                        str訊息 = "您的血壓非常理想，為理想血壓。";

                    }
                    else if ((int收縮壓 < 130) && (int舒張壓 < 85))
                    {
                        str訊息 = "您的血壓正常，為正常血壓。";

                    }
                    else if ((int收縮壓 < 140) && (int舒張壓 < 90))
                    {
                        str訊息 = "您的血壓雖然還在正常範圍，但是已經偏高囉!";

                    }
                    else if ((int收縮壓 < 160) && (int舒張壓 < 100))
                    {
                        str訊息 = "您的血壓為第一期高血壓，建議去詢問醫師相關狀況。";

                    }
                    else if ((int收縮壓 < 180) && (int舒張壓 < 110))
                    {
                        str訊息 = "您的血壓為第二期高血壓，建議快點去詢問醫師相關狀況。";

                    }
                    else if ((int收縮壓 >= 180) || (int舒張壓 >= 110))
                    {
                        str訊息 = "哎唷，你的血壓爆表啦!請注意飲食及盡早詢問醫師相關狀況!";
                    }
                }
                else
                {
                    lblMsg.Text = "請輸入正確的收縮壓及舒張壓";
                    lblMsg.Visible = true;
                }

                str訊息 = "您輸入的收縮壓為:" + tb收縮壓.Text + "毫米汞柱<br>" + "您輸入的舒張壓為:" + tb舒張壓.Text + "毫米汞柱<br>" + "高血壓分析建議與結果為:" + str訊息;
                if ((int收縮壓 > 0) && (int舒張壓 > 0))
                {
                    lblMsg.Text = str訊息;
                    lblMsg.Visible = true;
                }
                else
                {
                    lblMsg.Text = "請輸入正確的收縮壓及舒張壓";
                    lblMsg.Visible = true;
                }


            }
            else
            {
                lblMsg.Text = "請輸入收縮壓及舒張壓";
                lblMsg.Visible = true;
            }
        }
    }
}