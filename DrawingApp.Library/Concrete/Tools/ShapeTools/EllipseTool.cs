using DrawingApp.Library.Abstract;
using DrawingApp.Library.Concrete.Shapes;
using DrawingApp.Library.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Concrete.Tools.ShapeTools
{
    public class EllipseTool:ShapeToolObject
    {
        public EllipseTool()
        {
            this.ObjectName = ShapeNames.Ellipse;
        }
        public override void DrawObject(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Purple, 0, 0, ObjectSize, ObjectSize);
        }

        public override ShapeObject? createActiveObject(Brush color , Point location)
        {
            return new Ellipse(color , location);
        }
    }
}
