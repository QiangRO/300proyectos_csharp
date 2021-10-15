using System;
using System.Drawing;

namespace yojanahanif
{
	/// <summary>
	/// Summary description for alpha.
	/// </summary>
	public class alpha
	{
		public alpha()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private static int min(int val)
		{
			return (val<0?0:val);
		}	

		public static void setAlpha(Bitmap bmp, int alpha)
		{
			Color col;			

			for (int i=0;i<bmp.Width;i++)
				for (int j=0;j<bmp.Height;j++)				
				{
					col=bmp.GetPixel(i,j);							
					if (col.A>0)
						bmp.SetPixel(i,j,Color.FromArgb(min(col.A-alpha),col.R,col.G,col.B));						
				}			
		}

		public static Bitmap returnAlpha(Bitmap bmp, int alpha)
		{
			Color col;		
			Bitmap bmp2=new Bitmap(bmp);

			for (int i=0;i<bmp.Width;i++)
				for (int j=0;j<bmp.Height;j++)				
				{
					col=bmp.GetPixel(i,j);							
					if (col.A>0)
						bmp2.SetPixel(i,j,Color.FromArgb(min(col.A-alpha),col.R,col.G,col.B));						
				}			
			return bmp2;
		}
	}
}
