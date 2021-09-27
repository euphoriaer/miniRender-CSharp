using System;
using System.Numerics;

namespace miniRenderer
{
    internal class Program
    {
        private float a = 1f;
        private float b = 1f;

        public static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            float a = 1f, b = 2f;
            Math.Sqrt(b);
            var pi = Math.Acos(-1);
            var sin30 = Math.Sin((30.0 / 180.0 * Math.PI));
            Vector3 v = new Vector3(1.0f, 2.0f, 3.0f);
            Vector3 w = new Vector3(1.0f, 0.0f, 0.0f);
            Console.WriteLine(v + w);
            Console.WriteLine(v * 2);
            Console.WriteLine(2 * v);

            Console.WriteLine("矩阵测试!");
            Matrix4X4 i = new Matrix4X4(1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 7.0f, 8.0f, 9.0f);
            Matrix4X4 j = new Matrix4X4(2.0f, 3.0f, 1.0f, 4.0f, 6.0f, 5.0f, 9.0f, 7.0f, 8.0f);
            Console.WriteLine(i);

            //point
            Vector3 pointPa = new Vector3(1, 1, 1);
            Console.WriteLine("逆时针旋转45°  数学上是  +45° 所以计算弧度制\n");
            double Rad45 = (45.0 / 180.0 * Math.PI);

            //rotate
            Matrix4X4 rotate = new Matrix4X4(
                Math.Cos(Rad45), -Math.Sin(Rad45), 0,
                Math.Sin(Rad45), Math.Cos(Rad45), 0,
                0, 0, 1
            );
            //trans
            Matrix4X4 transform = new Matrix4X4(
                1, 0, 1,
                0, 1, 2,
                0, 0, 1
            );
            
            Matrix4X4 homogeneous = new Matrix4X4(new Vector3((float)Math.Cos(Rad45), -(float)Math.Sin(Rad45), 1), new Vector3((float)Math.Sin(Rad45), (float)Math.Cos(Rad45), 2), new Vector3(0, 0, 1));

            var fin = homogeneous * pointPa;
            //计算
            Console.WriteLine(fin);
        }
    }
}