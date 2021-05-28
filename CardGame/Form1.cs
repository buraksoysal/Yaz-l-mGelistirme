using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Form1 : Form
    {
        Button card1 = new Button();
        Button card2 = new Button();
        List<Button> btnList = new List<Button>();
        List<int> randomList = new List<int>();
        public Random rnd = new Random();
        int m, s;

        System.Timers.Timer timer;
        Form1 game;

        int MyNumber = 0;
        int count = 0;
        int i;
        int j;
        int points = 0;
        int increase = 100;
        bool isFirst = true;

        SoundPlayer audio1 = new SoundPlayer(@"C:\Users\bsoysal\Desktop\audio1.wav");
        SoundPlayer audio2 = new SoundPlayer(@"C:\Users\bsoysal\Desktop\audio2.wav");


        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<string> CardObject, int i, int j, int rank)
        {
            InitializeComponent();
            this.btnHard.Click += new System.EventHandler(this.btnReload);
            this.btnMid.Click += new System.EventHandler(this.btnReload);
            this.btnEzz.Click += new System.EventHandler(this.btnReload);

            SetStartStatus(rank);

            int TextBoxCount = i * j;
            int pointX = 80;
            int pointY = 0;
            int index = 0;

            panel1.Controls.Clear();
            
            panel1.Location = new Point(
                this.Width / 2 - panel1.Size.Width / 2,
                this.Height / 2 - panel1.Size.Height / 2);
            
            panel1.Anchor = AnchorStyles.None; 
            
            NewNumber(TextBoxCount);

            for (int x = 0; x < j; x++)
            {
                pointX = panel1.Size.Width / 4;
                pointY += 70;

                for (int y = 0; y < i; y++)
                {
                    Button t = new Button();

                    if (index == TextBoxCount/2)
                    {
                        randomList.Clear();
                        NewNumber(TextBoxCount);
                        index = 0;
                    }

                    t.Text = CardObject[randomList[index]];//harfler[i].ToString();
                    t.Name = t.Text.ToUpper()/* + i + j*/;
                    t.Location = new Point(pointX, pointY);
                    t.Width = 65;
                    t.Height = 65;
                    //t.TextAlign = HorizontalAlignment.Center;
                    //t.CharacterCasing = CharacterCasing.Upper;
                    panel1.Controls.Add(t);
                    panel1.Show();
                    pointX += 70;
                    index++;
                    t.ForeColor = System.Drawing.SystemColors.ButtonFace;
                    t.BackColor = System.Drawing.SystemColors.ButtonFace;
                    //t.Click += new System.EventHandler(this.t_Click);
                    t.Click += delegate (object sender, EventArgs e) { t_Click(sender, e, t); };

                    btnList.Add(t);
                }
            }

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
            m = 0;
            s = 10;
            timer.Start();
        }
        private void SetStartStatus(int rank) // stat'tan oyun durumu alınır, case
        {
            Countdown.Visible = true;
            lblPoints.Visible = true;
            switch (rank)
            {
                case 1:
                    btnMid.Visible = false;
                    btnHard.Visible = false;
                    break;
                case 2:
                    btnEzz.Visible = false;
                    btnHard.Visible = false;
                    break;
                case 3:
                    btnEzz.Visible = false;
                    btnMid.Visible = false;
                    break;
                default: break;
            }
            lblDifficulty.Visible = false;
            panel1.Visible = true;
        }
        private void btnReload(object sender, EventArgs e)
        {
            timer.Dispose();
            game.Close();
            this.Visible = false;
            Form1 MainMenu = new Form1();
            MainMenu.Show();
        }
        
        private void btnHard_Click(object sender, EventArgs e)
        {
            this.Hide();

            List<string> CardObejct = new List<string>();

            CardObejct.Add("kedi");
            CardObejct.Add("kopek");
            CardObejct.Add("kus");
            CardObejct.Add("balik");
            CardObejct.Add("yilan");
            CardObejct.Add("dinozor");
            CardObejct.Add("ejderha");
            CardObejct.Add("fil");
            CardObejct.Add("ayi");
            CardObejct.Add("at");
            
            i = 5;
            j = 4;
            
            game = new Form1(CardObejct, i, j, 3);
            game.Show();
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            this.Hide();

            List<string> CardObejct = new List<string>();

            CardObejct.Add("muhendis");
            CardObejct.Add("doktor");
            CardObejct.Add("avukat");
            CardObejct.Add("disci");
            CardObejct.Add("ogretmen");
            CardObejct.Add("sporcu");
            CardObejct.Add("oyuncu");
            CardObejct.Add("marangoz");
            CardObejct.Add("pilot");

            i = 6;
            j = 3;
            
            game = new Form1(CardObejct, i, j, 2);
            game.Show();
        }

        private void btnEzz_Click(object sender, EventArgs e)
        {
            this.Hide();

            List<string> CardObejct = new List<string>();

            CardObejct.Add("kirmizi");
            CardObejct.Add("yesil");
            CardObejct.Add("mavi");
            CardObejct.Add("turuncu");
            CardObejct.Add("sari");
            
            i = 5;
            j = 2;
            
            game = new Form1(CardObejct, i, j, 1);
            game.Show();
        }
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    s -= 1;
                    if (s == 0)
                    {
                        s = 59;
                        m -= 1;
                    }
                    if (m == 0 && s == 1)
                    {
                        Countdown.Visible = false;
                        MessageBox.Show("Süre bitti :(");
                        timer.Stop();
                    }

                    Countdown.Text = "Kalan Süre : " + m.ToString() + "." + s.ToString();
                }));
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Süre bitti :(");
            }
        }
        private void NewNumber(int val)
        {
            while (true)
            {
                MyNumber = rnd.Next(0, val / 2);

                if (!randomList.Contains(MyNumber))
                    randomList.Add(MyNumber);
                else
                {
                    if (randomList.Count == val / 2) break;
                    else continue;
                }
            }
        }
        private void t_Click(object sender, EventArgs e, Button t)
        {
            if (count == 2)
            {
                card1.ForeColor = System.Drawing.SystemColors.Control;
                card2.ForeColor = System.Drawing.SystemColors.Control;
                count = 0;
            }
            if (isFirst)
            {
                card1 = t;
                card1.ForeColor = System.Drawing.SystemColors.GrayText;
                isFirst = false;
            }
            else
            {
                card2 = t;
                card2.ForeColor = System.Drawing.SystemColors.GrayText;
                isFirst = true;
                count++;
            }

            if (count != 0)
                CheckMatch(card1, card2);

        }
        private void CheckMatch(Button c1, Button c2)
        {
            if (c1.Text == c2.Text)
            {
                c1.Visible = false;
                c2.Visible = false;
                points = points + increase;
                audio1.Play();
                MessageBox.Show("Tebrikler!");
            }
            else
            {
                count++;
                audio2.Play();
            }
            
            lblPoints.Text = "Puan: " + points;
        }

    }
}
