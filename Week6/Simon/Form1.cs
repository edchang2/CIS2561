using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Simon
{
    public partial class Form1 : Form
    {
        enum ColorCode {  BLUE, RED, YELLOW, GREEN, WRONG}
        int index = 0; //which light the player is on / guessing
        List<ColorCode> sequence = new List<ColorCode>();
        Random rand = new Random();

        Dictionary<ColorCode, SoundPlayer> sounds = new Dictionary<ColorCode, SoundPlayer>();
        Dictionary<ColorCode, Image> lightsOn = new Dictionary<ColorCode, Image>();
        Dictionary<ColorCode, Image> lightsOff = new Dictionary<ColorCode, Image>();
        Dictionary<ColorCode, PictureBox> pictureBox = new Dictionary<ColorCode, PictureBox>();





        public Form1()
        {
            InitializeComponent();

            //setup sounds
            sounds[ColorCode.BLUE] = new SoundPlayer(Properties.Resources.tone_Middle_C);
            sounds[ColorCode.RED] = new SoundPlayer(Properties.Resources.tone_E);
            sounds[ColorCode.YELLOW] = new SoundPlayer(Properties.Resources.tone_A_High);
            sounds[ColorCode.GREEN] = new SoundPlayer(Properties.Resources.tone_A_Low);
            sounds[ColorCode.WRONG] = new SoundPlayer(Properties.Resources.tone_Wrong_Guess);

            //setup lights off
            lightsOn[ColorCode.BLUE] = Properties.Resources.Simon_Blue_On;
            lightsOn[ColorCode.RED] = Properties.Resources.Simon_Red_On;
            lightsOn[ColorCode.YELLOW] = Properties.Resources.Simon_Yellow_On;
            lightsOn[ColorCode.GREEN] = Properties.Resources.Simon_Green_On;

            lightsOff[ColorCode.BLUE] = Properties.Resources.Simon_Blue_Off;
            lightsOff[ColorCode.RED] = Properties.Resources.Simon_Red_Off;
            lightsOff[ColorCode.YELLOW] = Properties.Resources.Simon_Yellow_Off;
            lightsOff[ColorCode.GREEN] = Properties.Resources.Simon_Green_Off;

            //picture boxes
            pictureBox[ColorCode.BLUE] = pictureBox3;
            pictureBox[ColorCode.RED] = pictureBox2;
            pictureBox[ColorCode.YELLOW] = pictureBox4;
            pictureBox[ColorCode.GREEN] = pictureBox1;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            HandleButton(ColorCode.GREEN);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            HandleButton(ColorCode.RED);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            HandleButton(ColorCode.BLUE);


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            HandleButton(ColorCode.YELLOW);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //to start the game
            sequence.Clear();
            AddLight();
            PlaySequence();



        }

        void FlashLight(ColorCode c)
        {
            //turn on the light
            Image on = lightsOn[c];
            pictureBox[c].Image = on;
            pictureBox[c].Refresh();

            //play sound;
            sounds[c].PlaySync();

            //turn off the light
            pictureBox[c].Image = lightsOff[c];

        }

        void AddLight()
        {
            sequence.Add((ColorCode)rand.Next(4));
        }

        void PlaySequence()
        {
            index = 0;
            timer1.Start();
            timer1.Interval = 500;

        }

        void HandleButton(ColorCode c)
        {
            if (sequence.Count > 0)
            {
                if (c == sequence[index])
                {
                    FlashLight(c);
                    index++;

                    if (index == sequence.Count)
                    {
                        AddLight();
                        PlaySequence();
                        index = 0;
                    }

                }
                else
                {
                    sounds[ColorCode.WRONG].PlaySync();
                    button1.PerformClick();
                }
            } else
            {
                button1.PerformClick();
            }

            




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ColorCode c = sequence[index]; //get current light's color
            FlashLight(c);

            index++;
            if (index == sequence.Count)
            {
                timer1.Stop();
            }

        }
    }
}
