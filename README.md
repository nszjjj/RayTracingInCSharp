# RayTracingInCSharp
C#写的光追渲染器
# 相机
## 相机的参数
相机的参数由Assmip读入并推导。可以获取到如下参数：
- AspectRatio
- FOV（水平）
- 相机朝向
对于AspectRatio的定义是$AspectRatio = Width/Height$

这意味着我们只需要再指定焦距就可以推断出成像平面所在位置及大小了

当指定`focalLength`作为焦距，默认viewport高度为2，可以推出宽度为H*AspectRatio

由于viewport是成像面，buffer是在上面分割出具体的格子（像素），合理的情况是格子是正方形（像素是正方形而不是长方形），所以设定buffer和viewport等比例，因此给出buffer的高也可以用相同的AspectRatio推出宽。
