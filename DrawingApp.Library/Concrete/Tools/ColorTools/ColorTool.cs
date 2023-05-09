using DrawingApp.Library.Abstract;
using DrawingApp.Library.Concrete.Tools.Modifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Concrete.Tools.ColorTools
{
    public class ColorTool:BaseToolObject
    {
        public Brush Color { get; set; }
        public ColorTool(Brush color)
        {
            Color = color;
            this.Paint += paintObject;
        }

        private void paintObject(object sender , PaintEventArgs e)
        {
            int borderW2 = ObjectSize - borderWidth * 2;
            e.Graphics.FillRectangle(Color,borderWidth,borderWidth,borderW2,borderW2);
        }

        protected override void ObjectOnClick(object sender, EventArgs e)
        {
            changeSelection();
            changeObjectColor();
        }

        private void changeSelection()
        {
            if (ActiveElement.Instance.ActiveColorTool == this) return;
            if (ActiveElement.Instance.ActiveColorTool != null)
            {
                ActiveElement.Instance.ActiveColorTool.BorderStyleToDisable();
            }
            ActiveElement.Instance.ActiveColorTool = this;
            BorderStyleToEnable();
        }

        private void changeObjectColor()
        {
            if(ObjectSelector.Instance.IsSelect && ActiveElement.Instance.ActiveObject != null)
            {
                ActiveElement.Instance.ActiveObject.ObjectColor = this.Color;
                ActiveElement.Instance.ActiveObject.Refresh();
            }
        }

    }
}
