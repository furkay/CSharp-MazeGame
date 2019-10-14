using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        int x=20, y=20;
        public Form1()
        {
            InitializeComponent();
        }

        private void SonMouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Kazandınız..");
            Close();
        }
        private void MoveToStart()
        {
            Cursor.Show();
            x = 20;
            y = 20;
            Point startPoint = new Point(x,y); //baslangic noktasi olusturulur

          

            Cursor.Position = PointToScreen(startPoint); //Mouse-pointer Baslangic noktasina koyulur 

            Bitmap bmp = new Bitmap(Properties.Resources.top, 20, 20);
            this.Cursor = new Cursor(bmp.GetHicon());



        }

        private void LineMouseEnter(object sender, EventArgs e)
        {
            int a = -135;
            int b = -175;
            Point startPoint = new Point(a, b); //baslangic noktasi olusturulur


            Cursor.Position = PointToScreen(startPoint); //Mouse-pointer Baslangic noktasina koyulur 






            Cursor.Hide();

                       DialogResult again = new DialogResult();
            again = MessageBox.Show("Yeniden başlamak istiyormusunuz ?", "Yeniden Oyna", MessageBoxButtons.YesNo);
            if (again == DialogResult.Yes)
            {
               
                MoveToStart();  
            }
            if (again == DialogResult.No)
            {
                Application.Exit();
            }



           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


 MoveToStart();


        }

        private void main_KeyDown(object sender, KeyEventArgs e)
        {


                if (e.KeyCode == Keys.Right)
                {


                x = x + 10;
                    Point startPoint = new Point(x, y); //baslangic noktasi olusturulur


                    Cursor.Position = PointToScreen(startPoint); //Mouse-pointer Baslangic noktasina koyulur 



                }
                if (e.KeyCode == Keys.Left)
                {

                x=x - 10;
                    Point startPoint = new Point(x, y); //baslangic noktasi olusturulur


                    Cursor.Position = PointToScreen(startPoint); //Mouse-pointer Baslangic noktasina koyulur 


                }

                if (e.KeyCode == Keys.Up)
                {

                y = y - 10;
                    Point startPoint = new Point(x, y); //baslangic noktasi olusturulur


                    Cursor.Position = PointToScreen(startPoint); //Mouse-pointer Baslangic noktasina koyulur 

                }

                if (e.KeyCode == Keys.Down)
                {
                y = y + 10;

                    Point startPoint = new Point(x, y); //baslangic noktasi olusturulur


                    Cursor.Position = PointToScreen(startPoint); //Mouse-pointer Baslangic noktasina koyulur 

                }
                




            








            /*
                        if (e.KeyCode == Keys.Right)
                                    {

                                        pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);

                                    }
                                if (e.KeyCode == Keys.Left)
                                {

                                    pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);

                                  }
                                if (e.KeyCode == Keys.Up)
                                {

                                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);

                                }
                                if (e.KeyCode == Keys.Down)
                                {

                                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);

                                }
                                */
        }
    }
}