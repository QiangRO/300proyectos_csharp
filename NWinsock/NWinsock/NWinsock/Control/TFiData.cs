using System.Collections.Generic;
namespace Control.Notify
{
    public abstract class Data
    {
        public string Subject { get; set; }

        public SerializableDictionary<string, NameValue> Params { get; set; } 

        public System.DateTime Date { get; set; }

        public string MacAddress { get; set; }

        public string IP { get; set; }

    }

    public struct NameValue
    {
        #region Ctor
        public NameValue(string name, int value)
        {
            this.name = name;
            this.val = value;
        }
        #endregion

        #region props
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int val;
        public int Value
        {
            get { return val; }
            set { val = value; }

        }
        #endregion

        #region  Override Methods
        public override string ToString()
        {
            return string.Format("{0}({1})", name, val);
        }
        #endregion
    }

    interface IData
    {
        void Init();
    }
}
