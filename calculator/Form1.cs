namespace WinFormsApp1
{

    public partial class table : Form
    {
        double Num1, Num2, result;
        int op; // 1 = + ; 2 = - ; 3* ; 4/

        public bool Result { get; private set; }

        public table()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn7.Text;
            caixa2.Text = caixa2.Text + btn7.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn6.Text;
            caixa2.Text = caixa2.Text +btn6.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn1.Text;
            caixa2.Text =  caixa2.Text + btn2.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn2.Text;
            caixa2.Text = caixa2.Text +btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn3.Text;
            caixa2.Text = caixa2.Text + btn3.Text;        
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn4.Text;
            caixa2.Text = caixa2.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn5.Text;
            caixa2.Text = caixa2.Text+btn5.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn8.Text;
            caixa2.Text = caixa2.Text +  btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn9.Text;
            caixa2.Text = caixa2.Text + btn9.Text;  
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn0.Text;
            caixa2.Text = caixa2.Text + btn0.Text;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            caixa2.Text = null;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            caixa2.Text = caixa2.Text + "+"; 
            Num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            op = 1; //soma
            
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            caixa2.Text = caixa2.Text + "*";
            Num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            op = 3;//multiplicacao

          
        }

        private void btndv_Click(object sender, EventArgs e)
        {
            caixa2.Text = caixa2.Text + "/";
            Num1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            op = 4;//div
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(textBox1.Text);
            caixa2.Text = caixa2.Text + "-";
            textBox1.Clear();
            op = 2;//menos
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
     
            Num2 = Convert.ToDouble(textBox1.Text);

            if (op == 1)
            {
                result = Num1 + Num2;
            }
            else if (op == 2)
            {
                result = Num1  - Num2;
            }
            else if (op == 3)
            {
                result = Num1 * Num2;
            }
            else if (op == 4)
            {
                result = Num1 / Num2;
            }
            else
            {
                result = 0;
            }

            textBox1.Text = Convert.ToString(result);
            caixa2.Text = textBox1.Text;
        }
    }
}
