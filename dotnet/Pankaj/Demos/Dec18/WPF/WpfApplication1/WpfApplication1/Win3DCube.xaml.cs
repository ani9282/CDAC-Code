using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//Adding namespaces in application as shown below 

using System.Windows.Media.Media3D;
using System.Windows.Media.Animation;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Win3DCube.xaml
    /// </summary>
    public partial class Win3DCube : Window
    {
        public Win3DCube()
        {
            InitializeComponent();
        }
        Viewport3D Viewport = new Viewport3D(); //Viewport3D class provides a rendering surface for 3-D visual content

        GeometryModel3D surface1 = new GeometryModel3D();//GeometryModel3D class object provides generalized transformation support for 3-D objects

        GeometryModel3D surface2 = new GeometryModel3D();

        GeometryModel3D surface3 = new GeometryModel3D();

        GeometryModel3D surface4 = new GeometryModel3D();

        GeometryModel3D surface5 = new GeometryModel3D();

        GeometryModel3D surface6 = new GeometryModel3D();

        PerspectiveCamera Camera = new PerspectiveCamera();//PerspectiveCamera class object represents a perspective projection camera



        DirectionalLight myDLight = new DirectionalLight();//DirectionalLight class object provides effect along a direction



        AmbientLight AmLight = new AmbientLight();//AmbientLight class objects provides Lights every surface uniformly a bright AmbientLight creates  because of lack of shading, but a low-intensity AmbientLight approximatesthe effect of light that has been scattered by reflecting between diffuse surfaces in the scene.



        MaterialGroup myMaterials = new MaterialGroup();//MaterialGroup class objects applies multiple Materials to a model each Material is rendered in order, with the last Material in the group appearing on top.

        Transform3DGroup Transgroup = new Transform3DGroup();//Transform3DGroup class contains a collection of Transform3Ds.

        Model3DGroup Modelgroup = new Model3DGroup();//The Model3DGroup class is itself a Model3D and is often used to group multiple GeometryModel3Ds

        Model3DGroup cube = new Model3DGroup();

        MeshGeometry3D surface1Plane = new MeshGeometry3D();// MeshGeometry3D class represents a set of 3D surfaces

        MeshGeometry3D surface2Plane = new MeshGeometry3D();

        MeshGeometry3D surface3Plane = new MeshGeometry3D();

        MeshGeometry3D surface4Plane = new MeshGeometry3D();

        MeshGeometry3D surface5Plane = new MeshGeometry3D();

        MeshGeometry3D surface6Plane = new MeshGeometry3D();



        DiffuseMaterial surface1Material = new DiffuseMaterial();//DiffuseMaterial class provides scatters light striking the surface in all directions,

        DiffuseMaterial surface2Material = new DiffuseMaterial();

        DiffuseMaterial surface3Material = new DiffuseMaterial();

        DiffuseMaterial surface4Material = new DiffuseMaterial();

        DiffuseMaterial surface5Material = new DiffuseMaterial();

        DiffuseMaterial surface6Material = new DiffuseMaterial();

        ModelVisual3D ModelVisualD = new ModelVisual3D();//ModelVisual3D class contains 3-D models

        private void WindowLoaded(object sender, RoutedEventArgs e)

        {

            Camera.Position = new Point3D(-5, 2, 3);//setting the camera position in world coordinates

            Camera.LookDirection = new Vector3D(5, -2, -3);//defininig the direction in which the camera looking in world coordinates

            AmLight.Color = Colors.White;//setting the color of light

  

            //set Geometry property of MeshGeometry3D

  

            surface1.Geometry = surface1Plane;

            surface2.Geometry = surface2Plane;

            surface3.Geometry = surface3Plane;

            surface4.Geometry = surface4Plane;

            surface5.Geometry = surface5Plane;

            surface6.Geometry = surface6Plane;

  

            Vector3D vecD = new Vector3D(-50, -90, 0);

  

            Rotation3D RD = new AxisAngleRotation3D(vecD, 1);

  

            RotateTransform3D RotateTrans = new RotateTransform3D(RD);//RotateTransform3D class specify rotation transformation that is parameterized

  

            //Define an animation for the rotation

  

            DoubleAnimation myAnimation = new DoubleAnimation();

            myAnimation.From = 1;

            myAnimation.To = 361;

            myAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(3000));//Defining time in second for cube that will be rotate

            myAnimation.RepeatBehavior = RepeatBehavior.Forever;

            

            RotateTrans.Rotation.BeginAnimation(AxisAngleRotation3D.AngleProperty, myAnimation);

  

            //Add transformation to the model

  

            Transgroup.Children.Add(RotateTrans);

  

            cube.Children.Add(surface1);

            cube.Children.Add(surface2);

            cube.Children.Add(surface3);

            cube.Children.Add(surface4);

            cube.Children.Add(surface5);

            cube.Children.Add(surface6);

  

            Modelgroup.Transform = Transgroup;

  

            Modelgroup.Children.Add(cube);

  

            Modelgroup.Children.Add(AmLight);

  

            Viewport.Camera = Camera;

  

            ModelVisualD.Content = Modelgroup;

  

            Viewport.Children.Add(ModelVisualD);

  

           //Defining surface position in world coordinates

            //-----------------------surface1------------------------

  

            surface1Plane.Positions.Add(new Point3D(-0.5, -0.5, -0.5));

            surface1Plane.Positions.Add(new Point3D(-0.5, 0.5, -0.5));

            surface1Plane.Positions.Add(new Point3D(0.5, 0.5, -0.5));

            surface1Plane.Positions.Add(new Point3D(0.5, 0.5, -0.5));

            surface1Plane.Positions.Add(new Point3D(0.5, -0.5, -0.5));

            surface1Plane.Positions.Add(new Point3D(-0.5, -0.5, -0.5));

  

  

//TriangleIndices—Describes the connections between the vertices to form triangles if TriangleIndices is not specified, it is implied that the positions should beconnected in the order they appear: 0 1 2, then 3 4 5, and so on.

  

            surface1Plane.TriangleIndices.Add(0);

            surface1Plane.TriangleIndices.Add(1);

            surface1Plane.TriangleIndices.Add(2);

            surface1Plane.TriangleIndices.Add(3);

            surface1Plane.TriangleIndices.Add(4);

            surface1Plane.TriangleIndices.Add(5);

  

            surface1Plane.Normals.Add(new Vector3D(0, 0, -1));

            surface1Plane.Normals.Add(new Vector3D(0, 0, -1));

            surface1Plane.Normals.Add(new Vector3D(0, 0, -1));

            surface1Plane.Normals.Add(new Vector3D(0, 0, -1));

            surface1Plane.Normals.Add(new Vector3D(0, 0, -1));

            surface1Plane.Normals.Add(new Vector3D(0, 0, -1));

  

            surface1Plane.TextureCoordinates.Add(new Point(1, 0));

            surface1Plane.TextureCoordinates.Add(new Point(1, 1));

            surface1Plane.TextureCoordinates.Add(new Point(0, 1));

            surface1Plane.TextureCoordinates.Add(new Point(0, 1));

            surface1Plane.TextureCoordinates.Add(new Point(0, 0));

            surface1Plane.TextureCoordinates.Add(new Point(1, 0));

  

            //-----------------------surface2------------------------

  

            surface2Plane.Positions.Add(new Point3D(-0.5, -0.5, 0.5));

            surface2Plane.Positions.Add(new Point3D(0.5, -0.5, 0.5));

            surface2Plane.Positions.Add(new Point3D(0.5, 0.5, 0.5));

            surface2Plane.Positions.Add(new Point3D(0.5, 0.5, 0.5));

            surface2Plane.Positions.Add(new Point3D(-0.5, 0.5, 0.5));

            surface2Plane.Positions.Add(new Point3D(-0.5, -0.5, 0.5));

  

            surface2Plane.TriangleIndices.Add(0);

            surface2Plane.TriangleIndices.Add(1);

            surface2Plane.TriangleIndices.Add(2);

            surface2Plane.TriangleIndices.Add(3);

            surface2Plane.TriangleIndices.Add(4);

            surface2Plane.TriangleIndices.Add(5);

  

            surface2Plane.Normals.Add(new Vector3D(0, 0, 1));

            surface2Plane.Normals.Add(new Vector3D(0, 0, 1));

            surface2Plane.Normals.Add(new Vector3D(0, 0, 1));

            surface2Plane.Normals.Add(new Vector3D(0, 0, 1));

            surface2Plane.Normals.Add(new Vector3D(0, 0, 1));

            surface2Plane.Normals.Add(new Vector3D(0, 0, 1));

  

            surface2Plane.TextureCoordinates.Add(new Point(0, 0));

            surface2Plane.TextureCoordinates.Add(new Point(1, 0));

            surface2Plane.TextureCoordinates.Add(new Point(1, 1));

            surface2Plane.TextureCoordinates.Add(new Point(1, 1));

            surface2Plane.TextureCoordinates.Add(new Point(0, 1));

            surface2Plane.TextureCoordinates.Add(new Point(0, 0));

  

            //-----------------------surface3------------------------

  

            surface3Plane.Positions.Add(new Point3D(-0.5, -0.5, -0.5));

            surface3Plane.Positions.Add(new Point3D(0.5, -0.5, -0.5));

            surface3Plane.Positions.Add(new Point3D(0.5, -0.5, 0.5));

            surface3Plane.Positions.Add(new Point3D(0.5, -0.5, 0.5));

            surface3Plane.Positions.Add(new Point3D(-0.5, -0.5, 0.5));

            surface3Plane.Positions.Add(new Point3D(-0.5, -0.5, -0.5));

  

            surface3Plane.TriangleIndices.Add(0);

            surface3Plane.TriangleIndices.Add(1);

            surface3Plane.TriangleIndices.Add(2);

            surface3Plane.TriangleIndices.Add(3);

            surface3Plane.TriangleIndices.Add(4);

            surface3Plane.TriangleIndices.Add(5);

  

            surface3Plane.Normals.Add(new Vector3D(0, -1, 0));

            surface3Plane.Normals.Add(new Vector3D(0, -1, 0));

            surface3Plane.Normals.Add(new Vector3D(0, -1, 0));

            surface3Plane.Normals.Add(new Vector3D(0, -1, 0));

            surface3Plane.Normals.Add(new Vector3D(0, -1, 0));

            surface3Plane.Normals.Add(new Vector3D(0, -1, 0));

  

            surface3Plane.TextureCoordinates.Add(new Point(0, 0));

            surface3Plane.TextureCoordinates.Add(new Point(1, 0));

            surface3Plane.TextureCoordinates.Add(new Point(1, 1));

            surface3Plane.TextureCoordinates.Add(new Point(1, 1));

            surface3Plane.TextureCoordinates.Add(new Point(0, 1));

            surface3Plane.TextureCoordinates.Add(new Point(0, 0));

  

            //-----------------------surface4------------------------

  

            surface4Plane.Positions.Add(new Point3D(0.5, -0.5, -0.5));

            surface4Plane.Positions.Add(new Point3D(0.5, 0.5, -0.5));

            surface4Plane.Positions.Add(new Point3D(0.5, 0.5, 0.5));

            surface4Plane.Positions.Add(new Point3D(0.5, 0.5, 0.5));

            surface4Plane.Positions.Add(new Point3D(0.5, -0.5, 0.5));

            surface4Plane.Positions.Add(new Point3D(0.5, -0.5, -0.5));

  

            surface4Plane.TriangleIndices.Add(0);

            surface4Plane.TriangleIndices.Add(1);

            surface4Plane.TriangleIndices.Add(2);

            surface4Plane.TriangleIndices.Add(3);

            surface4Plane.TriangleIndices.Add(4);

            surface4Plane.TriangleIndices.Add(5);

  

            surface4Plane.Normals.Add(new Vector3D(1, 0, 0));

            surface4Plane.Normals.Add(new Vector3D(1, 0, 0));

            surface4Plane.Normals.Add(new Vector3D(1, 0, 0));

            surface4Plane.Normals.Add(new Vector3D(1, 0, 0));

            surface4Plane.Normals.Add(new Vector3D(1, 0, 0));

            surface4Plane.Normals.Add(new Vector3D(1, 0, 0));

  

            surface4Plane.TextureCoordinates.Add(new Point(1, 0));

            surface4Plane.TextureCoordinates.Add(new Point(1, 1));

            surface4Plane.TextureCoordinates.Add(new Point(0, 1));

            surface4Plane.TextureCoordinates.Add(new Point(0, 1));

            surface4Plane.TextureCoordinates.Add(new Point(0, 0));

            surface4Plane.TextureCoordinates.Add(new Point(1, 0));

  

            //-----------------------surface5------------------------

  

            surface5Plane.Positions.Add(new Point3D(0.5, 0.5, -0.5));

            surface5Plane.Positions.Add(new Point3D(-0.5, 0.5, -0.5));

            surface5Plane.Positions.Add(new Point3D(-0.5, 0.5, 0.5));

            surface5Plane.Positions.Add(new Point3D(-0.5, 0.5, 0.5));

            surface5Plane.Positions.Add(new Point3D(0.5, 0.5, 0.5));

            surface5Plane.Positions.Add(new Point3D(0.5, 0.5, -0.5));

  

            surface5Plane.TriangleIndices.Add(0);

            surface5Plane.TriangleIndices.Add(1);

            surface5Plane.TriangleIndices.Add(2);

            surface5Plane.TriangleIndices.Add(3);

            surface5Plane.TriangleIndices.Add(4);

            surface5Plane.TriangleIndices.Add(5);

  

            surface5Plane.Normals.Add(new Vector3D(0, 1, 0));

            surface5Plane.Normals.Add(new Vector3D(0, 1, 0));

            surface5Plane.Normals.Add(new Vector3D(0, 1, 0));

            surface5Plane.Normals.Add(new Vector3D(0, 1, 0));

            surface5Plane.Normals.Add(new Vector3D(0, 1, 0));

            surface5Plane.Normals.Add(new Vector3D(0, 1, 0));

  

            surface5Plane.TextureCoordinates.Add(new Point(1, 1));

            surface5Plane.TextureCoordinates.Add(new Point(0, 1));

            surface5Plane.TextureCoordinates.Add(new Point(0, 0));

            surface5Plane.TextureCoordinates.Add(new Point(0, 0));

            surface5Plane.TextureCoordinates.Add(new Point(1, 0));

            surface5Plane.TextureCoordinates.Add(new Point(1, 1));

  

            //-----------------------surface6------------------------

  

            surface6Plane.Positions.Add(new Point3D(-0.5, 0.5, -0.5));

            surface6Plane.Positions.Add(new Point3D(-0.5, -0.5, -0.5));

            surface6Plane.Positions.Add(new Point3D(-0.5, -0.5, 0.5));

            surface6Plane.Positions.Add(new Point3D(-0.5, -0.5, 0.5));

            surface6Plane.Positions.Add(new Point3D(-0.5, 0.5, 0.5));

            surface6Plane.Positions.Add(new Point3D(-0.5, 0.5, -0.5));

  

            surface6Plane.TriangleIndices.Add(0);

            surface6Plane.TriangleIndices.Add(1);

            surface6Plane.TriangleIndices.Add(2);

            surface6Plane.TriangleIndices.Add(3);

            surface6Plane.TriangleIndices.Add(4);

            surface6Plane.TriangleIndices.Add(5);

  

            surface6Plane.Normals.Add(new Vector3D(-1, 0, 0));

            surface6Plane.Normals.Add(new Vector3D(-1, 0, 0));

            surface6Plane.Normals.Add(new Vector3D(-1, 0, 0));

            surface6Plane.Normals.Add(new Vector3D(-1, 0, 0));

            surface6Plane.Normals.Add(new Vector3D(-1, 0, 0));

            surface6Plane.Normals.Add(new Vector3D(-1, 0, 0));

  

            surface6Plane.TextureCoordinates.Add(new Point(0, 1));

            surface6Plane.TextureCoordinates.Add(new Point(0, 0));

            surface6Plane.TextureCoordinates.Add(new Point(1, 0));

            surface6Plane.TextureCoordinates.Add(new Point(1, 0));

            surface6Plane.TextureCoordinates.Add(new Point(1, 1));

            surface6Plane.TextureCoordinates.Add(new Point(0, 1));

  

            //Accessing ImageBrush tags from App.xaml file with their keys name

  

            DiffuseMaterial surface1Material = new DiffuseMaterial((Brush)Application.Current.Resources["Jellyfish"]);

            DiffuseMaterial surface2Material = new DiffuseMaterial((Brush)Application.Current.Resources["Chrysanthemum"]);

            DiffuseMaterial surface3Material = new DiffuseMaterial((Brush)Application.Current.Resources["Koala"]);

            DiffuseMaterial surface4Material = new DiffuseMaterial((Brush)Application.Current.Resources["Penguins"]);

            DiffuseMaterial surface5Material = new DiffuseMaterial((Brush)Application.Current.Resources["Tulips"]);

            DiffuseMaterial surface6Material = new DiffuseMaterial((Brush)Application.Current.Resources["Desert"]);

  

            surface2.Material = surface2Material;

            surface6.Material = surface6Material;

            surface1.Material = surface1Material;

            surface3.Material = surface3Material;

            surface4.Material = surface4Material;

            surface5.Material = surface5Material;

            win3DCube.Content = Viewport;

        }

  

    }
}
