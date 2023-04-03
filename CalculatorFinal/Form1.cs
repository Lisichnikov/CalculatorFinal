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

        private void button37_Click(object sender, EventArgs e)
        {
            if (label9.Text == "1") textBox4.Text = textBox4.Text + 1;
            if (label9.Text == "11") textBox5.Text = textBox5.Text + 1;
            if (label9.Text == "111") textBox6.Text = textBox6.Text + 1;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (label9.Text == "1") textBox4.Text = textBox4.Text + 2;
            if (label9.Text == "11") textBox5.Text = textBox5.Text + 2;
            if (label9.Text == "111") textBox6.Text = textBox6.Text + 2;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (label9.Text == "1") textBox4.Text = textBox4.Text + 3;
            if (label9.Text == "11") textBox5.Text = textBox5.Text + 3;
            if (label9.Text == "111") textBox6.Text = textBox6.Text + 3;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (label9.Text == "1") textBox4.Text = textBox4.Text + 4;
            if (label9.Text == "11") textBox5.Text = textBox5.Text + 4;
            if (label9.Text == "111") textBox6.Text = textBox6.Text + 4;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (label9.Text == "1") textBox4.Text = textBox4.Text + 5;
            if (label9.Text == "11") textBox5.Text = textBox5.Text + 5;
            if (label9.Text == "111") textBox6.Text = textBox6.Text + 5;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (label9.Text == "1") textBox4.Text = textBox4.Text + 6;
            if (label9.Text == "11") textBox5.Text = textBox5.Text + 6;
            if (label9.Text == "111") textBox6.Text = textBox6.Text + 6;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (label9.Text == "1") textBox4.Text = textBox4.Text + 7;
            if (label9.Text == "11") textBox5.Text = textBox5.Text + 7;
            if (label9.Text == "111") textBox6.Text = textBox6.Text + 7;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (label9.Text == "1") textBox4.Text = textBox4.Text + 8;
            if (label9.Text == "11") textBox5.Text = textBox5.Text + 8;
            if (label9.Text == "111") textBox6.Text = textBox6.Text + 8;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (label9.Text == "1") textBox4.Text = textBox4.Text + 9;
            if (label9.Text == "11") textBox5.Text = textBox5.Text + 9;
            if (label9.Text == "111") textBox6.Text = textBox6.Text + 9;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (label9.Text == "1") textBox4.Text = textBox4.Text + 0;
            if (label9.Text == "11") textBox5.Text = textBox5.Text + 0;
            if (label9.Text == "111") textBox6.Text = textBox6.Text + 0;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            label9.Text = label9.Text + 1;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            label9.Text = "1";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            double c = Convert.ToDouble(textBox6.Text);
            double d = (b * b) - (4 * a * c);
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                textBox7.Text = $"x1= " + x1 + "; x2= " + x2;
            }
            if (d < 0)
            {
                textBox7.Text = "Корней нет!";
            }
            if (d == 0)
            {
                double x = (-b / (2 * a));
                textBox7.Text = $"x= " + x;

            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox8.Text + 1;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox8.Text + 2;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox8.Text + 3;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox8.Text + 4;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox8.Text + 5;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox8.Text + 6;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox8.Text + 7;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox8.Text + 8;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox8.Text + 9;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            textBox8.Text = textBox8.Text + 0;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox8.Text);
            string s = "";
            if (label12.Text == "bin")
            {
                while (a > 0)
                {
                    if (a % 2 == 0) s = "0" + s;
                    else s = "1" + s;
                    a /= 2;
                }
                textBox9.Text = $"{s}";
            }
            if (label12.Text == "oct")
            {
                textBox9.Text = Convert.ToString(a, 8);
            }
            if (label12.Text == "hex")
            {
                textBox9.Text = Convert.ToString(a, 16);
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox9.Text = "";
            label12.Text = "_";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            label12.Text = "bin";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            label12.Text = "oct";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            label12.Text = "hex";
        }
    }
}