namespace Adisyon
{
    public partial class Form1 : Form
    {
        �r�nler �skender = new �r�nler();
        �r�nler D�ner = new �r�nler();
        �r�nler Kebap = new �r�nler();
        �r�nler Ayran = new �r�nler();
        �r�nler Kola = new �r�nler();
        �r�nler Su = new �r�nler();
        �r�nler S�tla� = new �r�nler();
        �r�nler Puding = new �r�nler();
        �r�nler Tiramisu = new �r�nler();
        private int toplamTutar = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void �r�n()
        {
            �skender.Fiyat = 110;
            Kebap.Fiyat = 100;
            D�ner.Fiyat = 65;
            Ayran.Fiyat = 10;
            Kola.Fiyat = 20;
            Su.Fiyat = 5;
            S�tla�.Fiyat = 45;
            Puding.Fiyat = 30;
            Tiramisu.Fiyat = 60;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            �r�n();
            int textBox1Text = int.Parse(textBox1.Text);
            string comboBox1SelectedValue = comboBox1.SelectedItem.ToString();
            int toplamFiyat = 0;
            DateTime now = DateTime.Now;


            if (comboBox1SelectedValue == "�skender")
            {
                toplamFiyat = �skender.Fiyat * textBox1Text;
                listBox1.Items.Add("�skenderin Eklenme Saati :" + now.ToString("HH:mm"));
                listBox1.Items.Add("�skender Adedi :" + textBox1Text);
                listBox1.Items.Add("�skender Fiyat� :" + toplamFiyat + "tl");
            }
            else if (comboBox1SelectedValue == "D�ner")
            {
                toplamFiyat = D�ner.Fiyat * textBox1Text;
                listBox1.Items.Add("D�nerin Eklenme Saati :" + now.ToString("HH:mm"));
                listBox1.Items.Add("D�ner Adedi :" + textBox1Text);
                listBox1.Items.Add("D�ner Fiyat� :" + toplamFiyat + "tl");
            }
            else if (comboBox1SelectedValue == "Kebap")
            {
                toplamFiyat = Kebap.Fiyat * textBox1Text;
                listBox1.Items.Add("Kebab�n Eklenme Saati :" + now.ToString("HH:mm"));
                listBox1.Items.Add("Kebap Adedi :" + textBox1Text);
                listBox1.Items.Add("Kebap Fiyat� :" + toplamFiyat + "tl");
            }
            toplamTutar += toplamFiyat;
            label12.Text = toplamTutar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            �r�n();
            DateTime now = DateTime.Now;
            int textBox2Text = int.Parse(textBox2.Text);
            string comboBox2SelectedValue = comboBox2.SelectedItem.ToString();
            int toplamFiyat = 0;

            if (comboBox2SelectedValue == "Ayran")
            {
                toplamFiyat = Ayran.Fiyat * textBox2Text;
                listBox1.Items.Add("Ayran Adedi :" + textBox2Text);
                listBox1.Items.Add("Ayran Fiyat� :" + toplamFiyat + "tl");
                listBox1.Items.Add("Ayran�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox2SelectedValue == "Kola")
            {
                toplamFiyat = Kola.Fiyat * textBox2Text;
                listBox1.Items.Add("Kola Adedi :" + textBox2Text);
                listBox1.Items.Add("Kola Fiyat� :" + toplamFiyat + "tl");
                listBox1.Items.Add("Kolan�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox2SelectedValue == "Su")
            {
                toplamFiyat = Su.Fiyat * textBox2Text;
                listBox1.Items.Add("Su Adedi :" + textBox2Text);
                listBox1.Items.Add("Su Fiyat� :" + toplamFiyat + "tl");
                listBox1.Items.Add("Suyun Eklenme Saati :" + now.ToString("HH:mm"));
            }
            toplamTutar += toplamFiyat;
            label12.Text = toplamTutar.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            �r�n();
            DateTime now = DateTime.Now;
            int textBox3Text = int.Parse(textBox3.Text);
            string comboBox3SelectedValue = comboBox3.SelectedItem.ToString();
            int toplamFiyat = 0;

            if (comboBox3SelectedValue == "S�tla�")
            {
                toplamFiyat = S�tla�.Fiyat * textBox3Text;
                listBox1.Items.Add("S�tla� Adedi :" + textBox3Text);
                listBox1.Items.Add("S�tla� Fiyat� :" + toplamFiyat + "tl");
                listBox1.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox3SelectedValue == "Puding")
            {
                toplamFiyat = Puding.Fiyat * textBox3Text;
                listBox1.Items.Add("Puding Adedi :" + textBox3Text);
                listBox1.Items.Add("Puding Fiyat� :" + toplamFiyat + "tl");
                listBox1.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox3SelectedValue == "Tiramisu")
            {
                toplamFiyat = Tiramisu.Fiyat * textBox3Text;
                listBox1.Items.Add("Tiramisu Adedi :" + textBox3Text);
                listBox1.Items.Add("Tiramisu Fiyat� :" + toplamFiyat + "tl");
                listBox1.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            toplamTutar += toplamFiyat;
            label12.Text = toplamTutar.ToString();

        }
        private void button6_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string secilenYemek = comboBox4.SelectedItem.ToString();
            listBox1.Items.Add("Yeme�in Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox1.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
            if (secilenYemek == "�skender")
            {
                toplamTutar -= �skender.Fiyat;
            }
            else if (secilenYemek == "Kebap")
            {
                toplamTutar -= Kebap.Fiyat;
            }
            else if (secilenYemek == "D�ner")
            {
                toplamTutar -= D�ner.Fiyat;
            }
            label12.Text = toplamTutar.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            �r�n();
            DateTime now = DateTime.Now;
            string secilenYemek = comboBox5.SelectedItem.ToString();
            listBox1.Items.Add("��ece�in Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox1.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox1.Items.RemoveAt(i);

                }
            }
            if (secilenYemek == "Ayran")
            {
                toplamTutar -= Ayran.Fiyat;
            }
            else if (secilenYemek == "Kola")
            {
                toplamTutar -= Kola.Fiyat;
            }
            else if (secilenYemek == "Su")
            {
                toplamTutar -= Su.Fiyat;
            }
            label12.Text = toplamTutar.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            �r�n();
            DateTime now = DateTime.Now;
            string secilentatl� = comboBox6.SelectedItem.ToString();
            listBox1.Items.Add("Tatl�n�n Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox1.Items[i].ToString();
                if (currentItem.Contains(secilentatl�))
                {

                    listBox1.Items.RemoveAt(i);

                }
            }
            if (secilentatl� == "S�tla�")
            {
                toplamTutar -= S�tla�.Fiyat;
            }
            else if (secilentatl� == "Puding")
            {
                toplamTutar -= Puding.Fiyat;
            }
            else if (secilentatl� == "Tiramisu")
            {
                toplamTutar -= Tiramisu.Fiyat;
            }
            label12.Text = toplamTutar.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            �r�n();
            int textBox1Text = int.Parse(textBox6.Text);
            string comboBox1SelectedValue = comboBox12.SelectedItem.ToString();
            int toplamFiyat = 0;
            DateTime now = DateTime.Now;


            if (comboBox1SelectedValue == "�skender")
            {
                toplamFiyat = �skender.Fiyat * textBox1Text;
                listBox2.Items.Add("�skenderin Eklenme Saati :" + now.ToString("HH:mm"));
                listBox2.Items.Add("�skender Adedi :" + textBox1Text);
                listBox2.Items.Add("�skender Fiyat� :" + toplamFiyat + "tl");
            }
            else if (comboBox1SelectedValue == "D�ner")
            {
                toplamFiyat = D�ner.Fiyat * textBox1Text;
                listBox2.Items.Add("D�nerin Eklenme Saati :" + now.ToString("HH:mm"));
                listBox2.Items.Add("D�ner Adedi :" + textBox1Text);
                listBox2.Items.Add("D�ner Fiyat� :" + toplamFiyat + "tl");
            }
            else if (comboBox1SelectedValue == "Kebap")
            {
                toplamFiyat = Kebap.Fiyat * textBox1Text;
                listBox2.Items.Add("Kebab�n Eklenme Saati :" + now.ToString("HH:mm"));
                listBox2.Items.Add("Kebap Adedi :" + textBox1Text);
                listBox2.Items.Add("Kebap Fiyat� :" + toplamFiyat + "tl");
            }
            toplamTutar += toplamFiyat;
            label13.Text = toplamTutar.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            �r�n();
            DateTime now = DateTime.Now;
            int textBox2Text = int.Parse(textBox5.Text);
            string comboBox2SelectedValue = comboBox11.SelectedItem.ToString();
            int toplamFiyat = 0;

            if (comboBox2SelectedValue == "Ayran")
            {
                toplamFiyat = Ayran.Fiyat * textBox2Text;
                listBox2.Items.Add("Ayran Adedi :" + textBox2Text);
                listBox2.Items.Add("Ayran Fiyat� :" + toplamFiyat + "tl");
                listBox2.Items.Add("Ayran�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox2SelectedValue == "Kola")
            {
                toplamFiyat = Kola.Fiyat * textBox2Text;
                listBox2.Items.Add("Kola Adedi :" + textBox2Text);
                listBox2.Items.Add("Kola Fiyat� :" + toplamFiyat + "tl");
                listBox2.Items.Add("Kolan�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox2SelectedValue == "Su")
            {
                toplamFiyat = Su.Fiyat * textBox2Text;
                listBox2.Items.Add("Su Adedi :" + textBox2Text);
                listBox2.Items.Add("Su Fiyat� :" + toplamFiyat + "tl");
                listBox2.Items.Add("Suyun Eklenme Saati :" + now.ToString("HH:mm"));
            }
            toplamTutar += toplamFiyat;
            label13.Text = toplamTutar.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            �r�n();
            DateTime now = DateTime.Now;
            int textBox3Text = int.Parse(textBox4.Text);
            string comboBox3SelectedValue = comboBox10.SelectedItem.ToString();
            int toplamFiyat = 0;

            if (comboBox3SelectedValue == "S�tla�")
            {
                toplamFiyat = S�tla�.Fiyat * textBox3Text;
                listBox2.Items.Add("S�tla� Adedi :" + textBox3Text);
                listBox2.Items.Add("S�tla� Fiyat� :" + toplamFiyat + "tl");
                listBox2.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox3SelectedValue == "Puding")
            {
                toplamFiyat = Puding.Fiyat * textBox3Text;
                listBox2.Items.Add("Puding Adedi :" + textBox3Text);
                listBox2.Items.Add("Puding Fiyat� :" + toplamFiyat + "tl");
                listBox2.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox3SelectedValue == "Tiramisu")
            {
                toplamFiyat = Tiramisu.Fiyat * textBox3Text;
                listBox2.Items.Add("Tiramisu Adedi :" + textBox3Text);
                listBox2.Items.Add("Tiramisu Fiyat� :" + toplamFiyat + "tl");
                listBox2.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            toplamTutar += toplamFiyat;
            label13.Text = toplamTutar.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;
            string secilenYemek = comboBox9.SelectedItem.ToString();
            listBox2.Items.Add("Yeme�in Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox2.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox2.Items.RemoveAt(i);
                }
            }
            if (secilenYemek == "�skender")
            {
                toplamTutar -= �skender.Fiyat;
            }
            else if (secilenYemek == "Kebap")
            {
                toplamTutar -= Kebap.Fiyat;
            }
            else if (secilenYemek == "D�ner")
            {
                toplamTutar -= D�ner.Fiyat;
            }
            label13.Text = toplamTutar.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string secilenYemek = comboBox8.SelectedItem.ToString();
            listBox2.Items.Add("��ece�in Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox2.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox2.Items.RemoveAt(i);
                }
            }
            if (secilenYemek == "Ayran")
            {
                toplamTutar -= Ayran.Fiyat;
            }
            else if (secilenYemek == "Kola")
            {
                toplamTutar -= Kola.Fiyat;
            }
            else if (secilenYemek == "Su")
            {
                toplamTutar -= Su.Fiyat;
            }
            label13.Text = toplamTutar.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string secilenYemek = comboBox7.SelectedItem.ToString();
            listBox2.Items.Add("Tatl�n�n Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox2.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox2.Items.RemoveAt(i);
                }
            }
            if (secilenYemek == "S�tla�")
            {
                toplamTutar -= S�tla�.Fiyat;
            }
            else if (secilenYemek == "Puding")
            {
                toplamTutar -= Puding.Fiyat;
            }
            else if (secilenYemek == "Tiramisu")
            {
                toplamTutar -= Tiramisu.Fiyat;
            }
            label13.Text = toplamTutar.ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            �r�n();
            int textBox1Text = int.Parse(textBox9.Text);
            string comboBox1SelectedValue = comboBox18.SelectedItem.ToString();
            int toplamFiyat = 0;
            DateTime now = DateTime.Now;


            if (comboBox1SelectedValue == "�skender")
            {
                toplamFiyat = �skender.Fiyat * textBox1Text;
                listBox3.Items.Add("�skenderin Eklenme Saati :" + now.ToString("HH:mm"));
                listBox3.Items.Add("�skender Adedi :" + textBox1Text);
                listBox3.Items.Add("�skender Fiyat� :" + toplamFiyat + "tl");
            }
            else if (comboBox1SelectedValue == "D�ner")
            {
                toplamFiyat = D�ner.Fiyat * textBox1Text;
                listBox3.Items.Add("D�nerin Eklenme Saati :" + now.ToString("HH:mm"));
                listBox3.Items.Add("D�ner Adedi :" + textBox1Text);
                listBox3.Items.Add("D�ner Fiyat� :" + toplamFiyat + "tl");
            }
            else if (comboBox1SelectedValue == "Kebap")
            {
                toplamFiyat = Kebap.Fiyat * textBox1Text;
                listBox3.Items.Add("Kebab�n Eklenme Saati :" + now.ToString("HH:mm"));
                listBox3.Items.Add("Kebap Adedi :" + textBox1Text);
                listBox3.Items.Add("Kebap Fiyat� :" + toplamFiyat + "tl");
            }
            toplamTutar += toplamFiyat;
            label15.Text = toplamTutar.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            �r�n();
            DateTime now = DateTime.Now;
            int textBox2Text = int.Parse(textBox8.Text);
            string comboBox2SelectedValue = comboBox17.SelectedItem.ToString();
            int toplamFiyat = 0;

            if (comboBox2SelectedValue == "Ayran")
            {
                toplamFiyat = Ayran.Fiyat * textBox2Text;
                listBox3.Items.Add("Ayran Adedi :" + textBox2Text);
                listBox3.Items.Add("Ayran Fiyat� :" + toplamFiyat + "tl");
                listBox3.Items.Add("Ayran�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox2SelectedValue == "Kola")
            {
                toplamFiyat = Kola.Fiyat * textBox2Text;
                listBox3.Items.Add("Kola Adedi :" + textBox2Text);
                listBox3.Items.Add("Kola Fiyat� :" + toplamFiyat + "tl");
                listBox3.Items.Add("Kolan�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox2SelectedValue == "Su")
            {
                toplamFiyat = Su.Fiyat * textBox2Text;
                listBox3.Items.Add("Su Adedi :" + textBox2Text);
                listBox3.Items.Add("Su Fiyat� :" + toplamFiyat + "tl");
                listBox3.Items.Add("Suyun Eklenme Saati :" + now.ToString("HH:mm"));
            }
            toplamTutar += toplamFiyat;
            label15.Text = toplamTutar.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            �r�n();
            DateTime now = DateTime.Now;
            int textBox3Text = int.Parse(textBox7.Text);
            string comboBox3SelectedValue = comboBox16.SelectedItem.ToString();
            int toplamFiyat = 0;

            if (comboBox3SelectedValue == "S�tla�")
            {
                toplamFiyat = S�tla�.Fiyat * textBox3Text;
                listBox3.Items.Add("S�tla� Adedi :" + textBox3Text);
                listBox3.Items.Add("S�tla� Fiyat� :" + toplamFiyat + "tl");
                listBox3.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox3SelectedValue == "Puding")
            {
                toplamFiyat = Puding.Fiyat * textBox3Text;
                listBox3.Items.Add("Puding Adedi :" + textBox3Text);
                listBox3.Items.Add("Puding Fiyat� :" + toplamFiyat + "tl");
                listBox3.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox3SelectedValue == "Tiramisu")
            {
                toplamFiyat = Tiramisu.Fiyat * textBox3Text;
                listBox3.Items.Add("Tiramisu Adedi :" + textBox3Text);
                listBox3.Items.Add("Tiramisu Fiyat� :" + toplamFiyat + "tl");
                listBox3.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            toplamTutar += toplamFiyat;
            label15.Text = toplamTutar.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string secilenYemek = comboBox15.SelectedItem.ToString();
            listBox3.Items.Add("Yeme�in Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox3.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox3.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox3.Items.RemoveAt(i);
                }
            }
            if (secilenYemek == "�skender")
            {
                toplamTutar -= �skender.Fiyat;
            }
            else if (secilenYemek == "Kebap")
            {
                toplamTutar -= Kebap.Fiyat;
            }
            else if (secilenYemek == "D�ner")
            {
                toplamTutar -= D�ner.Fiyat;
            }
            label15.Text = toplamTutar.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string secilenYemek = comboBox14.SelectedItem.ToString();
            listBox3.Items.Add("��ece�in Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox3.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox3.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox3.Items.RemoveAt(i);
                }
            }
            if (secilenYemek == "Ayran")
            {
                toplamTutar -= Ayran.Fiyat;
            }
            else if (secilenYemek == "Kola")
            {
                toplamTutar -= Kola.Fiyat;
            }
            else if (secilenYemek == "Su")
            {
                toplamTutar -= Su.Fiyat;
            }
            label15.Text = toplamTutar.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string secilenYemek = comboBox13.SelectedItem.ToString();
            listBox3.Items.Add("Tatl�n�n Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox3.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox3.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox3.Items.RemoveAt(i);
                }
            }
            if (secilenYemek == "S�tla�")
            {
                toplamTutar -= S�tla�.Fiyat;
            }
            else if (secilenYemek == "Puding")
            {
                toplamTutar -= Puding.Fiyat;
            }
            else if (secilenYemek == "Tiramisu")
            {
                toplamTutar -= Tiramisu.Fiyat;
            }
            label15.Text = toplamTutar.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            �r�n();
            int textBox1Text = int.Parse(textBox12.Text);
            string comboBox1SelectedValue = comboBox24.SelectedItem.ToString();
            int toplamFiyat = 0;
            DateTime now = DateTime.Now;


            if (comboBox1SelectedValue == "�skender")
            {
                toplamFiyat = �skender.Fiyat * textBox1Text;
                listBox4.Items.Add("�skenderin Eklenme Saati :" + now.ToString("HH:mm"));
                listBox4.Items.Add("�skender Adedi :" + textBox1Text);
                listBox4.Items.Add("�skender Fiyat� :" + toplamFiyat + "tl");
            }
            else if (comboBox1SelectedValue == "D�ner")
            {
                toplamFiyat = D�ner.Fiyat * textBox1Text;
                listBox4.Items.Add("D�nerin Eklenme Saati :" + now.ToString("HH:mm"));
                listBox4.Items.Add("D�ner Adedi :" + textBox1Text);
                listBox4.Items.Add("D�ner Fiyat� :" + toplamFiyat + "tl");
            }
            else if (comboBox1SelectedValue == "Kebap")
            {
                toplamFiyat = Kebap.Fiyat * textBox1Text;
                listBox4.Items.Add("Kebab�n Eklenme Saati :" + now.ToString("HH:mm"));
                listBox4.Items.Add("Kebap Adedi :" + textBox1Text);
                listBox4.Items.Add("Kebap Fiyat� :" + toplamFiyat + "tl");
            }
            toplamTutar += toplamFiyat;
            label17.Text = toplamTutar.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            �r�n();
            DateTime now = DateTime.Now;
            int textBox2Text = int.Parse(textBox11.Text);
            string comboBox2SelectedValue = comboBox23.SelectedItem.ToString();
            int toplamFiyat = 0;

            if (comboBox2SelectedValue == "Ayran")
            {
                toplamFiyat = Ayran.Fiyat * textBox2Text;
                listBox4.Items.Add("Ayran Adedi :" + textBox2Text);
                listBox4.Items.Add("Ayran Fiyat� :" + toplamFiyat + "tl");
                listBox4.Items.Add("Ayran�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox2SelectedValue == "Kola")
            {
                toplamFiyat = Kola.Fiyat * textBox2Text;
                listBox4.Items.Add("Kola Adedi :" + textBox2Text);
                listBox4.Items.Add("Kola Fiyat� :" + toplamFiyat + "tl");
                listBox4.Items.Add("Kolan�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox2SelectedValue == "Su")
            {
                toplamFiyat = Su.Fiyat * textBox2Text;
                listBox4.Items.Add("Su Adedi :" + textBox2Text);
                listBox4.Items.Add("Su Fiyat� :" + toplamFiyat + "tl");
                listBox4.Items.Add("Suyun Eklenme Saati :" + now.ToString("HH:mm"));
            }
            toplamTutar += toplamFiyat;
            label17.Text = toplamTutar.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            �r�n();
            DateTime now = DateTime.Now;
            int textBox3Text = int.Parse(textBox10.Text);
            string comboBox3SelectedValue = comboBox22.SelectedItem.ToString();
            int toplamFiyat = 0;

            if (comboBox3SelectedValue == "S�tla�")
            {
                toplamFiyat = S�tla�.Fiyat * textBox3Text;
                listBox4.Items.Add("S�tla� Adedi :" + textBox3Text);
                listBox4.Items.Add("S�tla� Fiyat� :" + toplamFiyat + "tl");
                listBox4.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox3SelectedValue == "Puding")
            {
                toplamFiyat = Puding.Fiyat * textBox3Text;
                listBox4.Items.Add("Puding Adedi :" + textBox3Text);
                listBox4.Items.Add("Puding Fiyat� :" + toplamFiyat + "tl");
                listBox4.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox3SelectedValue == "Tiramisu")
            {
                toplamFiyat = Tiramisu.Fiyat * textBox3Text;
                listBox4.Items.Add("Tiramisu Adedi :" + textBox3Text);
                listBox4.Items.Add("Tiramisu Fiyat� :" + toplamFiyat + "tl");
                listBox4.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            toplamTutar += toplamFiyat;
            label17.Text = toplamTutar.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string secilenYemek = comboBox21.SelectedItem.ToString();
            listBox4.Items.Add("Yeme�in Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox4.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox4.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox4.Items.RemoveAt(i);
                }
            }
            if (secilenYemek == "�skender")
            {
                toplamTutar -= �skender.Fiyat;
            }
            else if (secilenYemek == "Kebap")
            {
                toplamTutar -= Kebap.Fiyat;
            }
            else if (secilenYemek == "D�ner")
            {
                toplamTutar -= D�ner.Fiyat;
            }
            label17.Text = toplamTutar.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string secilenYemek = comboBox20.SelectedItem.ToString();
            listBox4.Items.Add("��ece�in Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox4.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox4.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox4.Items.RemoveAt(i);
                }
            }
            if (secilenYemek == "Ayran")
            {
                toplamTutar -= Ayran.Fiyat;
            }
            else if (secilenYemek == "Kola")
            {
                toplamTutar -= Kola.Fiyat;
            }
            else if (secilenYemek == "Su")
            {
                toplamTutar -= Su.Fiyat;
            }
            label17.Text = toplamTutar.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string secilenYemek = comboBox19.SelectedItem.ToString();
            listBox4.Items.Add("Tatl�n�n Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox4.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox4.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox4.Items.RemoveAt(i);
                }
            }
            if (secilenYemek == "S�tla�")
            {
                toplamTutar -= S�tla�.Fiyat;
            }
            else if (secilenYemek == "Puding")
            {
                toplamTutar -= Puding.Fiyat;
            }
            else if (secilenYemek == "Tiramisu")
            {
                toplamTutar -= Tiramisu.Fiyat;
            }
            label17.Text = toplamTutar.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            �r�n();
            int textBox1Text = int.Parse(textBox15.Text);
            string comboBox1SelectedValue = comboBox30.SelectedItem.ToString();
            int toplamFiyat = 0;
            DateTime now = DateTime.Now;


            if (comboBox1SelectedValue == "�skender")
            {
                toplamFiyat = �skender.Fiyat * textBox1Text;
                listBox5.Items.Add("�skenderin Eklenme Saati :" + now.ToString("HH:mm"));
                listBox5.Items.Add("�skender Adedi :" + textBox1Text);
                listBox5.Items.Add("�skender Fiyat� :" + toplamFiyat + "tl");
            }
            else if (comboBox1SelectedValue == "D�ner")
            {
                toplamFiyat = D�ner.Fiyat * textBox1Text;
                listBox5.Items.Add("D�nerin Eklenme Saati :" + now.ToString("HH:mm"));
                listBox5.Items.Add("D�ner Adedi :" + textBox1Text);
                listBox5.Items.Add("D�ner Fiyat� :" + toplamFiyat + "tl");
            }
            else if (comboBox1SelectedValue == "Kebap")
            {
                toplamFiyat = Kebap.Fiyat * textBox1Text;
                listBox5.Items.Add("Kebab�n Eklenme Saati :" + now.ToString("HH:mm"));
                listBox5.Items.Add("Kebap Adedi :" + textBox1Text);
                listBox5.Items.Add("Kebap Fiyat� :" + toplamFiyat + "tl");
            }
            toplamTutar += toplamFiyat;
            label19.Text = toplamTutar.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            �r�n();
            DateTime now = DateTime.Now;
            int textBox2Text = int.Parse(textBox14.Text);
            string comboBox2SelectedValue = comboBox29.SelectedItem.ToString();
            int toplamFiyat = 0;

            if (comboBox2SelectedValue == "Ayran")
            {
                toplamFiyat = Ayran.Fiyat * textBox2Text;
                listBox5.Items.Add("Ayran Adedi :" + textBox2Text);
                listBox5.Items.Add("Ayran Fiyat� :" + toplamFiyat + "tl");
                listBox5.Items.Add("Ayran�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox2SelectedValue == "Kola")
            {
                toplamFiyat = Kola.Fiyat * textBox2Text;
                listBox5.Items.Add("Kola Adedi :" + textBox2Text);
                listBox5.Items.Add("Kola Fiyat� :" + toplamFiyat + "tl");
                listBox5.Items.Add("Kolan�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox2SelectedValue == "Su")
            {
                toplamFiyat = Su.Fiyat * textBox2Text;
                listBox5.Items.Add("Su Adedi :" + textBox2Text);
                listBox5.Items.Add("Su Fiyat� :" + toplamFiyat + "tl");
                listBox5.Items.Add("Suyun Eklenme Saati :" + now.ToString("HH:mm"));
            }
            toplamTutar += toplamFiyat;
            label19.Text = toplamTutar.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            �r�n();
            DateTime now = DateTime.Now;
            int textBox3Text = int.Parse(textBox13.Text);
            string comboBox3SelectedValue = comboBox28.SelectedItem.ToString();
            int toplamFiyat = 0;

            if (comboBox3SelectedValue == "S�tla�")
            {
                toplamFiyat = S�tla�.Fiyat * textBox3Text;
                listBox5.Items.Add("S�tla� Adedi :" + textBox3Text);
                listBox5.Items.Add("S�tla� Fiyat� :" + toplamFiyat + "tl");
                listBox5.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox3SelectedValue == "Puding")
            {
                toplamFiyat = Puding.Fiyat * textBox3Text;
                listBox5.Items.Add("Puding Adedi :" + textBox3Text);
                listBox5.Items.Add("Puding Fiyat� :" + toplamFiyat + "tl");
                listBox5.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            else if (comboBox3SelectedValue == "Tiramisu")
            {
                toplamFiyat = Tiramisu.Fiyat * textBox3Text;
                listBox5.Items.Add("Tiramisu Adedi :" + textBox3Text);
                listBox5.Items.Add("Tiramisu Fiyat� :" + toplamFiyat + "tl");
                listBox5.Items.Add("Tatl�n�n Eklenme Saati :" + now.ToString("HH:mm"));
            }
            toplamTutar += toplamFiyat;
            label19.Text = "Toplam: " + toplamTutar.ToString() + "tl";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string secilenYemek = comboBox27.SelectedItem.ToString();
            listBox5.Items.Add("Yeme�in Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox5.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox5.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox5.Items.RemoveAt(i);
                }
            }
            if (secilenYemek == "�skender")
            {
                toplamTutar -= �skender.Fiyat;
            }
            else if (secilenYemek == "Kebap")
            {
                toplamTutar -= Kebap.Fiyat;
            }
            else if (secilenYemek == "D�ner")
            {
                toplamTutar -= D�ner.Fiyat;
            }
            label19.Text = toplamTutar.ToString();

        }

        private void button26_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string secilenYemek = comboBox26.SelectedItem.ToString();
            listBox5.Items.Add("��ece�in Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox5.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox4.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox5.Items.RemoveAt(i);
                }
            }
            if (secilenYemek == "Ayran")
            {
                toplamTutar -= Ayran.Fiyat;
            }
            else if (secilenYemek == "Kola")
            {
                toplamTutar -= Kola.Fiyat;
            }
            else if (secilenYemek == "Su")
            {
                toplamTutar -= Su.Fiyat;
            }
            label19.Text = toplamTutar.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string secilenYemek = comboBox25.SelectedItem.ToString();
            listBox5.Items.Add("Tatl�n�n Silinme Saati :" + now.ToString("HH:mm"));
            for (int i = listBox5.Items.Count - 1; i >= 0; i--)
            {
                string currentItem = listBox5.Items[i].ToString();
                if (currentItem.Contains(secilenYemek))
                {
                    listBox5.Items.RemoveAt(i);
                }
            }
            if (secilenYemek == "S�tla�")
            {
                toplamTutar -= S�tla�.Fiyat;
            }
            else if (secilenYemek == "Puding")
            {
                toplamTutar -= Puding.Fiyat;
            }
            else if (secilenYemek == "Tiramisu")
            {
                toplamTutar -= Tiramisu.Fiyat;
            }
            label19.Text = toplamTutar.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ListBox1Data = listBox1.Items.Cast<string>().ToList();
            form2.ListBox2Data = listBox2.Items.Cast<string>().ToList();
            form2.ListBox3Data = listBox3.Items.Cast<string>().ToList();
            form2.ListBox4Data = listBox4.Items.Cast<string>().ToList();
            form2.ListBox5Data = listBox5.Items.Cast<string>().ToList();
            form2.labeltext1 = label12.Text;
            form2.labeltext2 = label13.Text;
            form2.labeltext3 = label15.Text;
            form2.labeltext4 = label17.Text;
            form2.labeltext5 = label19.Text;

            if (!checkBox1.Checked)
            {

                form2.button1.Visible = false;
                form2.Show();
            }

            if (!checkBox2.Checked)
            {
                form2.button2.Visible = false;
                form2.Show();


            }
            if (!checkBox3.Checked)
            {
                form2.button3.Visible = false;
                form2.Show();


            }
            if (!checkBox4.Checked)
            {
                form2.button4.Visible = false;
                form2.Show();


            }
            if (!checkBox5.Checked)
            {
                form2.button5.Visible = false;
                form2.Show();

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }
    }
}
