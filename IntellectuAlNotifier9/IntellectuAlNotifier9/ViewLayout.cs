using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace IntellectuAlNotifierDesktop
{
    public class ViewboxPanel : Panel
    {
        private double scale;

        protected override Size MeasureOverride(Size availableSize)
        {
            double height = 0;
            Size unlimitedSize = new Size(double.PositiveInfinity, double.PositiveInfinity);
            foreach (UIElement child in Children)
            {
                child.Measure(unlimitedSize);
                height += child.DesiredSize.Height;
            }
            scale = availableSize.Height / height;

            foreach (UIElement child in Children)
            {
                unlimitedSize.Width = availableSize.Width / scale;
                child.Measure(unlimitedSize);
            }

            return availableSize;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            Transform scaleTransform = new ScaleTransform(scale, scale);
            double height = 0;
            foreach (UIElement child in Children)
            {
                child.RenderTransform = scaleTransform;
                child.Arrange(new Rect(new Point(0, scale * height), new Size(finalSize.Width / scale, child.DesiredSize.Height)));
                height += child.DesiredSize.Height;
            }

            return finalSize;
        }
    }
}
