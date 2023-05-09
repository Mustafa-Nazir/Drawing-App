using DrawingApp.Library.Abstract;
using DrawingApp.Library.Concrete.Tools.ColorTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Concrete
{
    public class ActiveElement
    {
        public Panel? ActiveCanvas { get; set; }
        public ShapeObject ? ActiveObject { get; set; }
        public ColorTool? ActiveColorTool { get; set; }
        public ShapeToolObject ? ActiveShapeToolObject { get; set; }
        public TableLayoutPanel ? ShapeToolsPanel { get; set; }
        public TableLayoutPanel ? ColorsPanel { get; set; }
        private static ActiveElement? _instance;
        public static ActiveElement Instance
        {
            get
            {
                if(_instance == null)  _instance = new ActiveElement();
                return _instance;
            }
        }
    }
}
