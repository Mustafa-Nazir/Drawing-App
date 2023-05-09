using DrawingApp.Library.Abstract;
using DrawingApp.Library.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Concrete.Shapes
{
    public class Hexagon : ShapeObject
    {
        public Hexagon(Brush color, Point loaction) : base(color, loaction)
        {
            this.ObjectName = ShapeNames.Hexagon;
        }

        public override void DrawObject(PaintEventArgs e)
        {
            int size_4 = ObjectSize / 4;
            int size_2 = ObjectSize / 2;
            Point[] points = new Point[]
            {
                new Point(size_4, ObjectSize),
                new Point(size_4*3, ObjectSize),
                new Point(ObjectSize,size_2),
                new Point(size_4*3,0),
                new Point(size_4,0),
                new Point(0,size_2)
            };
            e.Graphics.FillPolygon(ObjectColor, points);
        }
    }
}
