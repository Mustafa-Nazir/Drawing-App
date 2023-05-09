using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Abstract
{
    public interface IShapeObject
    {
        string ObjectName { get; set; }
        void DrawObject(PaintEventArgs e);
        void paintObject(object sender , PaintEventArgs e);
    }
}
