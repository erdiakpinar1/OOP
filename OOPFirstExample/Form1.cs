using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPFirstExample
{
    public partial class Form1 : Form
    {
        public Form1() // constructor
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    // for'a ilk girdiğinde i değeri 0 j değeri 0 olacak. Bu iki değer için yeni bir button yaratmalıyız 2. durum 0 a 1 olacak 3. durum ... yani her bir döngü için yeni bir button instance etmeliyiz alttaki kod bu işe yarıyor bu şekilde herhangi bir buttona ulaşmak çok kolaylaşacak, sadece i ve j yi bilmemiz sonradan müdahale edilmek istene buttona çok kolay müdahle edilmesine olanak sağlayacak.
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 75;
                    buttons[i, j].Height = 75;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 75;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                left = 0;
                top += 75;
            }
        }
    }
}
