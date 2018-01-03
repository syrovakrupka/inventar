using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;


namespace inventar
{
    class Inventar
    {

        public int rows = 5;
        public int columns = 4;
        public int rect_width = 50;
        public int rect_height = 50;

        public int[,] item_id;
        public Canvas canvas;
        
        public Inventar(Canvas canvas)
        {
            item_id = new int[rows, columns];
            this.canvas = canvas;
        }



        public void ShowInventar()
        {

            for (var i = 0; i < rows; i++)
            {
                for (var x = 0; x < columns; x++)
                {

                    Rectangle rect = new Rectangle();
                    rect.Stroke = new SolidColorBrush(Colors.White);
                    rect.Fill = new SolidColorBrush(Colors.LightGray);
                    rect.Width = rect_width;
                    rect.Height = rect_height;
                    Canvas.SetLeft(rect, rect_width*x);
                    Canvas.SetTop(rect, rect_height*i);

                    var bis = new Trojuhelnik(rect, false);


                    canvas.Children.Add(bis.rectic);
                }

            }
        }


    }
}
