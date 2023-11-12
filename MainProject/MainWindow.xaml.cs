using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MainProject.helpers;
using Microsoft.VisualBasic;
using Drawing;
using System.Windows.Controls.Primitives;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Media.Converters;
using System.Diagnostics.Metrics;

namespace MainProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool paint = false;
        System.Windows.Point px, py;
        //Pen p = new Pen(Color.Black, 1);
        int index = -1;
        bool b = false;
        int line = 0;
        int ellipse = 0;
        int rectangle = 0;
        int x, y, sX, sY, cX, cY;

        Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
        Nullable<bool> result;
        Helper helper = new Helper();

        UIElementCollection uI; 

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            uI = new UIElementCollection(this, this);
            RedoButton.IsEnabled = false;
            UndoButton.IsEnabled = false;
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            dlg.FileName = "Image"; // Default file name
            dlg.DefaultExt = ".png"; // Default file extension
            dlg.Filter = "PNG File (.png)|*.png"; // Filter files by extension
            result = dlg.ShowDialog();
            if (result == true)
            {
                // Save document
                string filename = dlg.FileName;
                helper.SaveCanvasToFile(this, canvas, 512, filename);
            }
        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            dlg.FileName = "Image"; // Default file name
            dlg.DefaultExt = ".png"; // Default file extension
            dlg.Filter = "PNG File (.png)|*.png"; // Filter files by extension
            //show dialog open file
            result = dlg.ShowDialog();
            if (result == true)
            {
                // Save document
                string filename = dlg.FileName;
                ImageBrush brush = new ImageBrush();
                brush.ImageSource = new BitmapImage(new Uri(@filename, UriKind.Relative));
                canvas.Background = brush;
            }
        }

        private void RedoButton_Click(object sender, RoutedEventArgs e)
        {
            int count = uI.Count;
            UIElement uiE = uI[count - 1];
            uI.RemoveAt(count - 1);
            canvas.Children.Add(uiE);
            if (uI.Count == 0)
            {
                RedoButton.IsEnabled = false;
            }
            if (canvas.Children.Count == 0)
            {
                UndoButton.IsEnabled = false;
            }
        }

        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            int count = canvas.Children.Count;
            UIElement uiE = canvas.Children[count - 1];
            //uI.Add(canvas.Children[count - 1]);
            canvas.Children.RemoveAt(count - 1);
            uI.Add(uiE);
            RedoButton.IsEnabled = true;
            if(canvas.Children.Count == 0)
            {
                UndoButton.IsEnabled = false;
            }
            if (uI.Count == 0)
            {
                RedoButton.IsEnabled = false;
            }
        }

        private void ZoomButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private Double zoomMax = 5;
        private Double zoomMin = 0.5;
        private Double zoomSpeed = 0.001;
        private Double zoom = 1;
        private void canvas_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            zoom += zoomSpeed * e.Delta; // Ajust zooming speed (e.Delta = Mouse spin value )
            if (zoom < zoomMin) { zoom = zoomMin; } // Limit Min Scale
            if (zoom > zoomMax) { zoom = zoomMax; } // Limit Max Scale

            System.Windows.Point mousePos = e.GetPosition(canvas);

            if (zoom > 1)
            {
                canvas.RenderTransform = new ScaleTransform(zoom, zoom, mousePos.X, mousePos.Y); // transform Canvas size from mouse position
            }
            else
            {
                canvas.RenderTransform = new ScaleTransform(zoom, zoom); // transform Canvas size
            }
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            b = false;
            paint = false;
            uI.Clear();
            UndoButton.IsEnabled = true;
            RedoButton.IsEnabled = false;

            Debug.WriteLine("paint = false");
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && paint)
            {
                py = e.GetPosition(canvas);
                if (index == 0)
                {
                    //Debug.WriteLine(px.X.ToString());
                    int canvasCount = canvas.Children.Count;
                    
                    if(b && canvasCount > 0) canvas.Children.RemoveAt(canvasCount - 1);
                    canvas.Children.Add(DrawingLibrary.drawLine(

                        System.Windows.Media.Brushes.Black,
                        2,
                        px.X,
                        px.Y,
                        py.X,
                        py.Y
                    ));
                    //py = px;
                    //canvas.
                    b = true;
                }

                if (index == 1)
                {
                    int canvasCount = canvas.Children.Count;

                    if (b && canvasCount > 0) canvas.Children.RemoveAt(canvasCount - 1);
                    Ellipse ellipse = DrawingLibrary.drawEllipse(

                        System.Windows.Media.Brushes.Black,
                        2,
                        px.X,
                        px.Y,
                        py.X,
                        py.Y
                    );
                    canvas.Children.Add(ellipse);
                    Canvas.SetTop(ellipse, px.Y);
                    Canvas.SetLeft(ellipse, px.X);
                    b = true;

                }

                if (index == 2)
                {
                    int canvasCount = canvas.Children.Count;

                    if (b && canvasCount > 0) canvas.Children.RemoveAt(canvasCount - 1);
                    System.Windows.Shapes.Rectangle ellipse = DrawingLibrary.drawRectangle(

                        System.Windows.Media.Brushes.Black,
                        2,
                        px.X,
                        px.Y,
                        py.X,
                        py.Y
                    );
                    canvas.Children.Add(ellipse);
                    Canvas.SetTop(ellipse, px.Y);
                    Canvas.SetLeft(ellipse, px.X);
                    b = true;

                }
            } else
            {
                b = false;
                paint = false;
            }

        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            paint = true;
            px = e.GetPosition(canvas);

            if (index == 0) line++;
            if (index == 1) ellipse++;
            if (index == 2) rectangle++;
            
            //Debug.WriteLine("paint = true");
            //py = e.GetPosition(this);
            e.Handled = true;
        }



        private void EllipseRibbonButton_Click(object sender, RoutedEventArgs e)
        {
            index = 1;
            Debug.WriteLine("i = 1");
        }

        private void RectangleRibbonButton_Click(object sender, RoutedEventArgs e)
        {
            index = 2;
            Debug.WriteLine("i = 2");
        }

        private void LineRibbonButton_Click(object sender, RoutedEventArgs e)
        {
            index = 0;
            Debug.WriteLine("i = 0");
        }
    }
}
