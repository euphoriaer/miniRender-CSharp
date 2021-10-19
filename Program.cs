using System;
using System.Drawing;
using System.Numerics;

namespace miniRenderer
{
    internal class Program
    {
        private float a = 1f;
        private float b = 1f;

        public static void Main(string[] args)
        {
            //需要一个窗口显示

            //
            
        }

   

        Matrix4X4 get_model_matrix(float rotation_angle)
        {
            Matrix4X4 model = Matrix4x4.Identity;
            return model;
        }

        public Matrix4X4 get_view_matrix(Vector3 eye_pos)
        {
            var view = Matrix4x4.Identity;
            Matrix4X4 translate = new Matrix4X4(
                1, 0, 0, -eye_pos.X, 
                0, 1, 0, -eye_pos.Y,
                0, 0, 1, -eye_pos.Z,
                0, 0, 0, 1);
            view = translate * view;
            return view;
        }

        public Matrix4X4 get_projection_matrix(float eye_fov, float aspect_ratio,
                                      float zNear, float zFar)
        {
            // Students will implement this function

            Matrix4X4 projection = new Matrix4X4();

            // TODO: Implement this function
            // Create the projection matrix for the given parameters.
            // Then return it.

            return projection;
        }

        private static void MatrixTest()
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