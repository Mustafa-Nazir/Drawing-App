using DrawingApp.Library.Abstract;
using DrawingApp.Library.Concrete.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using DrawingApp.Library.Concrete.Tools.Modifiers;

namespace DrawingApp.Library.Concrete.Tools.FileTools
{
    public class CanvasLoadingTool:FileToolObject
    {
        private static CanvasLoadingTool? _instance;
        public static CanvasLoadingTool Instance
        {
            get
            {
                if (_instance == null) _instance = new CanvasLoadingTool();
                return _instance;
            }
        }

        public CanvasLoadingTool()
        {
            this.Image = Image.FromFile(RootPath+@"\images\folderOpen.png");
        }

        protected override void toolOnClick(object sender, EventArgs e)
        {
            loadCanvas();
            BorderStyleToDisable();
        }

        private void loadCanvas()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string jsonString = File.ReadAllText(filePath);
                    List<ShapeDto> shapeDtos = JsonSerializer.Deserialize<List<ShapeDto>>(jsonString);
                    CanvasCleaner.Instance.ClearTheCanvas();
                    createShapes(shapeDtos);
                }
            }
        }

        private void createShapes(List<ShapeDto> shapeDtos)
        {
            foreach (ShapeDto shapeDto in shapeDtos)
            {
                Type type = Type.GetType(shapeDto.ShapeType);
                Color colorARGB = Color.FromArgb(shapeDto.ColorARGB);
                Brush color = new SolidBrush(colorARGB);
                Point location = shapeDto.Location;
                int size = shapeDto.ObjectSize;

                ShapeObject shape = (ShapeObject)Activator.CreateInstance(type, color, location);
                shape.ObjectSize = size;
                activeShapeControl(shapeDto.IsActive , shape);
                ActiveElement.Instance.ActiveCanvas.Controls.Add(shape);
            }
        }

        private void activeShapeControl(bool isActive, ShapeObject shape)
        {
            if (!isActive) return;
            ObjectSelector.Instance.SetActive();
            shape.SetActiveObject();
        }
    }
}
