using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlicerProto.ObjectModel;
using SlicerProto.SliceModel;
using SlicerProto.Import;
using SlicerProto.Utils;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.IO;
using SlicerProto.SliceFill;
using SlicerProto.Options;
using System.Xml.Serialization;
using SlicerProto.Export;

namespace SlicerProto
{
    public partial class MainForm : Form
    {
        bool loaded = false;
        readonly Model model = new Model();
        Vector3 position = Vector3.Zero;
        Vector3 scale = Vector3.One;
        SlicerOptions options = new SlicerOptions();
        bool lockScaling = false;

        public MainForm()
        {
            InitializeComponent();
            LoadSettings();
            AdjustUI();
        }

        private Vector3 GetViewScale() => scale / 10f;
        private Vector3 GetViewPosition() => position / 10f;

        private void LoadSettings()
        {
            string path = GetSettingsFilePath();
            if (!File.Exists(path))
                return;
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(SlicerOptions));
                    options = (SlicerOptions)serializer.Deserialize(fs);
                }
            }
            catch
            {
                MessageBox.Show("Не могу загрузить настройки приложения!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSettings()
        {
            string path = GetSettingsFilePath();
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(SlicerOptions));
                    serializer.Serialize(fs, options);
                }
            }
            catch
            {
                MessageBox.Show("Не могу сохранить настройки приложения!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSettingsFilePath()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return Path.Combine(folder, "slicer.xml");
        }

        private void AdjustUI()
        {
            int rightPanelWidth = (int)Math.Ceiling(260f * GetCurrentDpi() / 120f);
            splitContainer1.Panel2MinSize = rightPanelWidth;
            splitContainer1.SplitterDistance = splitContainer1.Width - splitContainer1.Panel2MinSize;
            edPositionX.Maximum = (decimal)options.Printer.BuildAreaWidth;
            edPositionY.Maximum = (decimal)options.Printer.BuildAreaDepth;
            ResetPositionUI();
        }

        private float GetCurrentDpi()
        {
            using (Graphics graphics = this.CreateGraphics())
            {
                return graphics.DpiX;
            }
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                IImporter importer = ImporterFactory.CreateImporter(model, fileName);
                try
                {
                    importer.Import(fileName);
                    toolStripStatusLabel1.Text = $"Количество треугольников: {model.Facets.Count}";
                    SetupInitialScaleAndPosition();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не могу прочитать файл '{fileName}'!\n{ex.Message}", 
                        Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    model.Clear();
                    scale = Vector3.One;
                    position = Vector3.Zero;
                    toolStripStatusLabel1.Text = string.Empty;
                }
                glControl1.Invalidate();
            }
        }

        /// <summary>
        /// Расчитать коэффициент масштабирования и позицию модели
        /// </summary>
        private void SetupAutoScaleAndPosition()
        {
            ResetPositionUI();
            float minSize = Math.Min(options.Printer.BuildAreaWidth, 
                Math.Min(options.Printer.BuildAreaDepth, options.Printer.BuildAreaHeight));
            ObjectDimensions dimensions = model.Dimensions;
            // Auto scale to 50% of printer build area
            float autoScale = dimensions.AutoScale(minSize * 50f / 100f);
            scale = new Vector3(autoScale);
            // Расположить модель посередине стола
            position.X = -(dimensions.Size.X / 2 + dimensions.MinPoint.X) * scale.X;
            position.Y = -(dimensions.Size.Y / 2 + dimensions.MinPoint.Y) * scale.Y;
            position.Z = -dimensions.MinPoint.Z * scale.Z;
            UpdateScalingUI();
        }

        private void SetupInitialScaleAndPosition()
        {
            ObjectDimensions dimensions = model.Dimensions;
            Vector3 size = dimensions.Size;
            Vector3 buildAreaSize = options.Printer.GetBuildAreaSize();
            if (size.X > buildAreaSize.X || size.Y > buildAreaSize.Y || size.Z > buildAreaSize.Z)
            {
                SetupAutoScaleAndPosition();
            }
            else
            {
                ResetPositionUI();
                scale = Vector3.One;
                position.X = -(dimensions.Size.X / 2 + dimensions.MinPoint.X) * scale.X;
                position.Y = -(dimensions.Size.Y / 2 + dimensions.MinPoint.Y) * scale.Y;
                position.Z = -dimensions.MinPoint.Z * scale.Z;
                UpdateScalingUI();
            }
        }

        private void UpdateScalingUI()
        {
            lockScaling = true;
            try
            {
                Vector3 modelSize = model.Dimensions.Size;
                edModelWidth.Value = Convert.ToDecimal(modelSize.X * scale.X);
                edModelDepth.Value = Convert.ToDecimal(modelSize.Y * scale.Y);
                edModelHeight.Value = Convert.ToDecimal(modelSize.Z * scale.Z);
                edScaleX.Value = Convert.ToDecimal(scale.X * 100);
                edScaleY.Value = Convert.ToDecimal(scale.Y * 100);
                edScaleZ.Value = Convert.ToDecimal(scale.Z * 100);
            }
            finally
            {
                lockScaling = false;
            }
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            loaded = true;
            SetupViewPort();
        }

        private void SetupViewPort()
        {
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            double factor = glControl1.Width * 1.0 / glControl1.Height;
            float fov = (float)(45.0 * Math.PI / 180.0);
            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(fov, (float)factor, 0.1f, 100f);
            GL.LoadMatrix(ref perspective);
            GL.Viewport(glControl1.ClientRectangle);
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            if (!loaded)
                return;
            SetupViewPort();
            glControl1.Invalidate();
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded)
                return;

            GL.ClearColor(Color.White);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();

            SetupCamera();
            SetupLight();

            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.DepthTest);

            // Отрисовка стола
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
            GL.ShadeModel(ShadingModel.Smooth);
            DrawBuildArea();

            float delta = model.Dimensions.Size.Z / (edPlane.Maximum - edPlane.Minimum - 2);
            float z = model.Dimensions.MinPoint.Z + delta * (edPlane.Value - 1);

            // Отрисовка скирта и модели
            GL.PolygonMode(MaterialFace.FrontAndBack, cbWireframe.Checked ? PolygonMode.Line : PolygonMode.Fill);
            GL.ShadeModel(ShadingModel.Smooth);
            SetupMaterial(options.View.ModelColor, Color4.White, 100f);
            DrawSkirt();
            GL.LineWidth(1f);
            DrawModel(z);

            // Отрисовка среза
            DrawSlice(z, delta, edPlane.Value);
            GL.LineWidth(1f);

            glControl1.SwapBuffers();
        }

        /// <summary>
        /// Настроить камеру
        /// </summary>
        private void SetupCamera()
        {
            double alfa = (double)edRotationX.Value * Math.PI / 180.0;
            double psi = (double)edRotationZ.Value * Math.PI / 180.0;

            double z = (double)edDistance.Value * Math.Sin(alfa);
            double r = (double)edDistance.Value * Math.Cos(alfa);
            float x = (float)(r * Math.Cos(psi));
            float y = (float)(-r * Math.Sin(psi));

            Matrix4 camera = Matrix4.LookAt(new Vector3(x, y, (float)z), new Vector3(0f, 0f, 0f), new Vector3(-x, -y, 0f));
            GL.LoadMatrix(ref camera);
        }

        /// <summary>
        /// Расчитать освещение
        /// </summary>
        private void SetupLight()
        {
            GL.Disable(EnableCap.Light0);

            GL.Light(LightName.Light0, LightParameter.Ambient, new float[] { 0.3f, 0.3f, 0.3f, 1.0f });
            GL.Light(LightName.Light0, LightParameter.Diffuse, new float[] { 0.5f, 0.5f, 0.5f, 1.0f });
            GL.Light(LightName.Light0, LightParameter.Specular, new float[] { 0.05f, 0.05f, 0.05f, 1.0f });
            GL.LightModel(LightModelParameter.LightModelAmbient, new float[] { 0.4f, 0.4f, 0.4f, 1.0f });
            GL.LightModel(LightModelParameter.LightModelColorControl, 0x81fa);
            GL.LightModel(LightModelParameter.LightModelLocalViewer, 1f);
            GL.LightModel(LightModelParameter.LightModelTwoSide, 0f);

            SetLightPosition();

            //GL.Light(LightName.Light0, LightParameter.SpotCutoff, 180f);
            //GL.Light(LightName.Light0, LightParameter.SpotExponent, 0f);

            GL.Enable(EnableCap.Light0);
        }

        /// <summary>
        /// Задать позицию источника света
        /// </summary>
        private void SetLightPosition()
        {
            double alfa = (double)edRotationZ.Value * Math.PI / 180.0;
            Matrix4 matrix;
            Matrix4.CreateRotationZ((float)-alfa, out matrix);

            Vector4 lightPos = new Vector4(0f, 0f, options.Printer.BuildAreaHeight / 10f, 1f);
            Vector4.Transform(ref lightPos, ref matrix, out lightPos);
            GL.Light(LightName.Light0, LightParameter.Position, lightPos);

            Vector4 spotDir = new Vector4(0f, 0f, -1f, 1f);
            Vector4.Transform(ref spotDir, ref matrix, out spotDir);
            GL.Light(LightName.Light0, LightParameter.SpotDirection, spotDir);
        }

        /// <summary>
        /// Задать параметры материала
        /// </summary>
        private void SetupMaterial(Color4 ambientAndDiffuse, Color4 specular, float shininess)
        {
            GL.Material(MaterialFace.Front, MaterialParameter.AmbientAndDiffuse, ambientAndDiffuse);
            GL.Material(MaterialFace.Front, MaterialParameter.Specular, specular);
            GL.Material(MaterialFace.Front, MaterialParameter.Emission, Color4.Black);
            GL.Material(MaterialFace.Front, MaterialParameter.Shininess, shininess);
        }

        /// <summary>
        /// Отрисовать стол и рабочую область
        /// </summary>
        private void DrawBuildArea()
        {
            Vector3 buildAreaSize = options.Printer.GetBuildAreaSize() / 10;
            Vector3 homePosition = options.Printer.GetHomePosition() / 10;
            double cx = -buildAreaSize.X / 2;
            double cy = -buildAreaSize.Y / 2;
            double cz = 0;
            GL.PushMatrix();
            GL.Translate(cx, cy, cz);

            SetupMaterial(options.View.BuildAreaLineColor, options.View.BuildAreaLineColor, 100f);
            GL.Normal3(Vector3.UnitZ);
            GL.Begin(PrimitiveType.LineStrip);
            if (homePosition.Y != 0)
                GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, buildAreaSize.Y, 0);
            GL.Vertex3(buildAreaSize.X, buildAreaSize.Y, 0);
            GL.Vertex3(buildAreaSize.X, 0, 0);
            if (homePosition.X != 0)
                GL.Vertex3(0, 0, 0);
            GL.End();

            if (options.View.ShowBuildArea)
                DrawBuildAreaLimits(buildAreaSize);

            int minIndex = (int)Math.Truncate(-homePosition.X);
            int maxIndex = (int)Math.Truncate(buildAreaSize.X - homePosition.X);
            for (int i = minIndex; i <= maxIndex; i++)
            {
                SetupLineColor(i);
                GL.Begin(PrimitiveType.Lines);
                GL.Vertex3(i + homePosition.X, 0, 0);
                GL.Vertex3(i + homePosition.X, buildAreaSize.Y, 0);
                GL.End();
            }

            minIndex = (int)Math.Truncate(-homePosition.Y);
            maxIndex = (int)Math.Truncate(buildAreaSize.Y - homePosition.Y);
            for (int i = minIndex; i <= maxIndex; i++)
            {
                SetupLineColor(i);
                GL.Begin(PrimitiveType.Lines);
                GL.Vertex3(0, i + homePosition.Y, 0);
                GL.Vertex3(buildAreaSize.X, i + homePosition.Y, 0);
                GL.End();
            }

            GL.PopMatrix();
        }

        private void SetupLineColor(int index)
        {
            if (index == 0 && options.View.ShowAxes)
                SetupMaterial(options.View.AxisColor, options.View.AxisColor, 100f);
            else if ((index % options.View.MajorGridlineFactor) == 0)
                SetupMaterial(options.View.MajorGridlineColor, options.View.MajorGridlineColor, 100f);
            else
                SetupMaterial(options.View.MinorGridlineColor, options.View.MinorGridlineColor, 100f);
        }

        private void DrawBuildAreaLimits(Vector3 buildAreaSize)
        {
            GL.Enable(EnableCap.LineStipple);
            GL.LineStipple(1, 0x00ff);

            GL.Begin(PrimitiveType.LineLoop);
            GL.Normal3(Vector3.UnitZ);
            GL.Vertex3(0, 0, buildAreaSize.Z);
            GL.Vertex3(0, buildAreaSize.Y, buildAreaSize.Z);
            GL.Vertex3(buildAreaSize.X, buildAreaSize.Y, buildAreaSize.Z);
            GL.Vertex3(buildAreaSize.X, 0, buildAreaSize.Z);
            GL.End();


            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, buildAreaSize.Z);
            GL.End();

            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0, buildAreaSize.Y, 0);
            GL.Vertex3(0, buildAreaSize.Y, buildAreaSize.Z);
            GL.End();

            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(buildAreaSize.X, buildAreaSize.Y, 0);
            GL.Vertex3(buildAreaSize.X, buildAreaSize.Y, buildAreaSize.Z);
            GL.End();

            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(buildAreaSize.X, 0, 0);
            GL.Vertex3(buildAreaSize.X, 0, buildAreaSize.Z);
            GL.End();

            GL.Disable(EnableCap.LineStipple);
        }

        /// <summary>
        /// Отрисовать модель
        /// </summary>
        private void DrawModel(float z)
        {
            Vector3 viewScale = GetViewScale();
            Vector3 viewPosition = GetViewPosition();
            foreach (Facet facet in model.GetFacetsBelowPlane(z))
            {
                GL.Begin(PrimitiveType.Triangles);
                GL.Normal3(facet.Normal);
                GL.Vertex3(facet.Vx1 * viewScale + viewPosition);
                GL.Vertex3(facet.Vx2 * viewScale + viewPosition);
                GL.Vertex3(facet.Vx3 * viewScale + viewPosition);
                GL.End();
            }
        }

        /// <summary>
        /// Отрисовать скирт
        /// </summary>
        private void DrawSkirt()
        {
            if (!options.Skirt.Enabled || model.IsEmpty)
                return;

            GL.Normal3(Vector3.UnitZ);
            GL.LineWidth(options.View.SliceLineWidth);
            Slice slice = model.GetSkirt(scale.X, options);
            DrawSliceParts(slice);
            for (int i = 1; i < options.Skirt.Count; i++)
            {
                slice = slice.Expand(new SimpleSliceExpander(), -options.Skirt.Step / scale.X);
                DrawSliceParts(slice);
            }
        }

        /// <summary>
        /// Отрисовать срез модели
        /// </summary>
        private void DrawSlice(float z, float delta, int sliceIndex)
        {
            GL.Normal3(Vector3.UnitZ);
            SetupMaterial(options.View.SliceLineColor, options.View.SliceLineColor, 100f);
            GL.LineWidth(options.View.SliceLineWidth);
            Slice slice = model.GetSlice(z, options);
            slice.Index = sliceIndex;
            if (cbSolidLayer.Checked)
            {
                Slice nextSlice = model.GetSlice(z + delta, options);
                Slice solidLayer = Slice.Combine(slice, nextSlice, z);
                slice.Parts.AddRange(nextSlice.Parts);
                DrawSliceParts(solidLayer);
                if (solidLayer.Parts.Count > 0)
                    DrawFill(solidLayer, true);
            }
            else
            {
                DrawSliceParts(slice);
                if (slice.Parts.Count > 0)
                    DrawFill(slice, false);
            }


            if (cbInnerPerimeter.Checked)
            {
                slice = slice.Expand(new SimpleSliceExpander(), -0.2f);
                DrawSliceParts(slice);
            }
        }

        private void DrawSliceParts(Slice slice)
        {
            Vector3 viewScale = GetViewScale();
            Vector3 viewPosition = GetViewPosition();
            foreach (SlicePart part in slice.Parts)
            {
                if (part.Closed)
                    GL.Begin(PrimitiveType.LineLoop);
                else
                    GL.Begin(PrimitiveType.LineStrip);
                foreach (Vector3 point in part.Points)
                {
                    GL.Vertex3(point * viewScale + viewPosition);
                }
                GL.End();
            }
        }

        private void DrawFill(Slice slice, bool solid)
        {
            Vector3 viewScale = GetViewScale();
            Vector3 viewPosition = GetViewPosition();
            SetupMaterial(options.View.FillLineColor, options.View.FillLineColor, 100f);
            GL.LineWidth(options.View.FillLineWidth);
            FillFactory fillFactory = CreateFillFactory();
            fillFactory.LayerByLayer = options.Fill.LayerByLayer;
            float step = options.Printer.ExtruderDiameter * 100f / (solid ? 100f : options.Fill.Percentage);
            Fill fill = fillFactory.CreateFill(slice, (float)(options.Fill.AngleInDegrees * Math.PI / 180), step / scale.X);
            foreach (FillPart part in fill.Parts)
            {
                GL.Begin(PrimitiveType.LineStrip);
                foreach (Vector3 point in part.Points)
                {
                    GL.Vertex3(point * viewScale + viewPosition);
                }
                GL.End();
            }
        }

        private FillFactory CreateFillFactory()
        {
            switch (options.Fill.FillType)
            {
                case FillType.CrossHatch:
                    return new CrossHatchFillFactory() {
                        CrossAngle = (float)(options.Fill.CrossAngleInDegrees * Math.PI / 180)
                    };
                case FillType.Triangle:
                    return new TriangleFillFactory();
            }
            return new HatchFillFactory();
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            glControl1.Invalidate();
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            edDistance.Value = 30;
            edRotationX.Value = 45;
            edRotationZ.Value = 40;
            glControl1.Invalidate();
        }

        private void butX90_Click(object sender, EventArgs e)
        {
            Matrix3 matrix = Matrix3.CreateRotationX((float)(90 * Math.PI / 180));
            model.Transform(matrix);
            UpdateView();
        }

        private void butY90_Click(object sender, EventArgs e)
        {
            Matrix3 matrix = Matrix3.CreateRotationY((float)(90 * Math.PI / 180));
            model.Transform(matrix);
            UpdateView();
        }

        private void butZ90_Click(object sender, EventArgs e)
        {
            Matrix3 matrix = Matrix3.CreateRotationZ((float)(90 * Math.PI / 180));
            model.Transform(matrix);
            UpdateView();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm frm = new AboutForm())
            {
                frm.ShowDialog(this);
            }
        }

        private void menuOptionsSettings_Click(object sender, EventArgs e)
        {
            using (SettingsForm frm = new SettingsForm())
            {
                frm.Options.CopyFrom(options);
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    options.CopyFrom(frm.Options);
                    SaveSettings();
                    glControl1.Invalidate();
                }
            }
        }

        private void UpdateView()
        {
            Vector2 offset = new Vector2(
                (float)edPositionX.Value - options.Printer.BuildAreaWidth / 2,
                (float)edPositionY.Value - options.Printer.BuildAreaDepth / 2);
            ObjectDimensions dimensions = model.Dimensions;
            position.X = offset.X - (dimensions.Size.X / 2 + dimensions.MinPoint.X) * scale.X;
            position.Y = offset.Y - (dimensions.Size.Y / 2 + dimensions.MinPoint.Y) * scale.Y;
            position.Z = -dimensions.MinPoint.Z * scale.Z;
            UpdateScalingUI();
            glControl1.Invalidate();
        }

        private void edScaleX_ValueChanged(object sender, EventArgs e)
        {
            if (lockScaling)
                return;
            if (cbKeepAspect.Checked)
                scale = new Vector3((float)(edScaleX.Value / 100));
            else
                scale.X = (float)(edScaleX.Value / 100);
            UpdateView();
        }

        private void edScaleY_ValueChanged(object sender, EventArgs e)
        {
            if (lockScaling)
                return;
            if (cbKeepAspect.Checked)
                scale = new Vector3((float)(edScaleY.Value / 100));
            else
                scale.Y = (float)(edScaleY.Value / 100);
            UpdateView();
        }

        private void edScaleZ_ValueChanged(object sender, EventArgs e)
        {
            if (lockScaling)
                return;
            if (cbKeepAspect.Checked)
                scale = new Vector3((float)(edScaleZ.Value / 100));
            else
                scale.Z = (float)(edScaleZ.Value / 100);
            UpdateView();
        }

        private void cbKeepAspect_CheckedChanged(object sender, EventArgs e)
        {
            if (lockScaling || !cbKeepAspect.Checked)
                return;
            scale = new Vector3((float)(edScaleX.Value / 100));
            UpdateView();
        }

        private void butAutoScaling_Click(object sender, EventArgs e)
        {
            SetupAutoScaleAndPosition();
            glControl1.Invalidate();
        }

        private void butResetScaling_Click(object sender, EventArgs e)
        {
            Vector3 size = model.Dimensions.Size;
            Vector3 buildAreaSize = options.Printer.GetBuildAreaSize();
            if (size.X > buildAreaSize.X || size.Y > buildAreaSize.Y || size.Z > buildAreaSize.Z)
            {
                MessageBox.Show("Актуальные размеры 3-D модели больше размеров рабочей области принтера!\n" +
                    "Будет выполнено автоматическое масштабирование.",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SetupAutoScaleAndPosition();
                glControl1.Invalidate();
                return;
            }
            scale = Vector3.One;
            UpdateView();
        }

        private void edModelWidth_ValueChanged(object sender, EventArgs e)
        {
            if (lockScaling)
                return;
            Vector3 modelSize = model.Dimensions.Size;
            if (modelSize.X > 0f)
            {
                float requiredSize = (float)edModelWidth.Value;
                float scaleFactor = requiredSize / modelSize.X;
                if (cbKeepAspect.Checked)
                    scale = new Vector3(scaleFactor);
                else
                    scale.X = scaleFactor;
            }
            UpdateView();
        }

        private void edModelDepth_ValueChanged(object sender, EventArgs e)
        {
            if (lockScaling)
                return;
            Vector3 modelSize = model.Dimensions.Size;
            if (modelSize.Y > 0f)
            {
                float requiredSize = (float)edModelDepth.Value;
                float scaleFactor = requiredSize / modelSize.Y;
                if (cbKeepAspect.Checked)
                    scale = new Vector3(scaleFactor);
                else
                    scale.Y = scaleFactor;
            }
            UpdateView();
        }

        private void edModelHeight_ValueChanged(object sender, EventArgs e)
        {
            if (lockScaling)
                return;
            Vector3 modelSize = model.Dimensions.Size;
            if (modelSize.Z > 0f)
            {
                float requiredSize = (float)edModelHeight.Value;
                float scaleFactor = requiredSize / modelSize.Z;
                if (cbKeepAspect.Checked)
                    scale = new Vector3(scaleFactor);
                else
                    scale.Z = scaleFactor;
            }
            UpdateView();
        }

        private void edPositionX_ValueChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void edPositionY_ValueChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void ResetPositionUI()
        {
            edPositionX.Value = (decimal)options.Printer.BuildAreaWidth / 2;
            edPositionY.Value = (decimal)options.Printer.BuildAreaDepth / 2;
        }

        private void panDisplay_SizeChanged(object sender, EventArgs e)
        {
            edRotationX.Width = panDisplay.Width - edRotationX.Location.X * 2;
            edRotationZ.Width = panDisplay.Width - edRotationZ.Location.X * 2;
            edDistance.Width = panDisplay.Width - edDistance.Location.X * 2;
        }

        private void panModel_SizeChanged(object sender, EventArgs e)
        {
            edPlane.Width = panModel.Width - edPlane.Location.X * 2;
        }

        private void mnuFileGenerateGCode_Click(object sender, EventArgs e)
        {
            if (model.IsEmpty)
            {
                MessageBox.Show("Загрузите модель 3-D объекта!",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                Model scaledModel = GetScaledModel();
                Vector2 modelPosition = new Vector2((float)edPositionX.Value, (float)edPositionY.Value);
                IExporter exporter = new GCodeExporter(scaledModel, options, modelPosition) { Expander = new SimpleSliceExpander() };
                using (ProgressForm frm = new ProgressForm())
                {
                    frm.Text = "Генерация G-Code";
                    frm.Exporter = exporter;
                    frm.FileName = fileName;
                    DialogResult result = frm.ShowDialog(this);
                    if (result == DialogResult.OK)
                    {
                        string estimatedTime = exporter.EstimatedTime.ToString(@"hh\:mm\:ss");
                        MessageBox.Show($"G-Code успешно записан в файл '{fileName}'!\nПримерное время печати {estimatedTime}.",
                            Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result == DialogResult.Abort)
                    {
                        MessageBox.Show($"G-Code частично записан в файл '{fileName}'!",
                            Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private Model GetScaledModel()
        {
            Model result = model.Clone();
            Matrix3 matrix = Matrix3.CreateScale(scale);
            result.Transform(matrix);
            return result;
        }
    }
}
