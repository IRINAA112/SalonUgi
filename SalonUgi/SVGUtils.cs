using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonUgi
{
    internal static class SVGUtils
    {
        public static Region ConvertSvgPathToRegion(string svgPath, float offsetX, float offsetY, float scale = 1)
        {
            GraphicsPath path = new GraphicsPath();

            float startX = 0, startY = 0;  // Last point
            float firstX = 0, firstY = 0;  // First MoveTo point
            bool hasFirstPoint = false;

            // Split on spaces and commas, remove empty entries
            string[] tokens = svgPath.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tokens.Length; i++)
            {
                string cmd = tokens[i];

                if (cmd == "M") // MoveTo
                {
                    startX = float.Parse(tokens[i + 1], CultureInfo.InvariantCulture) * scale + offsetX;
                    startY = float.Parse(tokens[i + 2], CultureInfo.InvariantCulture) * scale + offsetY;

                    if (!hasFirstPoint)
                    {
                        firstX = startX;
                        firstY = startY;
                        hasFirstPoint = true;
                    }

                    i += 2; // Move past the coordinates
                }
                else if (cmd == "L") // LineTo
                {
                    float x = float.Parse(tokens[i + 1], CultureInfo.InvariantCulture) * scale + offsetX;
                    float y = float.Parse(tokens[i + 2], CultureInfo.InvariantCulture) * scale + offsetY;

                    path.AddLine(startX, startY, x, y);
                    startX = x;
                    startY = y;

                    i += 2;
                }
                else if (cmd == "C") // Cubic Bézier
                {
                    float cx1 = float.Parse(tokens[i + 1], CultureInfo.InvariantCulture) * scale + offsetX;
                    float cy1 = float.Parse(tokens[i + 2], CultureInfo.InvariantCulture) * scale + offsetY;
                    float cx2 = float.Parse(tokens[i + 3], CultureInfo.InvariantCulture) * scale + offsetX;
                    float cy2 = float.Parse(tokens[i + 4], CultureInfo.InvariantCulture) * scale + offsetY;
                    float x = float.Parse(tokens[i + 5], CultureInfo.InvariantCulture) * scale + offsetX;
                    float y = float.Parse(tokens[i + 6], CultureInfo.InvariantCulture) * scale + offsetY;

                    path.AddBezier(startX, startY, cx1, cy1, cx2, cy2, x, y);
                    startX = x;
                    startY = y;

                    i += 6;
                }
                else if (cmd == "Z" || cmd == "z") // Close Path
                {
                    path.CloseFigure();
                    startX = firstX;
                    startY = firstY;
                }
                else
                {
                    throw new NotSupportedException($"Unsupported SVG command: {cmd}");
                }
            }

            return new Region(path);
        }
    }
}
