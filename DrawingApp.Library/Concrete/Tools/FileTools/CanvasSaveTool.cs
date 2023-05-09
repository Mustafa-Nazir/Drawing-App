using DrawingApp.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using DrawingApp.Library.Concrete.DTO;

namespace DrawingApp.Library.Concrete.Tools.FileTools
{
    public class CanvasSaveTool:FileToolObject
    {
        private static CanvasSaveTool ? _instance;
        public static CanvasSaveTool Instance
        {
            get
            {
                if(_instance == null ) _instance = new CanvasSaveTool();
                return _instance;
            }
        }

        public CanvasSaveTool()
        {
            this.Image = Image.FromFile(@"..\images\save.png");
        }

        protected override void toolOnClick(object sender, EventArgs e)
        {
            saveCanvas();
            BorderStyleToDisable();
        }

        private void saveCanvas()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK && ActiveElement.Instance.ActiveCanvas != null)
                {
                    string filePath = saveFileDialog.FileName;
                    using (TextWriter tw = new StreamWriter(filePath))
                    {
                        string jsonStr = JsonSerializer.Serialize(getShapes());
                        tw.WriteLine(jsonStr);
                    }
                } 
            }
        }

        private List<ShapeDto> getShapes()
        {
            List<ShapeDto> shapes = new List<ShapeDto>();
            foreach (ShapeObject item in ActiveElement.Instance.ActiveCanvas.Controls.OfType<ShapeObject>())
            {
                Point location = item.Location;
                SolidBrush color = (SolidBrush)item.ObjectColor;
                int colorARGB = color.Color.ToArgb();
                string shapeType = item.GetType().ToString();
                int size = item.ObjectSize;
                bool isActive  = ActiveElement.Instance?.ActiveObject == item;
                shapes.Add(new ShapeDto() { ColorARGB = colorARGB , Location = location, ShapeType = shapeType ,ObjectSize=size,IsActive=isActive});
            }

            return shapes;
        }

    }
}
