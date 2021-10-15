using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FormManagement
{
    #region Generic Singleton
    public class SingletonProvider<T> where T : new()
    {
        SingletonProvider() { }

        public static T Instance
        {
            get { return SingletonCreator.Instance; }
        }

        class SingletonCreator
        {
            private SingletonCreator() { }
            private static T instance;
            internal static T Instance
            {
                get
                {
                    if (instance == null)
                        instance = new T();
                    else if (instance is Form)
                        if ((instance as Form).IsDisposed)
                            instance = new T();
                    return instance;
                }
            }
        }
    }
    #endregion

    #region FormManagementHelper
    public class FormManagementHelper
    {
        #region Util
        public static Form ShowChildForm(Form _parent, Form _child)
        {
            _child.MdiParent = _parent;
            _child.Show();
            _child.Activate();
            return _child;
        }
        #endregion

        #region Show Forms
        public static void ShowChild1(Form _parent)
        {
            ShowChildForm(_parent, SingletonProvider<Child1>.Instance);
        }

        public static void ShowChild2(Form _parent)
        {
            ShowChildForm(_parent, SingletonProvider<Child2>.Instance);
        }

        public static void ShowChild3(Form _parent)
        {
            ShowChildForm(_parent, SingletonProvider<Child3>.Instance);
        }
        #endregion
    }
    #endregion
}
