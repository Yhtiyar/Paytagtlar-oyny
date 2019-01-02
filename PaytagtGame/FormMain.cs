using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaytagtGame
{
    public partial class FormMain : Form
    {
        
        public FormMain( )
        {
            
            InitializeComponent();
          
            
        }

        private void btYewropa_Click(object sender, EventArgs e)
        {
            
                FormLevel formlevel = new FormLevel(1);
                formlevel.ShowDialog();
            
        }

        private void btAziýa_Click(object sender, EventArgs e)
        {
            /*  FormLevel formlevel = new FormLevel(2);
              formlevel.ShowDialog();*/
            MessageBox.Show("Häli taýýar däl");
        }

        private void btAfrika_Click(object sender, EventArgs e)
        {
            /*FormLevel formlevel = new FormLevel(3);
            formlevel.ShowDialog();*/
            MessageBox.Show("Häli taýýar däl");
        }

        private void FormMain_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
         
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTest formtest = new FormTest();
            formtest.Show();
        }
    }
}
