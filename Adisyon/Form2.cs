using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Adisyon
{
    public partial class Form2 : Form
    {
        public List<string> ListBox1Data { get; set; }
        public List<string> ListBox2Data { get; set; }
        public List<string> ListBox3Data { get; set; }
        public List<string> ListBox4Data { get; set; }
        public List<string> ListBox5Data { get; set; }
        public string labeltext1 { get; set; }
        public string labeltext2 { get; set; }
        public string labeltext3 { get; set; }
        public string labeltext4 { get; set; }
        public string labeltext5 { get; set; }
        private int label12Value = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (ListBox1Data != null)
            {
                foreach (var item in ListBox1Data)
                {
                    listBox1.Items.Add(item);
                }
            }
            if (ListBox2Data != null)
            {
                foreach (var item in ListBox2Data)
                {
                    listBox2.Items.Add(item);
                }
            }
            if (ListBox3Data != null)
            {
                foreach (var item in ListBox3Data)
                {
                    listBox3.Items.Add(item);
                }
            }
            if (ListBox4Data != null)
            {
                foreach (var item in ListBox4Data)
                {
                    listBox4.Items.Add(item);
                }
            }
            if (ListBox5Data != null)
            {
                foreach (var item in ListBox5Data)
                {
                    listBox5.Items.Add(item);
                }
            }
            label2.Text = labeltext1;
            label3.Text = labeltext2;
            label5.Text = labeltext3;
            label7.Text = labeltext4;
            label9.Text = labeltext5;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int label2Value = 0;

            if (!string.IsNullOrEmpty(label2.Text) && int.TryParse(label2.Text, out label2Value))
            {
                label12Value += label2Value;

     
                label12.Text = label12Value.ToString();
            }
            listBox1.Items.Clear();
            listBox6.Items.Add("Masa 1 Ödendi");
            listBox6.Items.Add("Ödenme Tarihi :" + now.ToString("dd/MM/yyyy HH:mm:ss"));
            listBox6.Items.Add("Ödenen Tutar :" + label2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int label3Value = 0; 
            
            if (!string.IsNullOrEmpty(label3.Text) && int.TryParse(label3.Text, out label3Value))
            {
               
                label12Value += label3Value;

                label12.Text = label12Value.ToString();
            }
            listBox2.Items.Clear();
            listBox6.Items.Add("Masa 2 Ödendi");
            listBox6.Items.Add("Ödenme Tarihi :" + now.ToString("dd/MM/yyyy HH:mm:ss"));
            listBox6.Items.Add("Ödenen Tutar :" + label3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int label5Value = 0;

           
            if (!string.IsNullOrEmpty(label5.Text) && int.TryParse(label5.Text, out label5Value))
            {
               
                label12Value += label5Value;

              
                label12.Text = label12Value.ToString();
            }
            listBox3.Items.Clear();
            listBox6.Items.Add("Masa 3 Ödendi");
            listBox6.Items.Add("Ödenme Tarihi :" + now.ToString("dd/MM/yyyy HH:mm:ss"));
            listBox6.Items.Add("Ödenen Tutar :" + label5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int label7Value = 0; 

         
            if (!string.IsNullOrEmpty(label7.Text) && int.TryParse(label7.Text, out label7Value))
            {
                
                label12Value += label7Value;

               
                label12.Text = label12Value.ToString();
            }
            listBox4.Items.Clear();
            listBox6.Items.Add("Masa 4 Ödendi");
            listBox6.Items.Add("Ödenme Tarihi :" + now.ToString("dd/MM/yyyy HH:mm:ss"));
            listBox6.Items.Add("Ödenen Tutar :" + label7.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int label9Value = 0; 

            
            if (!string.IsNullOrEmpty(label9.Text) && int.TryParse(label9.Text, out label9Value))
            {
               
                label12Value += label9Value;

               
                label12.Text = label12Value.ToString();
            }
            listBox5.Items.Clear();
            listBox6.Items.Add("Masa 5 Ödendi");
            listBox6.Items.Add("Ödenme Tarihi :" + now.ToString("dd/MM/yyyy HH:mm:ss"));
            listBox6.Items.Add("Ödenen Tutar :" + label5.Text);
        }
        public void EnableForm2Button()
        {
         

            {
                button1.Enabled = true; 
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            {
                form1.Show();
                this.Hide();
            }
        }
    }
}
