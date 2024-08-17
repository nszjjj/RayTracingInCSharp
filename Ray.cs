using System.Numerics;

namespace RayTracingInCSharp
{
    public class Ray
    {
        public Vector3 origin { get; private set; }
        public Vector3 direction { get; private set; }
        public Ray(Vector3 origin, Vector3 direction)
        {
            this.origin = origin;
            this.direction = direction;
        }

        /// <summary>
        /// 对于光线P(t)=a+tb
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public Vector3 At(float t)
        {
            return origin + direction.ScalarMultiply(t);
        }
    }
}
