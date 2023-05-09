using DrawingApp.Library.Abstract;
using DrawingApp.Library.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Concrete.Shapes
{
    public class Triangle : ShapeObject
    {
        public Triangle(Brush color, Point loaction) : base(color, loaction)
        {
            this.ObjectName = ShapeNames.Triangle;
        }

        public override void DrawObject(PaintEventArgs e)
        {
            Point[] _points = new Point[] { new Point(ObjectSize / 2, 0), new Point(0, ObjectSize), new Point(ObjectSize, ObjectSize) };
            e.Graphics.FillPolygon(ObjectColor, _points);
        }
    }
}
