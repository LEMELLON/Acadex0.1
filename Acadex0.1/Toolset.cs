using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acadex0._1
{

    public class Toolset
    {
        public static void MakeRounded(Control control, int radius)
        {
            control.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                int w = control.Width, h = control.Height;
                int d = radius * 2;

                var path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddArc(0, 0, d, d, 180, 90);
                path.AddArc(w - d, 0, d, d, 270, 90);
                path.AddArc(w - d, h - d, d, d, 0, 90);
                path.AddArc(0, h - d, d, d, 90, 90);
                path.CloseFigure();

                // Fill shape with the control's BackColor
                using (SolidBrush brush = new SolidBrush(control.BackColor))
                    e.Graphics.FillPath(brush, path);

                control.Region = new Region(path);
            };

            // Redraw when resized
            control.Resize += (s, e) => control.Invalidate();
        }
        public static void MakeTransparent(Label label, PictureBox BG)
        {
            var newLocation = BG.PointToClient(label.Parent.PointToScreen(label.Location));

            label.Parent = BG;
            label.BackColor = Color.Transparent;
            label.Location = newLocation;
        }
        public static string GetSubjectName(string abbreviation)
        {
            var subject = DataBase1.Subjects.Find(s => s.abbreviation == abbreviation);
            return subject != default ? subject.name : null; // or return "Unknown" if you prefer
        }
    }
}
