using DrawingApp.Library.Abstract;
using DrawingApp.Library.Concrete.Shapes;
using DrawingApp.Library.Concrete.Tools.ColorTools;
using DrawingApp.Library.Concrete.Tools.FileTools;
using DrawingApp.Library.Concrete.Tools.Modifiers;
using DrawingApp.Library.Concrete.Tools.ShapeTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Concrete
{
    public class Paint : IPaint
    {
        public Panel Canvas { get; }

        public TableLayoutPanel ShapeToolsPanel { get; }

        public TableLayoutPanel ModifierToolsPanel { get; }

        public TableLayoutPanel FileToolsPanel { get; }

        public TableLayoutPanel ColorsPanel { get; }
        private bool _isDrawn = false;
        private ShapeObject ? _drawenObject;
        private Point _startPoint;

        public Paint(Panel canvas, TableLayoutPanel shapeToolsPanel, TableLayoutPanel modifierToolsPanel, TableLayoutPanel fileToolsPanel, TableLayoutPanel colorsPanel)
        {
            Canvas = canvas;
            ActiveElement.Instance.ActiveCanvas = canvas;
            ShapeToolsPanel = shapeToolsPanel;
            ActiveElement.Instance.ShapeToolsPanel = shapeToolsPanel;
            ModifierToolsPanel = modifierToolsPanel;
            FileToolsPanel = fileToolsPanel;
            ColorsPanel = colorsPanel;
            ActiveElement.Instance.ColorsPanel = colorsPanel;

            LoadAllTools();
            addCanvasEvents();
        }

        #region Tools
        public void LoadTheFileTools()
        {
            foreach (FileToolObject fileTool in getFileTools())
            {
                FileToolsPanel.Controls.Add(fileTool);
            }
        }

        public void LoadTheModifierTools()
        {
            foreach (ModifierToolObject modifier in getModifiers())
            {
                ModifierToolsPanel.Controls.Add(modifier);
            }
        }

        public void LoadTheShapeTools()
        {
            foreach (ShapeToolObject shape in getShapes())
            {
                ShapeToolsPanel.Controls.Add(shape);
            }
        }

        public void LoadColors()
        {
            foreach (ColorTool color in getColors())
            {
                ColorsPanel.Controls.Add(color);
            }
        }

        private ShapeToolObject[] getShapes()
        {
            ShapeToolObject[] shapes = new ShapeToolObject[]
            {
                new SquareTool(),
                new EllipseTool(),
                new TriangleTool(),
                new HexagonTool()
            };
            return shapes;
        }
        private ColorTool[] getColors()
        {
            ColorTool[] _colorTools = new ColorTool[]
            {
                new ColorTool(Brushes.Red),
                new ColorTool(Brushes.Blue),
                new ColorTool(Brushes.Green),
                new ColorTool(Brushes.Orange),
                new ColorTool(Brushes.Black),
                new ColorTool(Brushes.Yellow),
                new ColorTool(Brushes.Purple),
                new ColorTool(Brushes.Maroon),
                new ColorTool(Brushes.White)
            };

            return _colorTools;
        }
        private ModifierToolObject[] getModifiers()
        {
            ModifierToolObject[] modifiers = new ModifierToolObject[]
            {
                ObjectSelector.Instance,
                ObjectEraser.Instance,
                CanvasCleaner.Instance
            };

            return modifiers;
        }
        private FileToolObject[] getFileTools()
        {
            FileToolObject[] fileTools = new FileToolObject[] 
            {
                CanvasLoadingTool.Instance,
                CanvasSaveTool.Instance
            };

            return fileTools;
        }

        public void LoadAllTools()
        {
            LoadTheShapeTools();
            LoadColors();
            LoadTheModifierTools();
            LoadTheFileTools();
        }

        #endregion

        #region Canvas

        private void addCanvasEvents()
        {
            Canvas.MouseDown += canvasMouseDown;
            Canvas.MouseMove += canvasMouseMove;
            Canvas.MouseUp += canvasMouseUp;
        }

        private void canvasMouseDown(object sender , MouseEventArgs e)
        {
            drawObjectToCanvas();
        }
        private void canvasMouseMove(object sender , MouseEventArgs e)
        {
            resizeTheObject();
        }
        private void canvasMouseUp(object sender , MouseEventArgs e)
        {
            _isDrawn = false;
        }

        private void drawObjectToCanvas()
        {
            if (ObjectSelector.Instance.IsSelect || ActiveElement.Instance.ActiveShapeToolObject == null || ActiveElement.Instance.ActiveColorTool == null) return;
            _startPoint = getLocation();
            _drawenObject = ActiveElement.Instance.ActiveShapeToolObject?.createActiveObject(ActiveElement.Instance.ActiveColorTool.Color, _startPoint);
            Canvas.Controls.Add(_drawenObject);
            _drawenObject.BringToFront();
            _isDrawn = true;
        }
        private void resizeTheObject()
        {
            if (!_isDrawn) return;
            Point _endPoint = getLocation();
            int _X = _startPoint.X - _endPoint.X;
            int _Y = _startPoint.Y - _endPoint.Y;
            int size = Convert.ToInt32(Math.Pow((Math.Pow(_X, 2) + Math.Pow(_Y, 2)), 0.5));
            Point location = new Point(_startPoint.X - _drawenObject.ObjectSize / 2, _startPoint.Y - _drawenObject.ObjectSize / 2);

            if (!ShapeObject.BorderControl(location, _drawenObject.ObjectSize)) return;
            _drawenObject.ObjectSize = size;
            _drawenObject.Location = location;
        }
        
        private Point getLocation()
        {
            var _cursor = Canvas.PointToClient(Cursor.Position);
            return _cursor;
        }

        #endregion

    }
}
