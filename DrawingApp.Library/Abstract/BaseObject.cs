using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Abstract
{
    public abstract class BaseObject:PictureBox
    {
        private int _objectSize;
        protected int borderWidth = 5;
        public int ObjectSize
        {
            get => _objectSize;
            set
            {
                _objectSize = value;
                setObjectSize(_objectSize);
            }
        }

        public BaseObject()
        {
            buildDefaultProperties();
        }

        private void setObjectSize(int size)
        {
            this.Width = size;
            this.Height = size;
        }

        private void buildDefaultProperties()
        {

            ObjectSize = 50;
            this.BackColor = Color.White;
        }
    }
}
