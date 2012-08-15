//-----------------------------------------------------------------------
// <copyright file="TimeLineGraph.cs" company="Microsoft Corporation and Crown copyright 2007 - 2010.">
// Copyright (c) Microsoft Corporation and Crown copyright 2007 - 2010.
// All rights reserved.
//
// CERTAIN PARTS OF THIS WORK CONTAIN SOFTWARE CODE THAT IS LICENSED 
// FOR USE UNDER THE MICROSOFT PUBLIC LICENSE. DISTRIBUTION, IN SOURCE CODE 
// OR OBJECT CODE FORM, OF THOSE PARTS MUST COMPLY WITH THE TERMS OF THE 
// PUBLIC LICENSE. SEE http://www.microsoft.com/opensource/licenses.mspx 
// FOR DETAILS.  
// IF YOU BRING A PATENT CLAIM AGAINST ANY CONTRIBUTOR OVER PATENTS THAT 
// YOU CLAIM ARE INFRINGED BY THE PUBLIC LICENSE SOFTWARE, YOUR PATENT 
// LICENSE FROM SUCH CONTRIBUTOR TO THE SOFTWARE ENDS AUTOMATICALLY.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
// </copyright>
// <date>05-Sep-2008</date>
// <summary>Time line graph class.</summary>
//-----------------------------------------------------------------------

namespace Microsoft.Cui.Controls
{
    #region Using
    using System;
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;
    using System.Windows.Media;
    using System.Windows.Shapes;
    using Microsoft.Cui.Controls.GraphingControl;

    #endregion

    /// <summary>
    /// Timeline graph control.
    /// </summary>
    [TemplatePart(Name = LayoutRootElementName, Type = typeof(Panel))]
    [TemplatePart(Name = DynamicMainLayerViewportElementName, Type = typeof(Canvas))]
    [TemplatePart(Name = NonDynamicRightAxisViewPortElementName, Type = typeof(Canvas))]
    [TemplatePart(Name = DynamicMainLayerTemplateElementName, Type = typeof(DataTemplate))]
    [TemplatePart(Name = NonDynamicRightAxisLabelsLayerElementName, Type = typeof(Canvas))]
    [TemplatePart(Name = NonDynamicRightAxisLinesLayerElementName, Type = typeof(Canvas))]
    [TemplatePart(Name = DataMarkerResourceKey, Type = typeof(DataTemplate))]
    [TemplatePart(Name = DataPointTemplateResourceKey, Type = typeof(DataTemplate))]
    [TemplatePart(Name = DataPointLabelTemplateResourceKey, Type = typeof(DataTemplate))]
    [TemplatePart(Name = DataPointLabelTransformResourceKey, Type = typeof(Transform))]
    [TemplatePart(Name = HorizontalScrollBarElementName, Type = typeof(ScrollBar))]
    [TemplatePart(Name = VerticalScrollBarElementName, Type = typeof(ScrollBar))]
    [TemplatePart(Name = ArrowButtonUpElementName, Type = typeof(Button))]
    [TemplatePart(Name = ArrowButtonDownElementName, Type = typeof(Button))]
    [TemplatePart(Name = FocusVisualElementName, Type = typeof(UIElement))]
    [TemplatePart(Name = MinimizeToTitleElementName, Type = typeof(Button))]
    [TemplatePart(Name = ScaleToFitElementName, Type = typeof(Button))]
    [TemplatePart(Name = TitleAreaElementName, Type = typeof(FrameworkElement))]
    public class TimeLineGraph : TimeAndYGraphBase, ISupportInterpolation
    {
        #region Dependency Properties
        /// <summary>
        /// Identifies the <see cref="Microsoft.Cui.Controls.TimeLineGraph.ShowInterpolationLines"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ShowInterpolationLinesProperty = DependencyProperty.Register("ShowInterpolationLines", typeof(bool), typeof(TimeLineGraph), new PropertyMetadata(new PropertyChangedCallback(GraphPropertiesChanged)));

        /// <summary>
        /// Identifies the <see cref="Microsoft.Cui.Controls.TimeLineGraph.InterpolationLineColor"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty InterpolationLineColorProperty = DependencyProperty.Register("InterpolationLineColor", typeof(Brush), typeof(TimeLineGraph), new PropertyMetadata(new PropertyChangedCallback(GraphPropertiesChanged)));

        /// <summary>
        /// Identifies the <see cref="Microsoft.Cui.Controls.TimeLineGraph.InterpolationLineThickness"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty InterpolationLineThicknessProperty = DependencyProperty.Register("InterpolationLineThickness", typeof(double), typeof(TimeLineGraph), new PropertyMetadata(new PropertyChangedCallback(GraphPropertiesChanged)));
        #endregion

        #region Constants
        /// <summary>
        /// Marker Count.
        /// </summary>
        private static int markerCount = 100000;

        /// <summary>
        /// Marker Count Start.
        /// </summary>
        private static int markerCountStart = 100000;
        
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeLineGraph"/> class.
        /// </summary>
        public TimeLineGraph()
        {
            this.DefaultStyleKey = typeof(TimeLineGraph);

            this.ShowInterpolationLines = true;
            this.InterpolationLineThickness = 2;
            this.InterpolationLineColor = new SolidColorBrush(Colors.Orange);
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets a value indicating whether to show interpolation lines.
        /// </summary>
        /// <value>Boolean indicating whether to show interpolation lines.</value>
        [Category("Graph Appearance")]
        public bool ShowInterpolationLines
        {
            get { return (bool)this.GetValue(ShowInterpolationLinesProperty); }
            set { this.SetValue(ShowInterpolationLinesProperty, value); }
        }

        /// <summary>
        /// Gets or sets the Color to be used for interpolation line.
        /// </summary>
        /// <value>Brush used to paint interpolation line.</value>
        [Category("Graph Appearance")]
        public Brush InterpolationLineColor
        {
            get { return (Brush)this.GetValue(InterpolationLineColorProperty); }
            set { this.SetValue(InterpolationLineColorProperty, value); }
        }

        /// <summary>
        /// Gets or sets the thickness of the interpolation line.
        /// </summary>
        /// <value>Thickness of the interpolation line.</value>
        [Category("Graph Appearance")]
        public double InterpolationLineThickness
        {
            get { return (double)this.GetValue(InterpolationLineThicknessProperty); }
            set { this.SetValue(InterpolationLineThicknessProperty, value); }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Overridden. Resets the layout of the graph to the defaults.
        /// </summary>
        public override void Reset()
        {
            base.Reset();
            this.ShowInterpolationLines = true;
            this.GetLastPointToView();
        }

        /// <summary>
        /// Gets the symbol for the datapoint.
        /// </summary>
        /// <param name="graphPoint">Point at which the symbol needs to be positioned.</param>        
        /// <returns>A symbol at a specified position.</returns>
        protected override FrameworkElement GetPlottedDataMarker(GraphPoint graphPoint)
        {
            FrameworkElement dataMarkerTemplate = this.DataMarkerTemplate.LoadContent() as FrameworkElement;

            if (dataMarkerTemplate == null)
            {
                throw new ArgumentException(GraphingResources.GraphDisplayDataMarkerError);
            }

            Canvas.SetLeft(dataMarkerTemplate, graphPoint.X1Pixel + GraphBase.GetXOffset(dataMarkerTemplate));
            Canvas.SetTop(dataMarkerTemplate, graphPoint.Y1Pixel + GraphBase.GetYOffset(dataMarkerTemplate));

            if (true == this.DebugDataPointMarkers)
            {
                TextBlock tb = new TextBlock();
                tb.FontSize = 8;
                markerCount++;
                tb.Text = (markerCount - markerCountStart).ToString(System.Globalization.CultureInfo.InvariantCulture);
                Canvas.SetZIndex(tb, markerCount);
                Canvas.SetLeft(tb, graphPoint.X1Pixel);
                Canvas.SetTop(tb, graphPoint.Y1Pixel);
                this.DynamicPlotLayer.Children.Add(tb);
                System.Diagnostics.Debug.WriteLine("Added point at " + graphPoint.X1Pixel + " : " + graphPoint.Y1Pixel + " : " + dataMarkerTemplate.ActualHeight + " : " + dataMarkerTemplate.ActualWidth + " Point ID IS : " + tb.Text);
            }

            GraphBase.SetDataPoint(dataMarkerTemplate, true);
            dataMarkerTemplate.Tag = (markerCount - markerCountStart).ToString(System.Globalization.CultureInfo.InvariantCulture);
            return dataMarkerTemplate;
        }

        /// <summary>
        /// Overridden. process the Point based on the previous value.
        /// </summary>
        /// <param name="previousPoint">Previous Point Plotted.</param>
        /// <param name="currentPoint">Current Point Plotted.</param>
        protected override void ProcessPlottedDataMarker(GraphPoint previousPoint, GraphPoint currentPoint)
        {
            if (this.Minimized)
            {
                base.ProcessPlottedDataMarker(previousPoint, currentPoint);
            }
            else
            {
                // override to process other information
                if ((previousPoint.X1Pixel != 0 || previousPoint.Y1Pixel != 0) && this.ShowInterpolationLines)
                {
                    // define the zindex for the line based on that of the data marker
                    FrameworkElement dataMarkerTemplate = this.DataMarkerTemplate.LoadContent() as FrameworkElement;
                    int zindex = Canvas.GetZIndex(dataMarkerTemplate) - 2;

                    Line interpolationLine = new Line();
                    Canvas.SetZIndex(interpolationLine, zindex);
                    interpolationLine.Stroke = this.InterpolationLineColor;
                    interpolationLine.StrokeThickness = this.InterpolationLineThickness;

                    if (previousPoint.X1Pixel < 0)
                    {
                        interpolationLine.Y1 = TimeLineGraph.GetYAtX(0, new Point(previousPoint.X1Pixel, previousPoint.Y1Pixel), new Point(currentPoint.X1Pixel, currentPoint.Y1Pixel));
                        interpolationLine.X1 = 0;
                    }
                    else
                    {
                        interpolationLine.X1 = previousPoint.X1Pixel;
                        interpolationLine.Y1 = previousPoint.Y1Pixel;
                    }

                    if (currentPoint.X1Pixel > this.DynamicMainLayerViewport.ActualWidth)
                    {
                        interpolationLine.Y2 = TimeLineGraph.GetYAtX(this.DynamicMainLayerViewport.ActualWidth, new Point(previousPoint.X1Pixel, previousPoint.Y1Pixel), new Point(currentPoint.X1Pixel, currentPoint.Y1Pixel));
                        interpolationLine.X2 = this.DynamicMainLayerViewport.ActualWidth;
                    }
                    else
                    {
                        interpolationLine.X2 = currentPoint.X1Pixel;
                        interpolationLine.Y2 = currentPoint.Y1Pixel;
                    }

                    this.DynamicPlotLayer.Children.Add(interpolationLine);
                }
            }
        }
        #endregion     

        #region Static Methods
        /// <summary>
        /// Gets the value of Y for a line passing between two points.
        /// </summary>
        /// <param name="x">Offset at which value of Y needs to be calculated.</param>
        /// <param name="startPoint">Start point of the line.</param>
        /// <param name="endPoint">End point of the line.</param>
        /// <returns>Value of Y in the line at the given X co-ordinate.</returns>
        private static double GetYAtX(double x, Point startPoint, Point endPoint)
        {
            double y = 0;

            // slope of line m=(y2-y1)/(x2-x1)
            double slope = (endPoint.Y - startPoint.Y) / (endPoint.X - startPoint.X);

            // slope intercept form y=mx+b or b=y-mx
            double intercept = startPoint.Y - (slope * startPoint.X);

            // y at given x
            y = (slope * x) + intercept;

            return y;
        }
        #endregion
    }
}