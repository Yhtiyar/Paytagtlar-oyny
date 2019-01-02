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
    public partial class FormLevel : Form
    {
        public int level = 1;
        TextBox[] tboxs = new TextBox[10];
        Button[] buttons = new Button[12];
        string countryname;
        string paytagt;
        char[] txt = new char[12];
        int length;
        int cont;
        int h, l;
        Dictionary<string, string> country = new Dictionary<string, string>();
        Dictionary<int, string> dictlvl = new Dictionary<int, string>();
       
        public FormLevel(int fx)
        {
            InitializeComponent();
          
            cont = fx;
           
                
                if (cont == 2)
                {
                    zapolnitAziyaDictionary();
                }
                if (fx == 1)
                {
                    zapolnitYewropaDictionary();
                }
                
            
           
            button13.Visible = false;
        }



        private void FormLevel_Load(object sender, EventArgs e)
        {
            h = this.Size.Height;
            l = this.Size.Width;
            doall();
        }
        void doall()
        {
            zapolnitTextbox();
            zapolnitButtons();
            getCountryname();
            settboxs();
            setbuttons();
        }
        void zapolnitAziyaDictionary()
        {
            Dictionary<string, string> aziya = new Dictionary<string, string>();
            
            aziya["Eýran"] = "Tähran";
            int i=1;
            foreach(var di in aziya)
            {
                dictlvl[i] = di.Key;
                i++;
            }

            country = aziya;
        }
        void zapolnitYewropaDictionary()
        {
            Dictionary<string, string> y = new Dictionary<string, string>();
                y["Belarus"] = "MINSK";
                y["Moldowa"] = "KIŞINEW";
                y["Russiýa"] = "MOSKWA";
                y["Ukraina"] = "KIÝEW";
                y["Albaniýa"] = "TIRANA";
                y["Bolgariýa"] = "SOFIÝA";
                y["Bosniýa we Ger"] = "SARAÝEWO";
                y["Çehiýa"] = "PRAGA";
                y["Çernogoriýa"] = "PODGORIKA";
                y["Estoniýa"] = "TALLIN";
                y["Horwatiýa"] = "ZAGREB";
                y["Kosowo"] = "PRIŞTINA";
                y["Latwiýa"] = "RIGA";
            y["Litwa"] = "WILNÝUS";
            y["Makedoniýa"] = "SKOPÝE";
            y["Polşa"] = "WARŞAWA";
            y["Rumyniýa"] = "BUHAREST";
            y["Serbiýa"] = "BELGRAD";
            y["Slowakiýa"] = "BRATISLAWA";
            y["Sloweniýa"] = "LÝUBLÝANA";
            y["Wengriýa"] = "BUDAPEŞT";
            y["Awstriýa"] = "WENA";
            y["Belgiýa"] = "BRÝUSEL";
            y["Beýik Britaniýa"] = "LONDON";
            y["Fransiýa"] = "PARIŽ";
            y["Germaniýa"] = "BERLIN";
            y["Irlandiýa"] = "DUBLIN";
            y["Lihtenşteýn"] = "WADUS";
       
            y["Niderlandlar"] = "AMSTERDAM";
            y["Şweýsariýa"] = "BERN";
            y["Gresiýa"] = "AFINY";
            y["Ispaniýa"] = "MADRID";
            y["Italiýa"] = "RIM";
            y["Monako"] = "MONAKO";
            y["Portugaliýa"] = "LISSABON";
            y["Watikan"] = "WATIKAN";
            y["Daniýa"] = "KOPENGAGEN";
            y["Finlýandiýa"] = "HELSINKI";
            y["Islandiýa"] = "REÝKÝAWIK";
            y["Norwegiýa"] = "OSLO";
            y["Şwesiýa"] = "STOKGOLM";
               
            int i = 1;
            foreach (var di in y)
            {
                dictlvl[i] = di.Key;
                i++;
            }

            country = y;
        }
        void zapolnitTextbox()
        {
            tboxs[0] = textBox1;
            tboxs[1] = textBox2;
            tboxs[2] = textBox3;
            tboxs[3] = textBox4;
            tboxs[4] = textBox5;
            tboxs[5] = textBox6;
            tboxs[6] = textBox7;
            tboxs[7] = textBox8;
            tboxs[8] = textBox9;
            tboxs[9] = textBox10;
          

        }
        void zapolnitButtons()
        {
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;
            buttons[9] = button10;
            buttons[10] = button11;
            buttons[11] = button12;
        }
        void getCountryname()
        {
            try { countryname = dictlvl[level]; }
            catch (Exception e) { MessageBox.Show("Siz utdynyz"); DialogResult = DialogResult.OK; }
            length = countryname.Length;
            label1.Text = countryname;
            paytagt = country[countryname];
            length = paytagt.Length;
        }
        void settboxs()
        {
            for (int i = length; i <= 9; i++)
            {
                tboxs[i].Visible = false;
            }
        }
        void setbuttons()
        {
            string s = paytagt;
            char[] text = new char[12];
            for (int i = 0; i < length; i++)
            {
                text[i] = s[i];
            }
            Random rand = new Random();
            for (int i = length; i < 12; i++)
            {
                for (int j = 0; j < 999999; j++)
                {

                }
                int c = rand.Next('A', 'Z');
                text[i] = (char)c;

            }
            for (int i = 0; i < 200; i++)
            {
                
                int k1 = rand.Next(12);
                int k2 = 0;
                do
                {
                   
                    k2 = rand.Next(12);
                }
                while (k1 == k2);

                char temp;
                temp = text[k1];
                text[k1] = text[k2];
                text[k2] = temp;
            }
            for (int i = 0; i < 12; i++)
            {
                buttons[i].Text = text[i].ToString();
            }
            txt = text;
        }
        void settext(string t)
        {
           
            for (int i = 0; i < length; i++)
            {
                if (tboxs[i].Text == "")
                {
                    tboxs[i].Text = t;
                    if (proverkaispolny())
                    {
                        proverkaistrue();
                    }
                    return;
                }
            }
        }
        Boolean proverkaispolny()
        {
            for (int i=0; i<length; i++)
            {
                if (tboxs[i].Text=="")
                {
                    return false;
                }
            }
            return true;
        }
        void proverkaistrue()
        {
            for (int i=0; i<length; i++)
            {
                if (tboxs[i].Text!=paytagt[i].ToString())
                {
                    MessageBox.Show("Ýalňyş");
                    return;
                }
            }
            MessageBox.Show("Dogry!!");
            button13.Visible = true;
            button13.Focus();
            
        }
        void refreshAll()
        {
            foreach(TextBox box in tboxs)
            {
                box.Text = "";
                box.Visible = true;
            }
            foreach(Button bt in buttons)
            {
                bt.Visible = true;
            }
            button13.Visible = false;
        }
        void clrbox(int index)
        {
           if( tboxs[index].Text == "")
            {
                return;
            }
            foreach(Button b in buttons )
            {
                if (b.Visible==false && b.Text == tboxs[index].Text)
                {
                    b.Visible = true;
                    break;
                }
            }
            tboxs[index].Text = "";
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (proverkaispolny())
            {
                MessageBox.Show("Doly");
                return;
            }
            settext(button1.Text);
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (proverkaispolny())
            {
                MessageBox.Show("Doly");
                return;
            }
            settext(button2.Text);
            button2.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (proverkaispolny())
            {
                MessageBox.Show("Doly");
                return;
            }
            settext(button3.Text);
            button3.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (proverkaispolny())
            {
                MessageBox.Show("Doly");
                return;
            }
            settext(button4.Text);
            button4.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (proverkaispolny())
            {
                MessageBox.Show("Doly");
                return;
            }
            settext(button5.Text);
            button5.Visible = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (proverkaispolny())
            {
                MessageBox.Show("Doly");
                return;
            }
            settext(button6.Text);
            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (proverkaispolny())
            {
                MessageBox.Show("Doly");
                return;
            }
            settext(button7.Text);
            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (proverkaispolny())
            {
                MessageBox.Show("Doly");
                return;
            }
            settext(button8.Text);
            button8.Visible = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (proverkaispolny())
            {
                MessageBox.Show("Doly");
                return;
            }
            settext(button9.Text);
            button9.Visible = false;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (proverkaispolny())
            {
                MessageBox.Show("Doly");
                return;
            }
            settext(button10.Text);
            button10.Visible = false;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (proverkaispolny())
            {
                MessageBox.Show("Doly");
                return;
            }
            settext(button11.Text);
            button11.Visible = false;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (proverkaispolny())
            {
                MessageBox.Show("Doly");
                return;
            }
            settext(button12.Text);
            button12.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            level += 1;
            refreshAll();
            doall ();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

            clrbox(0);
        }
        private void textBox2_Click(object sender, EventArgs e)
        {

            clrbox(1);
        }
        private void textBox3_Click(object sender, EventArgs e)
        {

            clrbox(2);
        }
        private void textBox4_Click(object sender, EventArgs e)
        {

            clrbox(3);
        }
        private void textBox5_Click(object sender, EventArgs e)
        {

            clrbox(4);
        }
        private void textBox6_Click(object sender, EventArgs e)
        {

            clrbox(5);
        }
        private void textBox7_Click(object sender, EventArgs e)
        {

            clrbox(6);
        }
        private void textBox8_Click(object sender, EventArgs e)
        {

            clrbox(7);
        }
        private void textBox9_Click(object sender, EventArgs e)
        {

            clrbox(8);
        }
        private void textBox10_Click(object sender, EventArgs e)
        {

            clrbox(9);
        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(paytagt);
        }

        private void FormLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==8)
            {
                int j;
                for ( j=0; j<10; j++)
                {
                    if (tboxs[j].Text == "")
                        break;
                }
                if (j!=0)
                {
                    clrbox(j - 1);

                }
                return;
            }
            string key = e.KeyChar.ToString();
            key=key.ToUpper();
            int i = 0;
            foreach(Button but in buttons)
            {
                if (but.Text==key && but.Visible==true)
                {
                    break;
                }
                i++;
            }
            if (i == 12)
                return;

            if (proverkaispolny())
            {
                MessageBox.Show("Doly");
                return;
            }
            else
            {
                settext(key.ToString());
                buttons[i].Visible = false;
            }


        }

        private void FormLevel_SizeChanged(object sender, EventArgs e)
        {
            
            
            return;
        }
    }

    }
