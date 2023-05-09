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
    public class SquareTool:ShapeToolObject
    {
        public SquareTool()
        {
            this.ObjectName = ShapeNames.Square;
        }
        public override void DrawObject(PaintEventArgs e)
        {
            int borderW2 = ObjectSize - borderWidth * 2;
            e.Graphics.FillRectangle(Brushes.Yellow, borderWidth, borderWidth, borderW2, borderW2);
        }

        public override ShapeObject? createActiveObject(Brush color, Point location)
        {
            return new Square(color, location);
        }
    }
}
