
using System.Drawing;
using System.Windows.Forms;
namespace InventoryTrackingSystem

{
    class CustomProfessionalColors : ProfessionalColorTable
    {
        public override Color ToolStripGradientBegin
        { get { return Color.LightSteelBlue; } }

        public override Color ToolStripGradientMiddle
        { get { return Color.CadetBlue; } }

        public override Color ToolStripGradientEnd
        { get { return Color.CornflowerBlue; } }

        public override Color MenuStripGradientBegin
        { get { return Color.LightSteelBlue; } }

        public override Color MenuStripGradientEnd
        { get { return Color.LightSteelBlue; } }

        public override Color ToolStripDropDownBackground
        { get { return Color.LightSteelBlue; } }

        public override Color ToolStripPanelGradientEnd
        { get { return Color.SkyBlue; } }

        public override Color ToolStripBorder
        { get { return Color.SkyBlue; } }

        public override Color ToolStripContentPanelGradientBegin
        { get { return Color.LightSlateGray; } }

        public override Color ToolStripContentPanelGradientEnd
        { get { return Color.LightSlateGray; } }

        public override Color MenuBorder
        { get { return Color.LightSlateGray; } }

        public override Color MenuItemBorder
        { get { return Color.LightSteelBlue; } }

        public override Color MenuItemPressedGradientBegin
        { get { return Color.LightSteelBlue; } }

        public override Color MenuItemPressedGradientEnd
        { get { return Color.LightSteelBlue; } }

        public override Color MenuItemSelected
        { get { return Color.LightSlateGray; } }

        public override Color MenuItemSelectedGradientBegin
        { get { return Color.LightSlateGray; } }

        public override Color MenuItemSelectedGradientEnd
        { get { return Color.LightSlateGray; } }


    }

}
