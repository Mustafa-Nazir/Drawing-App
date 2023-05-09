using DrawingApp.Library.Concrete.Tools.ColorTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Abstract
{
    public interface IPaint
    {
        public Panel Canvas { get;}
        public TableLayoutPanel ColorsPanel { get; }
        public TableLayoutPanel ShapeToolsPanel { get; }
        public TableLayoutPanel ModifierToolsPanel { get; }
        public TableLayoutPanel FileToolsPanel { get; }
        public void LoadTheShapeTools();
        public void LoadTheModifierTools();
        public void LoadTheFileTools();
        public void LoadColors();
        public void LoadAllTools();
    }
}
