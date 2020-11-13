using System.Drawing;
namespace imagene
{
    class Program
    {
        public static double GetDistance2D(double x1, double y1, double x2, double y2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;
            return System.Math.Sqrt(vx * vx + vy * vy);

        }



        public static void FillImageWithColor(Bitmap image, Color color)
        {

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    image.SetPixel(x, y, color);
                }

            }


        }


        public static void FillCircle(Bitmap image, Color color, double xcenter, double ycenter, double radius)
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    if (GetDistance2D(xcenter, ycenter, x, y) < radius)
                    {
                        image.SetPixel(x, y, color);
                    }
                }

            }

        }


        public static void DrawTeachersFace(Bitmap image)
        {
            FillImageWithColor(image, Color.White);

            FillCircle(image, Color.Black, 250, 150, 120);

            FillCircle(image, Color.Yellow, 250, 150, 100);

            FillCircle(image, Color.White, 210, 120, 30);
            FillCircle(image, Color.CadetBlue, 210, 120, 15);
            FillCircle(image, Color.Black, 210, 120, 10);
            FillCircle(image, Color.White, 220, 120, 5);

            FillCircle(image, Color.White, 290, 120, 30);
            FillCircle(image, Color.CadetBlue, 290, 120, 15);
            FillCircle(image, Color.Black, 290, 120, 10);
            FillCircle(image, Color.White, 300, 120, 5);

            FillCircle(image, Color.Brown, 250, 150, 15);

            FillCircle(image, Color.Black, 250, 200, 10);

        }


        public static void DrawJapaneseFlag(Bitmap image)
        {
            FillImageWithColor(image, Color.White);
            FillCircle(image, Color.Red, image.Width / 2, image.Height / 2, image.Height / 4);

          
        }




        static void Main(string[] args)
        {
            Bitmap bitmap = new Bitmap(500, 300);


           // DrawJapaneseFlag(bitmap);

            DrawTeachersFace(bitmap);

          

            bitmap.Save("C:\\Users\\blanco20958\\Desktop\\repos\\prueba.png");

            

        }
        








    }

}
