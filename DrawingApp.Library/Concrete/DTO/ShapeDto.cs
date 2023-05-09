using DrawingApp.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Concrete.DTO
{
    public class ShapeDto:IDto
    {
        public string ShapeType { get; set; }
        public Point Location { get; set; }
        public int ColorARGB { get; set; }
        public int ObjectSize { get; set; }
        public bool IsActive { get; set; }

    }
}
