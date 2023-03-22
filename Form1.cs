namespace Lab1
{
    public partial class Form1 : Form
    {
        double input1 = 0;
        string oparation = "";
        public Form1()
        {
            InitializeComponent();
        }

        // บวก
        private void SUM1_Click(object sender, EventArgs e)
        {
            input1 = Double.Parse(this.ANS.Text);
            this.ANS.Text = "";
            this.oparation = "+";
            this.MJ.Text = this.MJ.Text + "+";
        }

        // ลบ
        private void SUM2_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.ANS.Text);
            this.ANS.Text = "";
            this.oparation = "-";
            this.MJ.Text = this.MJ.Text + "-";
        }

        // คูณ
        private void SUM3_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.ANS.Text);
            this.ANS.Text = "";
            this.oparation = "*";
            this.MJ.Text = this.MJ.Text + "*";
        }

        // หาร
        private void SUM4_Click(object sender, EventArgs e)
        {
            this.input1 = Double.Parse(this.ANS.Text);
            this.ANS.Text = "";
            this.oparation = "/";
            this.MJ.Text = this.MJ.Text + "/";
        }

        //1
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.ANS.Text = this.ANS.Text + "1";
            this.MJ.Text = this.MJ.Text + "1";
        }

        // 2
        private void button2_Click(object sender, EventArgs e)
        {
            this.ANS.Text = this.ANS.Text + "2";
            this.MJ.Text = this.MJ.Text + "2";
        }

        // 3 
        private void button3_Click(object sender, EventArgs e)
        {
            this.ANS.Text = this.ANS.Text + "3";
            this.MJ.Text = this.MJ.Text + "3";
        }

        // 4 
        private void button4_Click(object sender, EventArgs e)
        {
            this.ANS.Text = this.ANS.Text + "4";
            this.MJ.Text = this.MJ.Text + "4";
        }

        // 5 
        private void button5_Click(object sender, EventArgs e)
        {
            this.ANS.Text = this.ANS.Text + "5";
            this.MJ.Text = this.MJ.Text + "5";
        }

        // 6
        private void button6_Click(object sender, EventArgs e)
        {
            this.ANS.Text = this.ANS.Text + "6";
            this.MJ.Text = this.MJ.Text + "6";
        }

        // 7
        private void button7_Click(object sender, EventArgs e)
        {
            this.ANS.Text = this.ANS.Text + "7";
            this.MJ.Text = this.MJ.Text + "7";
        }

        // 8
        private void button8_Click(object sender, EventArgs e)
        {
            this.ANS.Text = this.ANS.Text + "8";
            this.MJ.Text = this.MJ.Text + "8";
        }

        // 9
        private void button9_Click(object sender, EventArgs e)
        {
            this.ANS.Text = this.ANS.Text + "9";
            this.MJ.Text = this.MJ.Text + "9";
        }

        // ปุ่ม = 
        private void button10_Click(object sender, EventArgs e)
        {
            double input2 = Double.Parse(this.ANS.Text);
            double result = 0;
            //this.MJ.Text = this.MJ.Text + "=";
            
            if (this.oparation == "+") 
            {

                result = input1 + input2;

            }
            else if (this.oparation == "-")
            {

                result = input1 - input2; 

            }
            else if (this.oparation == "*")
            {

                result = input1 * input2;

            }
            else if (this.oparation == "/")
            {

                result = input1 / input2;

            }

            this.ANS.Text = Convert.ToString(result);
            //this.MJ.Text = Convert.ToString(result);
            this.ANS.Text = string.Format("{0:#,##0.#########}", double.Parse(this.ANS.Text));
        }

        // 0
        private void button11_Click(object sender, EventArgs e)
        {
            this.ANS.Text = this.ANS.Text + "0";
            this.MJ.Text = this.MJ.Text + "0";
        }

        // ล้าง
        private void button12_Click(object sender, EventArgs e)
        {
            this.ANS.Text = "";
            this.MJ.Text = "";
        }

        // จุด
        private void button13_Click(object sender, EventArgs e)
        {
            this.ANS.Text = this.ANS.Text + ".";
            this.MJ.Text = this.MJ.Text + ".";
        }
    }
}