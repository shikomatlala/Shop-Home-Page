using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopHomePage
{
    /// <summary>
    /// This means HomePage contains attributes of the form class and more that we have now defined.
    /// </summary>
    public partial class HomePage : Form //This is a class that inherits from the Parent Class named Form
    {
        public HomePage()
        {
            InitializeComponent();
            //This is a contructor 
            //The goal is to call all the images as the application starts
            //Bitmap myImage = new Bitmap()
            //myImage.Image
            MainTimer.Start();
            MainTimer.Interval = 5000;
        }

        /// <summary>
        /// This is a private method - it means that only the HomePage class can access or rather HomePage objects can access these methods.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PnlHome_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ImgCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
        int q = 0;
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            //DateTime.Now.ToString();
            //testLabel.Text = DateTime.Now.ToString();
            Random rnd = new Random();
            int x = rnd.Next(1, 15);
            Image myImage = Image.FromFile("C:\\Users\\Programmer\\Shiko\\Shiko Files\\Career\\C#\\shopHomePage\\Gift Examples\\A (" + x.ToString() + ").jpeg");
            imgCenter.Image = myImage;
            imgCenter.BackgroundImage = myImage;
            imgCenter.BackgroundImageLayout = ImageLayout.Stretch;


            //Start an array of images.
            // Image[] Pictures2Rotate;
            ///Pictures2Rotate[0] = 

            x = rnd.Next(1, 15);
            myImage = Image.FromFile("C:\\Users\\Programmer\\Shiko\\Shiko Files\\Career\\C#\\shopHomePage\\Gift Examples\\A (" + x.ToString() + ").jpeg");
            string myImageLocation = "C:\\Users\\Programmer\\Shiko\\Shiko Files\\Career\\C#\\shopHomePage\\Gift Examples\\A (";
            Image setPictures = Image.FromFile(myImageLocation + "1).jpeg");

            //testLabel.Text = y(q).ToString();
            //y = y + 1;
           
            img1L.Image = Image.FromFile(myImageLocation + y(q+9).ToString() + ").jpeg");
            //img2L.Image = Image.FromFile(myImageLocation + y(q+8).ToString() + ").jpeg");
            img2L.Image = Image.FromFile(myImageLocation + y(q+3).ToString() + ").jpeg");
            img2L.BackgroundImage = Image.FromFile(myImageLocation + y(q + 1).ToString() + ").jpeg");
            img2L.BackgroundImageLayout = ImageLayout.Stretch;
            //img4L.Image = Image.FromFile(myImageLocation + y(q+6).ToString() + ").jpeg");
            imgCenter.Image = Image.FromFile(myImageLocation + y(q + 2).ToString() + ").jpeg");
            imgCenter.BackgroundImage = Image.FromFile(myImageLocation + y(q + 2).ToString() + ").jpeg");
            imgCenter.BackgroundImageLayout = ImageLayout.Stretch;
            img1R.Image = Image.FromFile(myImageLocation + y(q + 4).ToString() + ").jpeg");
            //img2R.Image = Image.FromFile(myImageLocation + y(q + 3).ToString() + ").jpeg");
            img2R.Image = Image.FromFile(myImageLocation + y(q + 1).ToString() + ").jpeg");
            img2R.BackgroundImageLayout = ImageLayout.Stretch;
            img2R.BackgroundImage = Image.FromFile(myImageLocation + y(q + 1).ToString() + ").jpeg");


            //img4R.Image = Image.FromFile(myImageLocation + y(q + 1).ToString() + ").jpeg");
            if (q > 4)
                q = -1;
            q++;

            //Change the way that the time works



        }
        public int y(int number)
        {
            number++;
            return number;
        }


        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            //string myFile = "Gift Background\\A (1).jpg";
            //Bitmap myPicture = new Bitmap(myFile);
            //BackgroundImage = myPicture;
            //BackgroundImage
            Random rnd = new Random();

            int x = rnd.Next(1, 23);

            Image myImage = Image.FromFile("C:\\Users\\Programmer\\Shiko\\Shiko Files\\Career\\C#\\shopHomePage\\obj\\Debug\\Gift Background\\A (" +x.ToString()+").jpg");
            BackgroundImage = myImage;
            //Bitmap bit
        }

        private void TestLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
