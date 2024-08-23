using Assimp;
using RayTracingInCSharp.Utils;
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
        float aspectRatio = 16.0f / 9.0f;
        float HFOV;
        Vector3 cameraPos;
        double bufferHeight = 1080; // 默认垂直像素数目
        double bufferWidth;         // 水平像素数目
        // 注：本质上viewport是成像面，buffer是在上面分割出具体的格子（像素）
        Vector3 viewportU;  // 逻辑视口的水平方向长度矢量
        Vector3 viewportV;  // 逻辑视口的垂直方向长度矢量
        double viewportHeight;
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
            HFOV = renderMesh.Cameras[0].FieldOfview;
            aspectRatio = renderMesh.Cameras[0].AspectRatio;
            // 现在成像面的长宽由水平FOV和焦距推导
            viewportWidth = CameraUtils.CalViewportWidth(HFOV, aspectRatio);
            viewportHeight = viewportWidth / aspectRatio;
            // buffer长宽应与成像面长宽比例一致
            bufferHeight = bufferWidth / aspectRatio;  // 水平画布尺寸
            colorBuffer = new Bitmap((int)bufferHeight, (int)bufferWidth);
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
