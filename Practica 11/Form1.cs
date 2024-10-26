namespace Practica_11
{
    public partial class Form1 : Form
    {
        private readonly string texto = "Este es el texto que se lee y escribe caracter a caracter";
        private bool lectura = false;
        private bool escritura = false;
        public Form1()
        {
            InitializeComponent();
        }
        #region Escritura
        private void button1_Click(object sender, EventArgs e)
        {
            ocupado.Text = "";
            if (!escritura && !lectura) {
                escritura = true;
                richTextBox1.Text = "";
                Thread escritor = new Thread(() =>
                {
                    for (int i = 0; i < texto.Length; i++)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBox1.Text += texto[i];
                        });
                        Thread.Sleep(200);
                    }
                    escritura = false;
                });
                escritor.Start();
            }
            else
            {
                ocupado.Text = (escritura == true ? "En este momento se esta escribiendo por otro hilo" 
                    : "En este momento se esta leyendo por otro hilo");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ocupado.Text = "";
            if (!escritura && !lectura)
            {
                escritura = true;
                Thread escritor = new Thread(() =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.Text = "";
                    });
                    for (int i = 0; i < texto.Length; i++)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBox1.Text += texto[i];
                        });
                        Thread.Sleep(200);
                    }
                    escritura = false;
                });
                escritor.Start();
            }
            else
            {
                ocupado.Text = (escritura == true ? "En este momento se esta escribiendo por otro hilo"
                    : "En este momento se esta leyendo por otro hilo");
            }
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ocupado.Text = "";
            if (!escritura && !lectura) {
                escritura = true;
                Thread escritor = new Thread(() =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.Text = "";
                    });
                    for (int i = 0; i < texto.Length; i++)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBox1.Text += texto[i];
                        });
                        Thread.Sleep(200);
                    }
                    escritura = false;
                });
                escritor.Start();
            }
            else
            {
                ocupado.Text = (escritura == true ? "En este momento se esta escribiendo por otro hilo"
                    : "En este momento se esta leyendo por otro hilo");
            }
        }
        #endregion Escritura
        #region Leer
        private void button2_Click(object sender, EventArgs e)
        {
            ocupado.Text = "";
            if (!escritura)
            {
                lectura = true;
                Thread lector = new Thread(() =>
                {
                    for (int i = 0; i <= richTextBox1.Text.Length; i++)
                    {
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            richTextBox1.Select(i, 1);
                            richTextBox1.SelectionColor = Color.Red;
                        });
                        Thread.Sleep(200);
                    }
                    lectura = false;
                });
                lector.Start();
            }
            else
            {
                ocupado.Text = (escritura == true ? "En este momento se esta escribiendo por otro hilo"
                    : "En este momento se esta leyendo por otro hilo");
            }
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ocupado.Text = "";
            if (!escritura)
            {
                lectura = true;
                Thread lector = new Thread(() =>
                {
                    for (int i = 0; i <= richTextBox1.Text.Length; i++)
                    {
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            richTextBox1.Select(i, 1);
                            richTextBox1.SelectionColor = Color.Blue;
                        });
                        Thread.Sleep(200);
                    }
                    lectura = false;
                });
                lector.Start();
            }
            else
            {
                ocupado.Text = (escritura == true ? "En este momento se esta escribiendo por otro hilo"
                    : "En este momento se esta leyendo por otro hilo");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            ocupado.Text = "";
            if (!escritura) {
                Thread lector = new Thread(() =>
                {
                    lectura = true;
                    for (int i = 0; i <= richTextBox1.Text.Length; i++)
                    {
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            richTextBox1.Select(i, 1);
                            richTextBox1.SelectionColor = Color.Purple;
                        });
                        Thread.Sleep(200);
                    }
                    lectura= false;
                });
                lector.Start();
            }
            else
            {
                ocupado.Text = (escritura == true ? "En este momento se esta escribiendo por otro hilo"
                    : "En este momento se esta leyendo por otro hilo");
            }
            
        }
        #endregion Leer
    }
}
