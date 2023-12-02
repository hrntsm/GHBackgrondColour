using System;
using System.Drawing;

using Grasshopper.Kernel;
using Grasshopper.GUI.Canvas;

namespace GHBackgroundColor
{
    public class GHBackgroundColor : GH_Component
    {
        public GHBackgroundColor()
          : base("BGColor", "BGColor",
            "Description of component",
            "Display", "Background")
        {
        }

        protected override void RegisterInputParams(GH_InputParamManager pManager)
        {
            pManager.AddBooleanParameter("switcher", "sw", "color switcher", GH_ParamAccess.item, true);
            pManager.AddColourParameter("canvas_back", "back", "canvas background color", GH_ParamAccess.item, Color.White);
            pManager.AddColourParameter("canvas_grid", "grid", "canvas grid color", GH_ParamAccess.item, Color.White);
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager)
        {
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            bool switcher = true;
            Color canvas_back = Color.White;
            Color canvas_grid = Color.White;

            if (!DA.GetData(0, ref switcher)) return;
            if (!DA.GetData(1, ref canvas_back)) return;
            if (!DA.GetData(2, ref canvas_grid)) return;

            if (switcher == true)
            {
                GH_Skin.canvas_grid = canvas_grid;
                GH_Skin.canvas_back = canvas_back;
                GH_Skin.canvas_edge = Color.FromArgb(255, 0, 0, 0);
                GH_Skin.canvas_shade = Color.FromArgb(80, 0, 0, 0);
            }
            else
            {
                //DEFAULTS
                GH_Skin.canvas_grid = Color.FromArgb(30, 0, 0, 0);
                GH_Skin.canvas_back = Color.FromArgb(255, 212, 208, 200);
                GH_Skin.canvas_edge = Color.FromArgb(255, 0, 0, 0);
                GH_Skin.canvas_shade = Color.FromArgb(80, 0, 0, 0);
            }
        }

        protected override Bitmap Icon => null;

        public override Guid ComponentGuid => new Guid("7865d09d-e0e0-441a-8bb5-5deabfddab86");
    }
}