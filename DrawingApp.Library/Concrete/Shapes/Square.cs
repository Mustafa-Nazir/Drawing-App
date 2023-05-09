using DrawingApp.Library.Abstract;
using DrawingApp.Library.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Concrete.Shapes
{
    public class Square : ShapeObject
    {
        public Square(Brush color, Point loaction) : base(color, loaction)
        {
            this.ObjectName = ShapeNames.Square;
        }

        public override void DrawObject(PaintEventArgs e)
        {
            int borderW2 = ObjectSize -  borderWidth* 2;
            e.Graphics.FillRectangle(ObjectColor, borderWidth, borderWidth, borderW2, borderW2);
        }
    }
}
