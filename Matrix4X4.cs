namespace miniRenderer
{
    internal class Matrix4X4
    {
        public float m11;
        public float m12;
        public float m13;
        public float m14;

        public float m21;
        public float m22;
        public float m23;
        public float m24;

        public float m31;
        public float m32;
        public float m33;
        public float m34;

        public float m41;
        public float m42;
        public float m43;
        public float m44;

        public Matrix4X4(float m11 = 0f
        , float m12 = 0f
        , float m13 = 0f
        , float m14 = 0f

        , float m21 = 0f
        , float m22 = 0f
        , float m23 = 0f
        , float m24 = 0f

        , float m31 = 0f
        , float m32 = 0f
        , float m33 = 0f
        , float m34 = 0f

        , float m41 = 0f
        , float m42 = 0f
        , float m43 = 0f
        , float m44 = 0f)
        {
            m11 = m11;
            m12 = m12;
            m13 = m13;
            m14 = m14;
            ;
            m21 = m21;
            m22 = m22;
            m23 = m23;
            m24 = m24;
            ;
            m31 = m31;
            m32 = m32;
            m33 = m33;
            m34 = m34;
            ;
            m41 = m41;
            m42 = m42;
            m43 = m43;
            m44 = m44;
        }
        /// <summary>
        /// 矩阵叉乘
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static Matrix4X4 MultiplyCross(Matrix4X4 matrix1, Matrix4X4 matrix2)
        {
            //按行计算
            float rem11 = SixNumMult(matrix1.m11, matrix1.m12, matrix1.m13, matrix1.m14, matrix2.m11, matrix2.m21, matrix2.m31, matrix2.m41);
            float rem12 = SixNumMult(matrix1.m11, matrix1.m12, matrix1.m13, matrix1.m14, matrix2.m12, matrix2.m22, matrix2.m32, matrix2.m42);
            float rem13 = SixNumMult(matrix1.m11, matrix1.m12, matrix1.m13, matrix1.m14, matrix2.m13, matrix2.m23, matrix2.m33, matrix2.m43);
            float rem14 = SixNumMult(matrix1.m11, matrix1.m12, matrix1.m13, matrix1.m14, matrix2.m14, matrix2.m24, matrix2.m34, matrix2.m44);
            float rem21 = SixNumMult(matrix1.m21, matrix1.m22, matrix1.m23, matrix1.m24, matrix2.m11, matrix2.m21, matrix2.m31, matrix2.m41);
            float rem22 = SixNumMult(matrix1.m21, matrix1.m22, matrix1.m23, matrix1.m24, matrix2.m12, matrix2.m22, matrix2.m32, matrix2.m42);
            float rem23 = SixNumMult(matrix1.m21, matrix1.m22, matrix1.m23, matrix1.m24, matrix2.m13, matrix2.m23, matrix2.m33, matrix2.m43);
            float rem24 = SixNumMult(matrix1.m21, matrix1.m22, matrix1.m23, matrix1.m24, matrix2.m14, matrix2.m24, matrix2.m34, matrix2.m44);
            float rem31 = SixNumMult(matrix1.m31, matrix1.m32, matrix1.m33, matrix1.m34, matrix2.m11, matrix2.m21, matrix2.m31, matrix2.m41);
            float rem32 = SixNumMult(matrix1.m31, matrix1.m32, matrix1.m33, matrix1.m34, matrix2.m12, matrix2.m22, matrix2.m32, matrix2.m42);
            float rem33 = SixNumMult(matrix1.m31, matrix1.m32, matrix1.m33, matrix1.m34, matrix2.m13, matrix2.m23, matrix2.m33, matrix2.m43);
            float rem34 = SixNumMult(matrix1.m31, matrix1.m32, matrix1.m33, matrix1.m34, matrix2.m14, matrix2.m24, matrix2.m34, matrix2.m44);
            float rem41 = SixNumMult(matrix1.m41, matrix1.m42, matrix1.m43, matrix1.m44, matrix2.m11, matrix2.m21, matrix2.m31, matrix2.m41);
            float rem42 = SixNumMult(matrix1.m41, matrix1.m42, matrix1.m43, matrix1.m44, matrix2.m12, matrix2.m22, matrix2.m32, matrix2.m42);
            float rem43 = SixNumMult(matrix1.m41, matrix1.m42, matrix1.m43, matrix1.m44, matrix2.m13, matrix2.m23, matrix2.m33, matrix2.m43);
            float rem44 = SixNumMult(matrix1.m41, matrix1.m42, matrix1.m43, matrix1.m44, matrix2.m14, matrix2.m24, matrix2.m34, matrix2.m44);
            Matrix4X4 retu = new Matrix4X4(rem11, rem12, rem13, rem14, rem21, rem22, rem23, rem24, rem31, rem32, rem33, rem34, rem41, rem42, rem43, rem44);
            return retu;
        }

        private static float SixNumMult(float m11, float m12, float m13, float m14, float m21, float m22, float m23,
            float m24)
        {
            return m11 * m21 + m12 * m22 + m13 * m23 + m14 * m24;
        }

        /// <summary>
        /// 矩阵点乘
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        public static float Dot(Matrix4X4 matrix1, Matrix4X4 matrix2)
        {
            float retu = 0f;

            return retu;
        }
    }
}