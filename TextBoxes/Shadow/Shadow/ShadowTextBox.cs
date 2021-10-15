using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;

namespace Shadow
{
    internal enum TypeOfDraw
    {
        None
       ,Shadow
    };
    public class ShadowTextBox:TextBox
    {
       
        
        private TypeOfDraw typeDraw;
       
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.typeDraw = TypeOfDraw.Shadow;
            this.Parent.Paint += new PaintEventHandler(Parent_Paint);
            this.InvokePaint(this.Parent, new PaintEventArgs
            (this.Parent.CreateGraphics(), this.Parent.ClientRectangle));

        }
        void Parent_Paint(object sender, PaintEventArgs e)
        {
            this.doShadow(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.typeDraw = TypeOfDraw.None;
            this.InvokePaint(this.Parent, new PaintEventArgs
            (this.Parent.CreateGraphics(), this.Parent.ClientRectangle));
            this.Parent.Paint -= new PaintEventHandler(this.Parent_Paint);

        }
       
        private void doShadow(PaintEventArgs e)
        {

            Color customColor;
            SizeF shadowSize = this.Size;
            SizeF addSize = new SizeF(7.5F, 10.8F);

            // Add them together and save the result in shadowSize.
            shadowSize = shadowSize + addSize;

            // Get the location of the ListBox and convert it to a PointF.
            PointF shadowLocation = this.Location;
            // Add two points to get a new location.
            shadowLocation = shadowLocation + new Size(12, 12);

            // Create a rectangleF. 
            RectangleF rectFToFill =
                new RectangleF(shadowLocation, shadowSize);

            // Create a custom brush using a semi-transparent color, and 
            // then fill in the rectangle.
            if (this.typeDraw == TypeOfDraw.Shadow)
                customColor = Color.FromArgb(70, Color.Gray);
            else
                customColor = this.Parent.BackColor;
            SolidBrush shadowBrush = new SolidBrush(customColor);
            e.Graphics.FillRectangles(shadowBrush, new RectangleF[] { rectFToFill });
            // Dispose of the brush.
            shadowBrush.Dispose();

        }
    }
}
