using DrawingApp.Library.Abstract;
using DrawingApp.Library.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Concrete.Shapes
{
    public class Ellipse:ShapeObject
    {
        public Ellipse(Brush color , Point loaction):base(color , loaction)
        {
            this.ObjectName = ShapeNames.Ellipse;
        }
        public override void DrawObject(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(ObjectColor, 0, 0, ObjectSize, ObjectSize);
        }
    }
}
