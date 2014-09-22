using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eto.Forms;
using OxyPlot;

namespace Eto.OxyPlot
{
    /// <summary>
    /// Control to display an OxyPlot plot
    /// </summary>
    [Handler(typeof(Plot.IHandler))]
    public class Plot : Control
    {
        new IHandler Handler { get { return (IHandler)base.Handler; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="Eto.OxyPlot.Plot"/> class.
        /// </summary>
        public Plot()
        {
        }
        
        /// <summary>
        /// Gets or sets the plot model.
        /// </summary>
        /// <value>The plot model.</value>
        public PlotModel Model
        {
            get { return Handler.Model; }
            set { Handler.Model = value; }
        }

        /// <summary>
        /// Handler interface for the <see cref="Plot"/>
        /// </summary>
        public new interface IHandler : Control.IHandler
        {
            /// <summary>
            /// Gets or sets the plot model
            /// </summary>
            /// <value>The plot model.</value>
            PlotModel Model { get; set; }
        }
    }
}
