using DrawingApp.Library.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Abstract
{
    public abstract class ShapeToolObject : BaseToolObject, IShapeObject
    {
        public string  ObjectName { get; set; }

        public ShapeToolObject()
        {
            ObjectSize = 80;
            this.Paint += paintObject;
        }
        public void paintObject(object sender, PaintEventArgs e)
        {
            DrawObject(e);
        }

        public virtual void DrawObject(PaintEventArgs e)
        {

        }

        protected override void ObjectOnClick(object sender, EventArgs e)
        {
            changeSelection();
        }

        public virtual ShapeObject ? createActiveObject(Brush color , Point location)
        {
            return null;
        }
        private void changeSelection()
        {
            if (ActiveElement.Instance.ActiveShapeToolObject == this) return;
            if (ActiveElement.Instance.ActiveShapeToolObject != null)
            {
                ActiveElement.Instance.ActiveShapeToolObject.BorderStyleToDisable();
            }
            ActiveElement.Instance.ActiveShapeToolObject = this;
            BorderStyleToEnable();
        }
    }
}
