using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class House
    {
        private int _size;
        private string _streetAddress;
        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public void SetAlarm()
        {
            throw new System.NotImplementedException();
        }

        public void Lock()
        {
            throw new System.NotImplementedException();
        }
    }
}