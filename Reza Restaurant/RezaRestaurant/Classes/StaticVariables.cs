using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RezaRestaurant
{
    static class StaticVariables
    {
        /// <summary>
        /// Backup folder
        /// </summary>
        public static string BackUPPath = Application.StartupPath + "\\backup\\";

        /// <summary>
        /// DataBase Folder
        /// </summary>
        public static string DBFolder = Application.StartupPath + "\\SQL\\";

        /// <summary>
        /// پیامی که در فرم پیغام از آن استفاده می کنم
        /// </summary>
        static public string Message = "null";

        /// <summary>
        /// نشان دهنده این است که آیا کاربر وارد سیستم شده یا نه
        /// Login کرده یا نه
        /// </summary>
        static public bool Login = false;

        /// <summary>
        /// از این Label که به Label دیگری در فرم MainForm نسبت داده می شود 
        /// برای تغییر لیبل label_وضعیت_ورود 
        /// در فرم MainForm استفاده می شود
        /// </summary>
        static public Label LoginLabel { get; set; }

        /*
         * متغیر های زیر هنگامی که فرم هم نام آنها نمایش داده میشود true می شوند
         * این کار برای جلوگیری از دوبار باز شدن پنجره ها می باشد 
         * 
         */

        static public bool Form_تنظیمات_نرم_افزار_IsShown = false;
        static public bool Form_جستجو_IsShown = false;
        static public bool Form_صدور_فاکتور_IsShown = false;
        static public bool Form_کدهای_غذا_IsShown = false;
        static public bool Form_گزارش_روزانه_IsShown = false;
        static public bool Form_لیست_غذاها_IsShown = false;
    }
}
