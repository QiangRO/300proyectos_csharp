using System;
using Microsoft.Win32;

namespace Ideal.OperationalLayer
{
    /// <summary>
    /// درج اطلاعات رجستری ملزوم به شاخه اصلی است که این قسمت اعلام می کند
    /// </summary>
    public enum ERegistryPossibleRoots
    {
        HKEY_CLASSES_ROOT = 0,
        HKEY_CURRENT_CONFIG = 1,
        HKEY_CURRENT_USER = 2,
        HKEY_DYNDATA = 3,
        HKEY_LOCALE_MACHINE = 4,
        HKEY_PERFORMANCE_DATA = 5,
        HKEY_USERS = 6
    }

    public class IdealRegistry
    {
        private RegistryKey GetRegKey(ERegistryPossibleRoots lngRoot)
        {
            try
            {
                switch (lngRoot)
                {
                    case ERegistryPossibleRoots.HKEY_CLASSES_ROOT:
                        return (Registry.ClassesRoot);
                    case ERegistryPossibleRoots.HKEY_CURRENT_CONFIG:
                        return (Registry.CurrentConfig);
                    case ERegistryPossibleRoots.HKEY_CURRENT_USER:
                        return (Registry.CurrentUser);
                    case ERegistryPossibleRoots.HKEY_DYNDATA:
                        return (Registry.DynData);
                    case ERegistryPossibleRoots.HKEY_LOCALE_MACHINE:
                        return (Registry.LocalMachine);
                    case ERegistryPossibleRoots.HKEY_PERFORMANCE_DATA:
                        return (Registry.PerformanceData);
                    case ERegistryPossibleRoots.HKEY_USERS:
                        return (Registry.Users);
                }
                return null;
            }
            catch (System.Exception ex)
            {
                throw new Exception("Fehler in GetRegKey!", ex);
            }
        }

        public bool DoesKeyExist(ERegistryPossibleRoots lngRootKey, string strKey)
        {
            RegistryKey objRegKey = null;

            try
            {
                objRegKey = GetRegKey(lngRootKey);
                objRegKey = objRegKey.OpenSubKey(strKey, false);

                if (objRegKey == null)
                    return false;
                else
                {
                    objRegKey.Close();
                    objRegKey = null;
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Fehler in DoesKeyExist!", ex);
            }
        }

        public bool CreateKey(ERegistryPossibleRoots lngrootkey, string strKey)
        {
            RegistryKey objRegKey = null;

            try
            {
                objRegKey = GetRegKey(lngrootkey);

                objRegKey = objRegKey.CreateSubKey(strKey);

                if (objRegKey == null)
                    return (false);
                else
                    return (true);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Fehler in CreateKey!", ex);
            }
            finally
            {
                try
                {
                    objRegKey.Close();
                }
                catch { }
                objRegKey = null;
            }
        }

        public bool DeleteKey(ERegistryPossibleRoots lngrootkey, string strKey, params bool[] bRecursive)
        {
            RegistryKey objRegKey = null;
            try
            {
                objRegKey = GetRegKey(lngrootkey);

                if (bRecursive.Length > 0)
                {
                    if (bRecursive[0])
                    {
                        objRegKey.DeleteSubKeyTree(strKey);
                    }
                    else
                    {
                        objRegKey.DeleteSubKey(strKey);
                    }
                }
                else
                    objRegKey.DeleteSubKey(strKey);
                return true;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Fehler in DeleteKey", ex);
            }
            finally
            {
                if (objRegKey != null)
                {
                    try
                    {
                        objRegKey.Close();
                    }
                    catch
                    {
                    }
                }
                objRegKey = null;
            }
        }

        #region Registry-Wert abfragen (3 Funktionen)
        public string QueryValue(ERegistryPossibleRoots lngrootkey, string strKey, string strValName, string objDefault)
        {
            RegistryKey objRegKey = null;

            try
            {
                objRegKey = GetRegKey(lngrootkey);
                objRegKey = objRegKey.OpenSubKey(strKey);

                return ((string)objRegKey.GetValue(strValName, objDefault));
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Fehler in QueryValue(string)!", ex);
            }
            finally
            {
                if (objRegKey != null)
                {
                    try
                    {
                        objRegKey.Close();
                    }
                    catch { }
                }
                objRegKey = null;
            }
        }

        public byte[] QueryValue(ERegistryPossibleRoots lngrootkey, string strKey, string strValName, byte[] objDefault)
        {
            RegistryKey objRegKey = null;
            try
            {
                objRegKey = GetRegKey(lngrootkey);
                objRegKey = objRegKey.OpenSubKey(strKey);

                return ((byte[])objRegKey.GetValue(strValName, objDefault));
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Fehler in QueryValue(byte[])!", ex);
            }
            finally
            {
                if (objRegKey != null)
                {
                    try
                    {
                        objRegKey.Close();
                    }
                    catch { }
                }
                objRegKey = null;
            }
        }

        public int QueryValue(ERegistryPossibleRoots lngrootkey, string strKey, string strValName, int objDefault)
        {
            RegistryKey objRegKey = null;
            try
            {
                objRegKey = GetRegKey(lngrootkey);
                objRegKey = objRegKey.OpenSubKey(strKey);

                return ((int)objRegKey.GetValue(strValName, objDefault));
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Fehler in QueryValue(int)!", ex);
            }
            finally
            {
                if (objRegKey != null)
                {
                    try
                    {
                        objRegKey.Close();
                    }
                    catch { }
                }
                objRegKey = null;
            }
        }
        #endregion

        #region Registry-Wert anlegen (3 Funktionen)
        public bool CreateValue(ERegistryPossibleRoots lngrootkey, string strKey, string strValName, string objVal)
        {
            RegistryKey objRegKey = null;
            try
            {
                objRegKey = GetRegKey(lngrootkey);
                objRegKey = objRegKey.OpenSubKey(strKey, true);

                if (objRegKey != null)
                {
                    objRegKey.SetValue(strValName, objVal);
                    objRegKey.Flush();
                    return (true);
                }
                else
                    return (false);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Fehler in CreateValue(string)!", ex);
            }
            finally
            {
                try
                {
                    objRegKey.Close();
                }
                catch { }
                objRegKey = null;
            }
        }

        public bool CreateValue(ERegistryPossibleRoots lngrootkey, string strKey, string strValName, byte[] objVal)
        {
            RegistryKey objRegKey = null;
            try
            {
                objRegKey = GetRegKey(lngrootkey);
                objRegKey = objRegKey.OpenSubKey(strKey, true);

                if (objRegKey != null)
                {
                    objRegKey.SetValue(strValName, objVal);
                    objRegKey.Flush();
                    return (true);
                }
                else
                    return (false);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Fehler in CreateValue(byte[])!", ex);
            }
            finally
            {
                try
                {
                    objRegKey.Close();
                }
                catch { }
                objRegKey = null;
            }
        }

        public bool CreateValue(ERegistryPossibleRoots lngrootkey, string strKey, string strValName, int objVal)
        {
            RegistryKey objRegKey = null;
            try
            {
                objRegKey = GetRegKey(lngrootkey);
                objRegKey = objRegKey.OpenSubKey(strKey, true);

                if (objRegKey != null)
                {
                    objRegKey.SetValue(strValName, objVal);
                    objRegKey.Flush();
                    return (true);
                }
                else
                    return (false);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Fehler in CreateValue(string)!", ex);
            }
            finally
            {
                try
                {
                    objRegKey.Close();
                }
                catch { }
                objRegKey = null;
            }
        }
        #endregion

        public bool DeleteValue(ERegistryPossibleRoots lngrootkey, string strKey, string strValName)
        {
            RegistryKey objRegKey = null;
            try
            {
                objRegKey = GetRegKey(lngrootkey);
                objRegKey = objRegKey.OpenSubKey(strKey, true);

                if (objRegKey != null)
                {
                    objRegKey.DeleteValue(strValName);
                    objRegKey.Flush();
                    return true;
                }
                else
                    return false;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Fehler in DeleteValue!", ex);
            }
            finally
            {
                try
                {
                    objRegKey.Close();
                }
                catch { }
                objRegKey = null;
            }
        }
    }
}