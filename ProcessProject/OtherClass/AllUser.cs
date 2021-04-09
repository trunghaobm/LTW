using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessProject.OtherClass
{
    class AllUser
    {

        public static void OpenChildForm(Form childform, Panel childform_pnl)
        {
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            childform_pnl.Controls.Add(childform);
            childform_pnl.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        public static byte[] ImageToBinary(Image source)
        {
            MemoryStream ms = new MemoryStream();
            source.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image BinaryToImage(byte[] source)
        {
            try
            {
                MemoryStream ms = new MemoryStream(source, 0, source.Length);
                ms.Write(source, 0, source.Length);
                return Image.FromStream(ms, true);//Exception occurs here
            }
            catch { }
            return null;
        }

        public static void PanitEvent(PaintEventArgs e, string text, string font, int size, Brush brush, Point point)
        {
            using (Font myFont = new Font(font, size))
            {
                e.Graphics.DrawString(text, myFont, brush, point);
            }
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        //public static DataGridViewImageColumn createGraphicsColumn()
        //{
        //    Icon treeIcon = new Icon(Type.GetType(), "tree.ico");
        //    DataGridViewImageColumn mCol = new DataGridViewImageColumn();
        //    mCol.Image = treeIcon.ToBitmap();
        //    mCol.Name = "Tree";
        //    mCol.HeaderText = "Nice tree";
        //    return mCol;
        //}
    }
}
