using System;
using System.Numerics;

namespace miniRenderer
{
    internal class Matrix4X4
    {
        public double m11;
        public double m12;
        public double m13;
        public double m14;

        public double m21;
        public double m22;
        public double m23;
        public double m24;

        public double m31;
        public double m32;
        public double m33;
        public double m34;

        public double m41;
        public double m42;
        public double m43;
        public double m44;

        /// <summary>
        /// 构造秩为3的矩阵
        /// </summary>
        /// <param name="vector3"></param>
        /// <param name=""></param>
        public Matrix4X4(Vector3 row1, Vector3 row2, Vector3 row3
            )
        {
            this.m11 = row1.X;
            this.m12 = row1.Y;
            this.m13 = row1.Z;
            this.m14 = 0;
            this.m21 = row2.X;
            this.m22 = row2.Y;
            this.m23 = row2.Z;
            this.m24 = 0;
            this.m31 = row3.X;
            this.m32 = row3.Y;
            this.m33 = row3.Z;
            this.m34 = 0;
            this.m41 = 0;
            this.m42 = 0;
            this.m43 = 0;
            this.m44 = 0;
        }

        public Matrix4X4(double m11 = 0f
        , double m12 = 0f
        , double m13 = 0f
        , double m14 = 0f

        , double m21 = 0f
        , double m22 = 0f
        , double m23 = 0f
        , double m24 = 0f

        , double m31 = 0f
        , double m32 = 0f
        , double m33 = 0f
        , double m34 = 0f

        , double m41 = 0f
        , double m42 = 0f
        , double m43 = 0f
        , double m44 = 0f)
        {
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m14 = m14;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m24 = m24;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
            this.m34 = m34;
            this.m41 = m41;
            this.m42 = m42;
            this.m43 = m43;
            this.m44 = m44;
        }

        private static double SixNumMult(double m11, double m12, double m13, double m14, double m21, double m22, double m23,
            double m24)
        {
            return m11 * m21 + m12 * m22 + m13 * m23 + m14 * m24;
        }

        private static double SixNumMult(double m11, double m12, double m13, double m21, double m22, double m23)
        {
            return m11 * m21 + m12 * m22 + m13 * m23;
        }

        public static Vector3 operator *(Matrix4X4 matrix1, Vector3 vector)
        {
            double rem11 = SixNumMult(matrix1.m11, matrix1.m12, matrix1.m13, vector.X, vector.Y, vector.Z);
            double rem12 = SixNumMult(matrix1.m21, matrix1.m22, matrix1.m23, vector.X, vector.Y, vector.Z);
            double rem13 = SixNumMult(matrix1.m31, matrix1.m32, matrix1.m33, vector.X, vector.Y, vector.Z);
            return new Vector3((float)rem11, (float)rem12, (float)rem13);
        }

        public static Matrix4X4 operator *(Matrix4X4 matrix1, Matrix4X4 matrix2)
        {
            //按行计算
            double rem11 = SixNumMult(matrix1.m11, matrix1.m12, matrix1.m13, matrix1.m14, matrix2.m11, matrix2.m21, matrix2.m31, matrix2.m41);
            double rem12 = SixNumMult(matrix1.m11, matrix1.m12, matrix1.m13, matrix1.m14, matrix2.m12, matrix2.m22, matrix2.m32, matrix2.m42);
            double rem13 = SixNumMult(matrix1.m11, matrix1.m12, matrix1.m13, matrix1.m14, matrix2.m13, matrix2.m23, matrix2.m33, matrix2.m43);
            double rem14 = SixNumMult(matrix1.m11, matrix1.m12, matrix1.m13, matrix1.m14, matrix2.m14, matrix2.m24, matrix2.m34, matrix2.m44);
            double rem21 = SixNumMult(matrix1.m21, matrix1.m22, matrix1.m23, matrix1.m24, matrix2.m11, matrix2.m21, matrix2.m31, matrix2.m41);
            double rem22 = SixNumMult(matrix1.m21, matrix1.m22, matrix1.m23, matrix1.m24, matrix2.m12, matrix2.m22, matrix2.m32, matrix2.m42);
            double rem23 = SixNumMult(matrix1.m21, matrix1.m22, matrix1.m23, matrix1.m24, matrix2.m13, matrix2.m23, matrix2.m33, matrix2.m43);
            double rem24 = SixNumMult(matrix1.m21, matrix1.m22, matrix1.m23, matrix1.m24, matrix2.m14, matrix2.m24, matrix2.m34, matrix2.m44);
            double rem31 = SixNumMult(matrix1.m31, matrix1.m32, matrix1.m33, matrix1.m34, matrix2.m11, matrix2.m21, matrix2.m31, matrix2.m41);
            double rem32 = SixNumMult(matrix1.m31, matrix1.m32, matrix1.m33, matrix1.m34, matrix2.m12, matrix2.m22, matrix2.m32, matrix2.m42);
            double rem33 = SixNumMult(matrix1.m31, matrix1.m32, matrix1.m33, matrix1.m34, matrix2.m13, matrix2.m23, matrix2.m33, matrix2.m43);
            double rem34 = SixNumMult(matrix1.m31, matrix1.m32, matrix1.m33, matrix1.m34, matrix2.m14, matrix2.m24, matrix2.m34, matrix2.m44);
            double rem41 = SixNumMult(matrix1.m41, matrix1.m42, matrix1.m43, matrix1.m44, matrix2.m11, matrix2.m21, matrix2.m31, matrix2.m41);
            double rem42 = SixNumMult(matrix1.m41, matrix1.m42, matrix1.m43, matrix1.m44, matrix2.m12, matrix2.m22, matrix2.m32, matrix2.m42);
            double rem43 = SixNumMult(matrix1.m41, matrix1.m42, matrix1.m43, matrix1.m44, matrix2.m13, matrix2.m23, matrix2.m33, matrix2.m43);
            double rem44 = SixNumMult(matrix1.m41, matrix1.m42, matrix1.m43, matrix1.m44, matrix2.m14, matrix2.m24, matrix2.m34, matrix2.m44);
            Matrix4X4 retu = new Matrix4X4(rem11, rem12, rem13, rem14, rem21, rem22, rem23, rem24, rem31, rem32, rem33, rem34, rem41, rem42, rem43, rem44);
            return retu;
        }

        public static Matrix4X4 operator +(Matrix4X4 matrix1, Matrix4X4 matrix2)
        {
            //按行计算
            double rem11 = matrix1.m11 + matrix2.m11;
            double rem12 = matrix1.m12 + matrix2.m12;
            double rem13 = matrix1.m13 + matrix2.m13;
            double rem14 = matrix1.m14 + matrix2.m14;
            double rem21 = matrix1.m21 + matrix2.m21;
            double rem22 = matrix1.m22 + matrix2.m22;
            double rem23 = matrix1.m23 + matrix2.m23;
            double rem24 = matrix1.m24 + matrix2.m24;
            double rem31 = matrix1.m31 + matrix2.m31;
            double rem32 = matrix1.m32 + matrix2.m32;
            double rem33 = matrix1.m33 + matrix2.m33;
            double rem34 = matrix1.m34 + matrix2.m34;
            double rem41 = matrix1.m41 + matrix2.m41;
            double rem42 = matrix1.m42 + matrix2.m42;
            double rem43 = matrix1.m43 + matrix2.m43;
            double rem44 = matrix1.m44 + matrix2.m44;
            Matrix4X4 retu = new Matrix4X4(rem11, rem12, rem13, rem14, rem21, rem22, rem23, rem24, rem31, rem32, rem33, rem34, rem41, rem42, rem43, rem44);
            return retu;
        }

        public override string ToString()
        {
            string re = String.Format(
                           "{0} {1} {2} {3}\n" +
                           "{4} {5} {6} {7}\n" +
                           "{8} {9} {10} {11}\n" +
                           "{12} {13} {14} {15}\n", m11.ToString(),
                 m12.ToString(), m13.ToString(), m14.ToString(), m21.ToString(), m22.ToString(), m23.ToString(), m24.ToString(), m31.ToString(), m32.ToString(), m33.ToString(), m34.ToString(), m41.ToString(), m42.ToString(), m43.ToString(), m44.ToString());

            return re;
        }
    }
}