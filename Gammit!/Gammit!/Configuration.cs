using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Security.Permissions;

[assembly:RegistryPermissionAttribute(SecurityAction.RequestMinimum,ViewAndModify = @"HKEY_CURRENT_USER\Software", Create = @"HKEY_CURRENT_USER\Software")]

namespace Gammit
{
    class Configuration
    {
        #region Fields

        static private decimal _GammaLevel;
        static private bool _CloseOnTray;
        static private bool _ClickOnTray;
        static private bool _SilentStart;
        static private bool _ResetOnStart;

        #endregion

        #region Properties
        /// <summary>
        /// Get or Set the Gamma Level configuration.
        /// </summary>
        static public decimal GammaLevel
        {
            get
            {
                return _GammaLevel;
            }
            set
            {
                _GammaLevel = value;
            }
        }

        /// <summary>
        /// Get or Set if to exit the application on form close or to leave it in tray.
        /// </summary>
        static public bool CloseOnTray
        {
            get
            {
                return _CloseOnTray;
            }
            set
            {
                _CloseOnTray = value;
            }
        }

        /// <summary>
        /// Get or Set if the click on the tray will cause the form to show or the application to reset the Gamma level.
        /// </summary>
        static public bool ClickOnTray
        {
            get
            {
                return _ClickOnTray;
            }
            set
            {
                _ClickOnTray = value;
            }
        }

        /// <summary>
        /// Get or Set if the application must start in silent mode.
        /// </summary>
        static public bool SilentStart
        {
            get
            {
                return _SilentStart;
            }
            set
            {
                _SilentStart = value;
            }
        }

        /// <summary>
        /// Get or Set if the application must reset the saved Gamma level when starting.
        /// </summary>
        static public bool ResetOnStart
        {
            get
            {
                return _ResetOnStart;
            }
            set
            {
                _ResetOnStart = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Loads configurations from registry.
        /// </summary>
        static public void Load()
        {
            try 
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software\Gammit\Configuration");

                if (rk == null)
                {
                    CreateDefaultSettings();
                }
                else
                {
                    String opt = rk.GetValue("GammaLevel").ToString();
                    decimal.TryParse(opt, out _GammaLevel);

                    opt = rk.GetValue("CloseOnTray").ToString();
                    bool.TryParse(opt, out _CloseOnTray);

                    opt = rk.GetValue("ClickOnTray").ToString();
                    bool.TryParse(opt, out _ClickOnTray);

                    opt = rk.GetValue("SilentStart").ToString();
                    bool.TryParse(opt, out _SilentStart);

                    opt = rk.GetValue("ResetOnStart").ToString();
                    bool.TryParse(opt, out  _ResetOnStart);
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// Saves configuration to registry.
        /// </summary>
        /// <returns></returns>
        static public bool Save()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software\Gammit\Configuration", true);

                if (rk == null)
                {
                    CreateDefaultSettings();
                }
                else
                {
                    rk.SetValue("GammaLevel", GammaLevel.ToString("F"), RegistryValueKind.String);
                    rk.SetValue("CloseOnTray", CloseOnTray.ToString(), RegistryValueKind.String);
                    rk.SetValue("ClickOnTray", ClickOnTray.ToString(), RegistryValueKind.String);
                    rk.SetValue("SilentStart", SilentStart.ToString(), RegistryValueKind.String);
                    rk.SetValue("ResetOnStart", ResetOnStart.ToString(), RegistryValueKind.String);

                    return true;
                }
            }
            catch 
            {
                CreateDefaultSettings();
            }

            return false;
        }

        static private bool CreateDefaultSettings()
        {
            CloseOnTray = true;
            ClickOnTray = false;
            SilentStart = false;
            ResetOnStart = true;

            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"Software", true);

                if (rk != null)
                {
                    RegistryKey gmk = rk.CreateSubKey(@"Gammit");

                    if (gmk != null)
                    {
                        RegistryKey gmc = gmk.CreateSubKey(@"Configuration");

                        if (gmc != null)
                        {
                            gmc.SetValue("GammaLevel", GammaLevel.ToString("F"), RegistryValueKind.String);
                            gmc.SetValue("CloseOnTray", CloseOnTray.ToString(), RegistryValueKind.String);
                            gmc.SetValue("ClickOnTray", ClickOnTray.ToString(), RegistryValueKind.String);
                            gmc.SetValue("SilentStart", SilentStart.ToString(), RegistryValueKind.String);
                            gmc.SetValue("ResetOnStart", ResetOnStart.ToString(), RegistryValueKind.String);

                            return true;
                        }
                    }
                }
            }
            catch {}

            return false;
        }

        #endregion
    }
}
