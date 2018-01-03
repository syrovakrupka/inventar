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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace inventar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Inventar inventar;
        Point startPoint;
        bool jedole = false;

        public MainWindow()
        {
            InitializeComponent();

            inventar = new Inventar(canvas);
            inventar.ShowInventar();



        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            
            
            if (!jedole)
            {
                Point point = e.GetPosition(null);



                double col_index = Math.Floor(point.X / inventar.rect_width);
                double row_index = Math.Floor(point.Y / inventar.rect_height);
                bro.Content = col_index + ", " + row_index;

            } else
            {

            }
            
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var new_rect = new Rectangle();
            new_rect.Height = inventar.rect_height * Int32.Parse(dolu.Text);
            new_rect.Width = inventar.rect_width * Int32.Parse(doprava.Text);
            new_rect.Stroke = new SolidColorBrush(Colors.Yellow);
            new_rect.Fill = new SolidColorBrush(Colors.Black);
            Canvas.SetRight(new_rect, 50);
            Canvas.SetTop(new_rect, 50);

            var boi = new Trojuhelnik(new_rect, true);
            boi.rectic.MouseLeftButtonDown += mysdolu;
            boi.rectic.MouseLeftButtonUp += mysnahoru;

            canvas.Children.Add(boi.rectic);
        }

        private void mysdolu(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
            jedole = true;

            var frajer = (Rectangle)sender;
            Canvas.SetRight(frajer, 50 + startPoint.Y);
            Canvas.SetLeft(frajer, 50);


        }

        private void mysnahoru(object sender, MouseButtonEventArgs e)
        {
            jedole = false;

            // zde dojde k umisteni lol

        }
    }
}
