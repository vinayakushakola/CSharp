using System;

namespace Properties
{
    public class School
    {
        private int _ID;
        private string _Name;
        private int _passMark = 35;

        public void SetID(int id)

        {
            if (id <= 0)
            {
                throw new Exception("ID cannot be negative");
            }
            this._ID = id;
        }

        public int GetID()
        {
            return this._ID;
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(Name))
                {
                    throw new Exception("Errr");
                }
                this._Name = Name;
            }
            get
            {
                return (string.IsNullOrEmpty(this._Name)) ? "No Name" : this._Name;
            }
        }

        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }

        public string Email { get; set; }
    }
}
