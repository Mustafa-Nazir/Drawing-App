using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Abstract
{
    public abstract class BaseToolObject:BaseObject
    {

        public bool IsSelect = false;
        private Pen borderPenEnable;
        private Pen borderPenDisable;
        private Pen borderPen;
        public BaseToolObject()
        {

            borderPenEnable = new Pen(Color.DarkGray, borderWidth);
            borderPenDisable = new Pen(Color.Transparent, borderWidth);
            borderPen = borderPenDisable;

            this.Click += ObjectOnClick;
            this.Paint += paintBorder;
            
        }

        protected virtual void ObjectOnClick(object sender , EventArgs e)
        {
            BorderStyleToEnable();
        }
        
        public void BorderStyleToDisable()
        {
            borderPen = borderPenDisable;
            IsSelect = false;
            this.Refresh();
        }

        public void BorderStyleToEnable()
        {
            borderPen = borderPenEnable;
            IsSelect = true;
            this.Refresh();
        }

        private void paintBorder(object sender , PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(borderPen, 0, 0, ObjectSize, ObjectSize);
        }

    }
}
