using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlicerProto.Options;

namespace SlicerProto
{
    public partial class SettingsForm : Form
    {
        public SlicerOptions Options { get; } = new SlicerOptions();

        public SettingsForm()
        {
            InitializeComponent();
            SetupBindings();
        }

        private void SetupBindings()
        {
            edBuildAreaSizeX.DataBindings.Add("Value", Options.Printer, "BuildAreaWidth");
            edBuildAreaSizeY.DataBindings.Add("Value", Options.Printer, "BuildAreaDepth");
            edBuildAreaSizeZ.DataBindings.Add("Value", Options.Printer, "BuildAreaHeight");
            edHomePositionX.DataBindings.Add("Value", Options.Printer, "HomePositionX");
            edHomePositionY.DataBindings.Add("Value", Options.Printer, "HomePositionY");
            edExtruderDiameter.DataBindings.Add("Value", Options.Printer, "ExtruderDiameter");
            edExtruderTemperature.DataBindings.Add("Value", Options.Printer, "ExtruderTemperature");
            cbTableHeating.DataBindings.Add("Checked", Options.Printer, "TableHeating");
            edTableTemperature.DataBindings.Add("Value", Options.Printer, "TableTemperature");
            edTableTemperature.DataBindings.Add("Enabled", cbTableHeating, "Checked");
            cbUseFan.DataBindings.Add("Checked", Options.Printer, "UseFan");
            edFanSpeed.DataBindings.Add("Value", Options.Printer, "FanSpeed");
            edFilamentRate.DataBindings.Add("Value", Options.Printer, "FilamentRate");
            edRetract.DataBindings.Add("Value", Options.Printer, "RetractDistance");
            edSpeedXYFast.DataBindings.Add("Value", Options.Printer, "SpeedXYFast");
            edSpeedXYSlow.DataBindings.Add("Value", Options.Printer, "SpeedXYSlow");
            edSpeedZ.DataBindings.Add("Value", Options.Printer, "SpeedZ");
            edSpeedE.DataBindings.Add("Value", Options.Printer, "SpeedE");

            edSliceHeight.DataBindings.Add("Value", Options.Slice, "Step");
            edSliceOffset.DataBindings.Add("Value", Options.Slice, "Offset");
            edSimplifyDistance.DataBindings.Add("Value", Options.Slice, "SimplifyDistance");
            cbFlatten.DataBindings.Add("Checked", Options.Slice, "Flatten");
            edFlattenTolerance.DataBindings.Add("Value", Options.Slice, "FlattenTolerance");
            edFlattenTolerance.DataBindings.Add("Enabled", cbFlatten, "Checked");

            cbFillType.DataBindings.Add("SelectedIndex", Options.Fill, "FillType");
            cbLayerByLayer.DataBindings.Add("Checked", Options.Fill, "LayerByLayer");
            edPercentage.DataBindings.Add("Value", Options.Fill, "Percentage");
            edAngleInDegrees.DataBindings.Add("Value", Options.Fill, "AngleInDegrees");
            edCrossAngleInDegrees.DataBindings.Add("Value", Options.Fill, "CrossAngleInDegrees");
            cbFillLocation.DataBindings.Add("SelectedIndex", Options.Fill, "FillLocation");
            edSolidLayerCount.DataBindings.Add("Value", Options.Fill, "SolidLayerCount");

            cbPrintSkirt.DataBindings.Add("Checked", Options.Skirt, "Enabled");
            edSkirtDistance.DataBindings.Add("Value", Options.Skirt, "Distance");
            edSkirtStep.DataBindings.Add("Value", Options.Skirt, "Step");
            edSkirtCount.DataBindings.Add("Value", Options.Skirt, "Count");
            edSkirtDistance.DataBindings.Add("Enabled", cbPrintSkirt, "Checked");
            edSkirtStep.DataBindings.Add("Enabled", cbPrintSkirt, "Checked");
            edSkirtCount.DataBindings.Add("Enabled", cbPrintSkirt, "Checked");

            colorBuildAreaLine.DataBindings.Add("Color", Options.View, "BuildAreaLineColor");
            colorMajorGridlines.DataBindings.Add("Color", Options.View, "MajorGridlineColor");
            colorMinorGridlines.DataBindings.Add("Color", Options.View, "MinorGridlineColor");
            colorAxes.DataBindings.Add("Color", Options.View, "AxisColor");
            cbShowBuildArea.DataBindings.Add("Checked", Options.View, "ShowBuildArea");
            cbShowAxes.DataBindings.Add("Checked", Options.View, "ShowAxes");
            edMajorGridlineFactor.DataBindings.Add("Value", Options.View, "MajorGridlineFactor");
            colorSlice.DataBindings.Add("Color", Options.View, "SliceLineColor");
            edSliceLineWidth.DataBindings.Add("Value", Options.View, "SliceLineWidth");
            colorFill.DataBindings.Add("Color", Options.View, "FillLineColor");
            edFillLineWidth.DataBindings.Add("Value", Options.View, "FillLineWidth");
            colorModel.DataBindings.Add("Color", Options.View, "ModelColor");
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            if (edHomePositionX.Value > edBuildAreaSizeX.Value)
            {
                MessageBox.Show("Координаты X вне рабочей области принтера!",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                edHomePositionX.Focus();
                return;
            }
            if (edHomePositionY.Value > edBuildAreaSizeY.Value)
            {
                MessageBox.Show("Координаты Y вне рабочей области принтера!",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                edHomePositionY.Focus();
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void cbFillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Options.Fill.FillType = (FillType)cbFillType.SelectedIndex;
        }

        private void cbFillLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Options.Fill.FillLocation = (FillLocation)cbFillLocation.SelectedIndex;
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            Options.Reset();
        }
    }
}
