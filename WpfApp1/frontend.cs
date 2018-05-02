using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
namespace WpfApp1
{
    class frontend
    {
        private void createline(double x1, double x2, double y1, double y2,Grid grid)
        {
            Line line = new Line();
            line.X1 = x1;
            line.X2 = x2;
            line.Y1 = y1;
            line.Y1 = y1;
            line.Y2 = y2;
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Colors.Black;
            line.Stroke = brush;
            line.StrokeThickness = 2;
            grid.Children.Add(line);
        }
        private void createR(double left, double top, bool a, Grid grid)
        {
            Rectangle res = new Rectangle();
            if (a)
            {
                res.Height = 25;
                res.Width = 50;
            }
            else
            {
                res.Height = 50;
                res.Width = 25;
            }
            res.StrokeThickness = 2;
            res.HorizontalAlignment = HorizontalAlignment.Left;
            res.VerticalAlignment = VerticalAlignment.Top;
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Colors.Black;
            res.Stroke = brush;
            res.Margin = new Thickness(left, top, 0, 0);
            grid.Children.Add(res);
        }
        private void createelipse(double left,double top,Grid grid,bool a)
        {
            Ellipse el = new Ellipse();
            if (a)
            {
                Rect r = new Rect(0, -12.5, 25, 25);
                RectangleGeometry rec = new RectangleGeometry(r);
                el.Clip = rec;
            }
            else
            {
                Rect r = new Rect(-12.5, 0, 25, 25);
                RectangleGeometry rec = new RectangleGeometry(r);
                el.Clip = rec;
            }
            el.Height = 25;
            el.Width = 25;
            el.StrokeThickness = 2;
            el.HorizontalAlignment = HorizontalAlignment.Left;
            el.VerticalAlignment = VerticalAlignment.Top;
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Colors.Black;
            el.Stroke = brush;
            el.Margin = new Thickness(left, top, 0, 0);
            grid.Children.Add(el);
        }
        private void createC(double x,double y,bool a,Grid grid)
        {
            if (a)
            {
                createline(x, x, y, y+25, grid);
                createline(x + 10, x + 10, y, y+25, grid);
            }
            else
            {
                createline(x, x+25, y, y, grid);
                createline(x, x+25, y+10, y+10, grid);
            }
        }
        private void createtext(double x, double y,string name,Grid grid)
        {
            TextBox t = new TextBox();
            t.Name = name;
            t.Width = 50;
            t.Height = 25;
            t.HorizontalAlignment = HorizontalAlignment.Left;
            t.VerticalAlignment = VerticalAlignment.Top;
            t.Margin = new Thickness(x, y, 0, 0);
            grid.Children.Add(t);
        }
        private void createlabel(double x, double y, string name, string content, Grid grid)
        {
            Label l = new Label();
            l.Name = name;
            l.Width = 50;
            l.Height = 25;
            l.HorizontalAlignment = HorizontalAlignment.Left;
            l.VerticalAlignment = VerticalAlignment.Top;
            l.Content = content;
            l.Margin = new Thickness(x, y, 0, 0);
            grid.Children.Add(l);
        }
        public void makehor(Grid grid)
        {
            createlabel(30, 100, "label3", "f:", grid);
            createtext(55, 100, "f", grid);
            createline(50, 100, 62.5, 62.5, grid);
            createR(100, 50, true, grid);
            createlabel(75, 25, "label1", "R:", grid);
            createtext(100, 25, "R", grid);
            createline(150, 275, 62.5, 62.5, grid);
            createline(212.5, 212.5, 62.5, 115, grid);
            createlabel(130, 105, "label2", "C:", grid);
            createtext(150, 105, "C", grid);
            createC(200,115,false,grid);
            createline(212.5, 212.5, 125, 175, grid);
            createline(50, 275, 175, 175, grid);
        }
        public void makedol(Grid grid)
        {
            createlabel(30, 100, "label3", "f:", grid);
            createtext(55, 100, "f", grid);
            createline(50, 125, 62.5, 62.5, grid);
            createC(125, 50, true, grid);
            createtext(150, 105, "R", grid);
            createlabel(75, 25, "label1", "C:", grid);
            createline(135, 275, 62.5, 62.5, grid);
            createline(212.5, 212.5, 62.5, 100, grid);
            createtext(100, 25, "C", grid);
            createlabel(130, 105, "label2", "R:", grid);
            createR(200, 100, false, grid);
            createline(212.5, 212.5, 150, 175, grid);
            createline(50, 275, 175, 175, grid);
        }
    }
    
}
