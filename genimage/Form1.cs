using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace genimage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstText = "Start Date   : 07-08-2016";
            string secondText = "Expiry Date : 30-08-2017";
            string name1 = "Abdul Karim bin Abdul Raslan";
            string name2 = "Jane Smith";
            string name3 = "James Smith";
            string name4 = "Abdul Yusuf bin Abdul Raslan";
            string name5 = "Abdul Kamal bin Abdul Raslan";
            string name6 = "Melati Seri Abadi binti Abdul Raslan";
            string name7 = "Aminah Seri Abadi binti Abdul Raslan";

            
            string imageFilePath = @"C:\Users\eileen.loo\Downloads\Cardfaces for IT\2016_FOBP.png";
            string newPath = @"C:\Users\eileen.loo\Downloads\Cardfaces for IT\NewPic.png";
            string memImagePath = @"C:\Users\eileen.loo\Downloads\Cardfaces for IT\lion.jpg";
            Bitmap bitmap = (Bitmap)Image.FromFile(imageFilePath);//load the image file

            using(Graphics graphics = Graphics.FromImage(bitmap))
            {

                Font arialFont = new Font("Arial", 20);
                Font arialBoldFont = new Font("Arial", 20,FontStyle.Bold);

                // SizeF name7Len = graphics.MeasureString(name7, arialFont);
                //l9thLocation = new PointF(620f, 550f - name7Len);
                //PointF firstLocation = new PointF(580f, 170f);
                //PointF secondLocation = new PointF(580f, 230f);
                //var format = new StringFormat() { Alignment = StringAlignment.Far };
                //var rect1 = new RectangleF(350f, 320f, 760f, 50f);
                //var rect2 = new RectangleF(350f, 380f, 760f, 50f);
                //var rect3 = new RectangleF(350f, 440f, 760f, 50f);
                //var rect4 = new RectangleF(350f, 500f, 760f, 50f);
                //var rect5 = new RectangleF(350f, 560f, 760f, 50f);
                //var rect6 = new RectangleF(350f, 620f, 760f, 50f);
                //var rect7 = new RectangleF(350f, 680f, 760f, 50f);
                
                var format = new StringFormat() { Alignment = StringAlignment.Near };
                var formatFar = new StringFormat() { Alignment = StringAlignment.Far };
                var rectFrom = new RectangleF(760f, 190f, 310f, 35f);
                var rectTo = new RectangleF(760f, 221f, 310f, 35f);
                var rect1 = new RectangleF(380f, 35f, 550f, 35f);
                var rect2 = new RectangleF(380f, 66f, 550f, 35f);
                var rect3 = new RectangleF(380f, 97f, 550f, 35f);
                var rect4 = new RectangleF(380f, 128f, 550f, 35f);
                var rect5 = new RectangleF(380f, 159f, 550f, 35f);
                var rect6 = new RectangleF(380f, 190f, 550f, 35f);
                var rect7 = new RectangleF(380f, 221f, 550f, 35f);
                var rectBarcode = new RectangleF(543f, 265f, 500f, 150f);

                Bitmap imagebm = (Bitmap)Image.FromFile(memImagePath);
              //  Graphics image = Graphics.FromImage(imagebm);
                var rectImg = new RectangleF(38f, 41f, 325f, 363f);

                // barcode
               //// System.Drawing.Image codeImage = null;
               // MessagingToolkit.Barcode.BarcodeEncoder BarcodeEnc = new MessagingToolkit.Barcode.BarcodeEncoder();
               // BarcodeEnc.Margin = 5;
               // BarcodeEnc.Alignment = MessagingToolkit.Barcode.AlignmentPositions.Center;
               // BarcodeEnc.Width = 200;
               // BarcodeEnc.Height = 60;
               // BarcodeEnc.IncludeLabel = true;
               // BarcodeEnc.LabelPosition = MessagingToolkit.Barcode.LabelPositions.BottomCenter;
               // BarcodeEnc.LabelFont = new Font("Arial", 9);
               // System.Drawing.Image codeImage = BarcodeEnc.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128C, "12345678901234567890");
   

                //graphics.DrawString(firstText, arialFont, Brushes.Black, firstLocation);
                //graphics.DrawString(secondText, arialFont, Brushes.Black, secondLocation);
                graphics.DrawString(firstText, arialFont, Brushes.Black, rectFrom, formatFar);
                graphics.DrawString(secondText, arialFont, Brushes.Black, rectTo, formatFar);
                graphics.DrawString(name1.Length <= 30?name1:name1.Substring(0, 30), arialFont, Brushes.Black, rect1, format);
                graphics.DrawString(name2.Length <= 30 ? name2 : name2.Substring(0, 30), arialFont, Brushes.Black, rect2, format);
                graphics.DrawString(name3.Length <= 30 ? name3 : name3.Substring(0, 30), arialFont, Brushes.Black, rect3, format);
                graphics.DrawString(name4.Length <= 30 ? name4 : name4.Substring(0, 30), arialFont, Brushes.Black, rect4, format);
                graphics.DrawString(name5.Length <= 30 ? name5 : name5.Substring(0, 30), arialFont, Brushes.Black, rect5, format);
                graphics.DrawString(name6.Length <= 30 ? name6 : name6.Substring(0, 30), arialFont, Brushes.Black, rect6, format);
                graphics.DrawString(name7.Length <= 30 ? name7 : name7.Substring(0, 30), arialFont, Brushes.Black, rect7, format);
                graphics.DrawImage(imagebm, rectImg);
                graphics.DrawString("barcodehere", arialFont, Brushes.Black, rectBarcode, format);
        

                bitmap.Save(newPath);//save the image file
                
            }

            
        }
    }
}
