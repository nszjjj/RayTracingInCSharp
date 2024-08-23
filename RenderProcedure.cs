using Assimp;
using System.Drawing;
using System.Numerics;

namespace RayTracingInCSharp
{
    /// <summary>
    /// 渲染过程：载入场景、初始化图像缓冲区、初始化相机参数、启动渲染流程
    /// </summary>
    public class RenderProcedure
    {
        private Scene renderMesh;
        Bitmap colorBuffer;
        // ============渲染参数=============
        float focalLength = 1;  // 成像面到摄像机的距离（焦距）
        double aspectRatio = 16.0 / 9.0;
        Vector3 cameraPos;
        double bufferHeight = 1920; // 默认垂直像素数目
        double bufferWidth;         // 水平像素数目
        // 注：本质上viewport是成像面，buffer是在上面分割出具体的格子（像素）
        Vector3 viewportU;  // 逻辑视口的水平方向长度矢量
        Vector3 viewportV;  // 逻辑视口的垂直方向长度矢量
        double viewportHeight = 2.0;
        double viewportWidth;

        public RenderProcedure(Scene mesh)
        {
            this.renderMesh = mesh;
        }
        void InitCameraParam()
        {
            if (renderMesh.CameraCount <= 0)
            {
                cameraPos = new Vector3(0, 0, 0);
            }
            bufferWidth = bufferHeight / aspectRatio;  // 水平画布尺寸
            colorBuffer = new Bitmap((int)bufferHeight, (int)bufferWidth);
            viewportWidth = viewportHeight * bufferWidth / bufferHeight;
            // TODO:根据视图矩阵计算成像面的横向向量和纵向向量
            viewportU = new Vector3(0, 0, 0);
        }
        /// <summary>
        /// 获取第(x,y)个像素的方向
        /// </summary>
        /// <param name="x">左上角为0点，向右递增</param>
        /// <param name="y">左上角为0点，向下递增</param>
        void GetPixelCenterDir(int x, int y)
        {

        }
        void OnChangeRenderSetting()
        {

        }
    }
}
