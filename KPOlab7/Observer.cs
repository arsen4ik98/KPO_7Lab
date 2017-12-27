using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPOlab7
{
    class Observer : IObserver
    {
        public static int counterA;
        public static int counterD;
        TextBox textbox1;
        TextBox textbox2;
        IObservable stock;
        public Observer(TextBox textBox1, TextBox textBox2, IObservable obs)
        {
            this.textbox1 = textBox1;
            this.textbox2 = textBox2;
            stock = obs;
            stock.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            CkickActive sInfo = (CkickActive)ob;
            if (sInfo.active == true)
            {
                counterA++;
                textbox1.Text = counterA.ToString(); 
            }
            else
            {
                counterD++;
                textbox2.Text = counterD.ToString();
            }

        }
    }
}
