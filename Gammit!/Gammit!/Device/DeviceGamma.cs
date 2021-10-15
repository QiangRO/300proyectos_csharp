using System;
using System.Runtime.InteropServices;
using Gammit;

namespace Gammit.Device
{
    class DeviceGamma
    {
        static private UInt16[] _RampSaved = new UInt16[256*3];

        #region Properties
        /// <summary>
        /// Returns Ramp Saved
        /// </summary>
        static public UInt16 RampSaved
        {
            get
            {
                return RampSaved;
            }
            set
            {
                RampSaved = value;
            }
        }

        #endregion


        [DllImport("gdi32.dll", EntryPoint = "GetDeviceGammaRamp")]
        static private extern bool GetDeviceGamma(IntPtr hdc, UInt16[] lpRamp);

        [DllImport("gdi32.dll", EntryPoint = "SetDeviceGammaRamp")]
        static private extern bool SetDeviceGamma(IntPtr hdc, UInt16[] lpRamp);


        static public float GetGamma()
        {
            IntPtr hdc = NativeMethods.GetDC(IntPtr.Zero);

            DeviceGamma.GetDeviceGamma(hdc, _RampSaved);

            NativeMethods.ReleaseDC(IntPtr.Zero, hdc);

            float[] rgb = { 1.0f, 1.0f, 1.0f };

            for (int i = 0; i < 3; i++)
            {
                float Csum = 0.0f;
                int Ccount = 0;
                int min = 256 * i;
                int max = min + 256;

                for (int j = min; j < max; j++)
                {

                    if (j != 0 && _RampSaved[j] != 0)
                    {
                        double B = (j % 256) / 256.0;
                        double A = _RampSaved[j] / 65536.0;
                        float C = (float)(Math.Log(A) / Math.Log(B));

                        Csum += C;
                        Ccount++;
                    }
                }

                rgb[i] = Csum / Ccount;
            }

            return rgb[0];
        }

        static public bool SetGamma(float Gamma) 
        {
            UInt16[] ramp = new UInt16[256 * 3];

            for (int i = 0; i < 256; i++)
            {
                ramp[i] = ramp[i + 256] = ramp[i + 512] =
                (UInt16)Math.Min(65535, Math.Max(0, Math.Pow((float)((i + 1) / 256.0), (float)Gamma) * 65535 + 0.5));
            }

            IntPtr hdc = NativeMethods.GetDC(IntPtr.Zero);

            DeviceGamma.SetDeviceGamma(hdc, ramp);

            NativeMethods.ReleaseDC(IntPtr.Zero, hdc);

            return true;
        }
    }
}
