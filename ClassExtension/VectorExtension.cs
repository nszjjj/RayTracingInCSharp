using System.Numerics;

namespace RayTracingInCSharp
{
    static class VectorExtension
    {
        /// <summary>
        /// 标量乘法
        /// </summary>
        public static Vector3 ScalarMultiply(this Vector3 vector, float scalar)
        {
            return new Vector3(vector.X * scalar, vector.Y * scalar, vector.Z * scalar);
        }
    }
}
