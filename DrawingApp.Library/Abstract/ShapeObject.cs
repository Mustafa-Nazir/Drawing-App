using DrawingApp.Library.Concrete;
using DrawingApp.Library.Concrete.Tools.ColorTools;
using DrawingApp.Library.Concrete.Tools.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Abstract
{
    public abstract class ShapeObject : BaseObject, IShapeObject
    {
        public Brush ObjectColor { get; set; }

        public string ObjectName { get; set; }

        private bool _isMouseDown = false;
        private bool _isMouseMove = false;
        public ShapeObject(Brush color , Point loaction)
        {
            addEvents();   
            ObjectColor = color;
            this.Location = loaction;
            this.BackColor = Color.Transparent;
        }

        private void addEvents()
        {
            this.Paint += paintObject;
            this.Click += onClickWithSelector;
            this.MouseDown += onMouseDown;
            this.MouseUp += onMouseUp;
            this.MouseMove += onMouseMove;
        }
        public virtual void DrawObject(PaintEventArgs e)
        {

        }

        public void paintObject(object sender, PaintEventArgs e)
        {
            DrawObject(e);
        }
        public void Disable()
        {
            this.BackColor = Color.Transparent;
            ActiveElement.Instance.ActiveObject = null;
        }
        private void onClickWithSelector(object sender , EventArgs e)
        {
            if (!ObjectSelector.Instance.IsSelect) return;
            changeActiveObject();
            setActiveTools();
        }

        private void changeActiveObject()
        {
            if (_isMouseMove)
            {
                _isMouseMove = false;
                return;
            }
            if(ActiveElement.Instance.ActiveObject == this)
            {
                Disable();
                return;
            }
            if (ActiveElement.Instance.ActiveObject != null)
            {
                ActiveElement.Instance.ActiveObject.BackColor = Color.Transparent;
            }
            this.BackColor = Color.LightGray;
            ActiveElement.Instance.ActiveObject = this;
        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            this._isMouseDown = true;
        }

        private void onMouseUp (object sender, MouseEventArgs e)
        {
            this._isMouseDown= false;
        }
        private void onMouseMove(object sender, MouseEventArgs e)
        {
            changeObjectLocation();
        }
        private void changeObjectLocation()
        {
            if (!_isMouseDown||!ObjectSelector.Instance.IsSelect || ActiveElement.Instance.ActiveObject == null || ActiveElement.Instance.ActiveObject != this) return;
            Point point = ActiveElement.Instance.ActiveCanvas.PointToClient(Cursor.Position);
            point = new Point(point.X - this.ObjectSize/2 , point.Y-this.ObjectSize/2);
            if (!BorderControl(point,this.ObjectSize)) return;
            this.Location = point;
            this._isMouseMove = true;
        }

        private void setActiveTools()
        {
            ShapeToolObject ? tool = ActiveElement.Instance.ShapeToolsPanel?.Controls.OfType<ShapeToolObject>()?.SingleOrDefault(t => t.ObjectName == ObjectName);
            if(ActiveElement.Instance.ActiveShapeToolObject != null) ActiveElement.Instance.ActiveShapeToolObject?.BorderStyleToDisable();
            ActiveElement.Instance.ActiveShapeToolObject = tool;
            tool?.BorderStyleToEnable();

            ColorTool? color = ActiveElement.Instance.ColorsPanel?.Controls.OfType<ColorTool>()?.SingleOrDefault(c => ((SolidBrush)c.Color).Color.ToArgb() == ((SolidBrush)this.ObjectColor).Color.ToArgb()); 
            if(ActiveElement.Instance.ActiveColorTool != null) ActiveElement.Instance.ActiveColorTool?.BorderStyleToDisable();
            ActiveElement.Instance.ActiveColorTool = color;
            color?.BorderStyleToEnable();
        }

        public void SetActiveObject()
        {
            this.BackColor = Color.LightGray;
            ActiveElement.Instance.ActiveObject = this;
            setActiveTools();
        }

        public static bool BorderControl(Point point , int objectSize)
        {
            int max_X = point.X + objectSize;
            int max_Y = point.Y + objectSize;
            if (point.X <= 0 || point.Y <= 0 || max_X >= ActiveElement.Instance.ActiveCanvas?.Width || max_Y >= ActiveElement.Instance.ActiveCanvas?.Height) return false;
            else return true;
        }

    }
}
