using Assimp;
using System.Numerics;

namespace RayTracingInCSharp
{
    public static class AssimpExtension
    {
        public static Vector3 Convert(this Vector3D v)
        {
            return new Vector3(v.X, v.Y, v.Z);
        }
    }
}
