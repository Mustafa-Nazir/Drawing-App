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
    public class TriangleTool:ShapeToolObject
    {
        public TriangleTool()
        {
            this.ObjectName = ShapeNames.Triangle;
        }
        public override void DrawObject(PaintEventArgs e)
        {
            Point[] _points = new Point[] { new Point(ObjectSize / 2, 0), new Point(0, ObjectSize), new Point(ObjectSize, ObjectSize) };
            e.Graphics.FillPolygon(Brushes.Blue, _points);
        }

        public override ShapeObject? createActiveObject(Brush color, Point location)
        {
            return new Triangle(color, location);
        }
    }
}
