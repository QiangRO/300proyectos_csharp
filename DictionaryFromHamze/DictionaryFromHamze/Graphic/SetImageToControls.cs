using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DictionaryFromHamze.Graphic
{
    class SetImageToControls
    {
        public static void SetGraphicToControl(Control ctrl, Bitmap Image)
        {
            ctrl.Width = Image.Width;
            ctrl.Height = Image.Height;
            if (ctrl == null || Image == null)
                return;
            if (ctrl is System.Windows.Forms.Form)
            {
                ctrl.Height += 40;
                ctrl.Width += 40;
                Form form = (Form)ctrl;
                form.FormBorderStyle = FormBorderStyle.None;
                //frm.Text = "";
                form.TransparencyKey = Image.GetPixel(0, 0);
                form.BackgroundImage = Image;
                GraphicsPath gPathForControl = GetPathFromImage(form.TransparencyKey, Image);
                form.Region = new Region(gPathForControl);
            }
            else if (ctrl is System.Windows.Forms.Button)
            {
                Button Btn = (Button)ctrl;
                
                Btn.Text = "";
                Btn.Cursor = Cursors.Hand;
                Btn.BackgroundImage = Image;
                GraphicsPath gPathForControl = GetPathFromImage(Image.GetPixel(0, 0), Image);
                Btn.Region = new Region(gPathForControl);
            }
        }
        private static GraphicsPath GetPathFromImage(Color TransparentColor, Bitmap ImageForPtah)
        {
            GraphicsPath computedPath = new GraphicsPath();
            //set bounds to search pixel's
            int height = ImageForPtah.Height, width = ImageForPtah.Width;

            //move across the Y axis
            for (int Y = 0; Y < height; Y++)

                //move across the X axis
                for (int X = 0; X < width; X++)

                    if (!TransparentColor.Equals(ImageForPtah.GetPixel(X, Y)))
                    {
                        int FindUnParentColoumn = X, GoAheadColoumn = X;
                        //az hamun noghte shoroo mikone ta be ye trans brese ta dar rasme rect ta unja bere
                        for (GoAheadColoumn = FindUnParentColoumn; GoAheadColoumn < ImageForPtah.Width; GoAheadColoumn++)
                            if (ImageForPtah.GetPixel(GoAheadColoumn, Y) == TransparentColor)
                                break;
                        computedPath.AddRectangle(new Rectangle(FindUnParentColoumn, Y, GoAheadColoumn - FindUnParentColoumn, 1));
                        X = GoAheadColoumn;
                    }

            return computedPath;
        }
    }
}
