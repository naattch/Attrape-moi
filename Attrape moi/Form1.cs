using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attrape_moi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        //CODE POUR LE DEPLACEMENT DU BOUTON ALEATOIREMENT LOSQUE LA SOURIS DESSUS
        int i = 0;
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int x = r.Next(panel1.Width - button1.Width);
            int y = r.Next(panel1.Height - button1.Height);
            button1.Location = new Point(x, y);

            i++;
            label2.Text = i.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //CODE POUR ENREGISTRER LE SCORE ET PSEUDO AVEC UN BOUTON
        private void savebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.RestoreDirectory = true;
            savefile.InitialDirectory = @"C:\";
            savefile.FileName = String.Format("");
            savefile.DefaultExt = "*.txt*";
            savefile.Filter = "TEXT Files|*.txt";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    sw.WriteLine(textBox1.Text);
                    sw.WriteLine(label2.Text);
                    sw.Close();
                }


            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        //CODE POUR RECUPERER CE QU'ON A SAUVEGARDER (CHARGER LES INFO)
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = @"C:\";
            openFile.Filter = "text Files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.FileName = String.Format("");

            if (openFile.ShowDialog() == DialogResult.OK)

                using (StreamReader sr = new StreamReader(openFile.FileName))
                {
                    textBox1.Text = sr.ReadLine();
                    label2.Text = sr.ReadLine();
                    i = Convert.ToInt32(label2.Text);

                }
        }
        //UN BOUTON QUITTER
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

