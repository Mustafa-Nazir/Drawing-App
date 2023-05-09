using DrawingApp.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Concrete.Tools.Modifiers
{
    public class CanvasCleaner:ModifierToolObject
    {
        private static CanvasCleaner? _instance;
        public static CanvasCleaner Instance
        {
            get
            {
                if(_instance == null ) _instance = new CanvasCleaner();
                return _instance;
            }
        }

        public CanvasCleaner()
        {
            this.Image = Image.FromFile(RootPath+@"\images\newFile.png");
        }
        protected override void toolOnClik(object sender, EventArgs e)
        {
            ClearTheCanvas();
            BorderStyleToDisable();
        }

        public void ClearTheCanvas()
        {
            ActiveElement.Instance.ActiveCanvas?.Controls.Clear();
        }

    }
}
