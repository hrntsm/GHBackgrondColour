using System;
using System.Drawing;

using Grasshopper;
using Grasshopper.Kernel;

namespace GHBackgroundColor
{
    public class GHBackgroundColorInfo : GH_AssemblyInfo
    {
        public override string Name => "GHBackgroundColor Info";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("c2df66a7-0178-4f6d-b1d1-b2043ccc3c4e");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}