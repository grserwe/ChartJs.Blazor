﻿using ChartJs.Blazor.Common.Enums;
using ChartJs.Blazor.Common.Axes.Ticks;
using ChartJs.Blazor.LineChart;
using ChartJs.Blazor.BarChart;
using Newtonsoft.Json;

namespace ChartJs.Blazor.Common.Axes
{
    /// <summary>
    /// As per documentation <a href="https://www.chartjs.org/docs/latest/axes/cartesian/#common-configuration">here (Chart.js)</a>.
    /// </summary>
    public abstract class CartesianAxis : Axis
    {
        /// <summary>
        /// The type of axis this instance represents.
        /// <para>For js-interop/serialization purposes so Chart.js knows what axis to use.</para>
        /// </summary>
        public abstract AxisType Type { get; }

        /// <summary>
        /// The ID is used to link <see cref="LineDataset{T}"/>/<see cref="BarDataset{T}"/> and <see cref="CartesianAxis"/> together.
        /// Referenced in <see cref="LineDataset{T}.XAxisId"/> and <seealso cref="LineDataset{T}.YAxisId"/>
        /// (<see cref="BarDataset{T}.XAxisId"/> and <seealso cref="BarDataset{T}.YAxisId"/> respectively).
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the position of the axis in the chart.
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// If true, extra space is added to the both edges and the axis is scaled to fit into the chart area.
        /// This is set to true for a category scale in a bar chart by default.
        /// </summary>
        public bool? Offset { get; set; }

        /// <summary>
        /// Gets or sets the scale title configuration.
        /// </summary>
        public ScaleLabel ScaleLabel { get; set; }

        /// <summary>
        /// Defines options for the grid lines that run perpendicular to the axis.
        /// </summary>
        public GridLines GridLines { get; set; }
    }

    /// <summary>
    /// <see cref="CartesianAxis"/> which contains the ticks-subconfig.
    /// </summary>
    /// <typeparam name="TTicks"></typeparam>
    public abstract class CartesianAxis<TTicks> : CartesianAxis where TTicks : CartesianTicks
    {
        /// <summary>
        /// Defines options for the tick marks that are generated by the axis.
        /// </summary>
        public TTicks Ticks { get; set; }
    }
}
