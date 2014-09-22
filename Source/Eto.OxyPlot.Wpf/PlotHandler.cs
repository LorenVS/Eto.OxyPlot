using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eto.Drawing;
using Eto.Wpf;
using Eto.Wpf.Forms;
using OxyPlot;
using OxyPlot.Wpf;

namespace Eto.OxyPlot.Wpf
{
    public class PlotHandler : WpfFrameworkElement<PlotView, Plot, Plot.ICallback>, Plot.IHandler
    {
        public override Color BackgroundColor
        {
            get { return Control.PlotAreaBackground.ToEtoColor(); }
            set { Control.PlotAreaBackground = value.ToWpfBrush(Control.PlotAreaBackground); }
        }

        public PlotModel Model
        {
            get { return Control.Model; }
            set { Control.Model = value; }
        }

        public PlotHandler()
        {
            Control = new global::OxyPlot.Wpf.PlotView()
            {
            };
        }
    }
}
