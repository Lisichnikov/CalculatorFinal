namespace CalculatorFinal
{
    public partial class Калькулятор : Form
    {
        public Калькулятор()
        {
            InitializeComponent();
        }

        private string memory = null;
        public string Memory
        {
            get { return memory; }
            set
            {
                memory = value;
            }
        }

        private void button1_Click(object sender, EventArgs e) // 1
        {
            if(label1.Text == "_") textBox1.Text = textBox1.Text + 1;
            else textBox2.Text = textBox2.Text + 1;
        }

        private void button12_Click(object sender, EventArgs e) // квадратный корень
        {
            label2.Text = "Квадратный корень: ";
            label3.Text = "Из: ";
            textBox1.Text = "00000";
            label1.Text = "√";
        }

        private void button2_Click(object sender, EventArgs e) // 2
        {
            if (label1.Text == "_") textBox1.Text = textBox1.Text + 2;
            else textBox2.Text = textBox2.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e) // 3
        {
            if (label1.Text == "_") textBox1.Text = textBox1.Text + 3;
            else textBox2.Text = textBox2.Text + 3;
        }

        private void button6_Click(object sender, EventArgs e) // 4
        {
            if (label1.Text == "_") textBox1.Text = textBox1.Text + 4;
            else textBox2.Text = textBox2.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e) // 5
        {
            if (label1.Text == "_") textBox1.Text = textBox1.Text + 5;
            else textBox2.Text = textBox2.Text + 5;
        }

        private void button4_Click(object sender, EventArgs e) // 6
        {
            if (label1.Text == "_") textBox1.Text = textBox1.Text + 6;
            else textBox2.Text = textBox2.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e) // 7
        {
            if (label1.Text == "_") textBox1.Text = textBox1.Text + 7;
            else textBox2.Text = textBox2.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e) // 8
        {
            if (label1.Text == "_") textBox1.Text = textBox1.Text + 8;
            else textBox2.Text = textBox2.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e) // 9
        {
            if (label1.Text == "_") textBox1.Text = textBox1.Text + 9;
            else textBox2.Text = textBox2.Text + 9;
        }

        private void button11_Click(object sender, EventArgs e) // 0
        {
            if (label1.Text == "_") textBox1.Text = textBox1.Text + 0;
            else textBox2.Text = textBox2.Text + 0;
        }

        private void button24_Click(object sender, EventArgs e) // кнопка =
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            if (label1.Text == "+")
            {
                textBox3.Text = $"{a+b}";
            }
            if (label1.Text == "-")
            {
                textBox3.Text = $"{a - b}";
            }
            if (label1.Text == "*")
            {
                textBox3.Text = $"{a * b}";
            }
            if (label1.Text == "/")
            {
                textBox3.Text = $"{a / b}";
                if (b == 0)
                {
                    textBox3.Text = "Вот скажи, ты дурак?";
                }
            }
            if (label2.Text == "Синус: ")
            {
                textBox3.Text = $"{Math.Sin(b)}";
            }
            if (label2.Text == "Косинус: ")
            {
                textBox3.Text = $"{Math.Cos(b)}";
            }
            if (label2.Text == "Тангенс: ")
            {
                textBox3.Text = $"{Math.Tan(b)}";
            }
            if (label2.Text == "Квадратный корень: ")
            {
                textBox3.Text = $"{Math.Sqrt(b)}";
            }
            if (label1.Text == "^")
            {
                textBox3.Text = $"{Math.Pow(a, b)}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e) // кнопка +
        {
            label1.Text = "+";
        }

        private void button21_Click(object sender, EventArgs e) // кнопка -
        {
            label1.Text = "-";
        }

        private void button19_Click(object sender, EventArgs e) // кнопка *
        {
            label1.Text = "*";
        }

        private void button17_Click(object sender, EventArgs e) // кнопка /
        {
            label1.Text = "/";
        }

        private void button20_Click(object sender, EventArgs e) // кнопка sin
        {
            label2.Text = "Синус: ";
            label3.Text = "Из: ";
            textBox1.Text = "00000";
            label1.Text = "s";
        }

        private void button18_Click(object sender, EventArgs e) // кнопка cos
        {
            label2.Text = "Косинус: ";
            label3.Text = "Из: ";
            textBox1.Text = "00000";
            label1.Text = "c";
        }

        private void button16_Click(object sender, EventArgs e) // кнопка tan
        {
            label2.Text = "Тангенс: ";
            label3.Text = "Из: ";
            textBox1.Text = "00000";
            label1.Text = "t";
        }

        private void button10_Click(object sender, EventArgs e) // кнопка ^
        {
            label1.Text = "^";
        }

        private void button22_Click(object sender, EventArgs e) // сброс
        {
            label2.Text = "Первое число: ";
            label3.Text = "Второе число: ";
            label1.Text = "_";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Memory = textBox1.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = Memory;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (label1.Text == "_") textBox1.Text = textBox1.Text + ".";
            else textBox2.Text = textBox2.Text + ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Memory = null;
        }
    }
}