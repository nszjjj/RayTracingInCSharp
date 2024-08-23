using Assimp;
using System;
using System.Windows.Forms;

namespace RayTracingInCSharp
{
    public class LoadUtils
    {
        public static Scene LoadFBX()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "FBX Files (*.fbx)|*.fbx",
                Title = "Select an FBX File"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选中的文件路径
                string filePath = openFileDialog.FileName;

                // 创建 Assimp 导入器
                var importer = new AssimpContext();

                try
                {
                    // 导入 FBX 文件并返回场景
                    Scene scene = importer.ImportFile(filePath, PostProcessSteps.Triangulate | PostProcessSteps.ValidateDataStructure);
                    return scene;
                }
                catch (Exception ex)    // 异常处理：文件加载失败
                {
                    MessageBox.Show($"Failed to load FBX file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                // 用户取消选择
                return null;
            }
        }

        public static void CreateWarpFromScene(Scene scene)
        {
            //Dictionary < Node,WarpInfo >

            foreach (var i in scene.RootNode.Children)
            {

            }
        }
    }
}
