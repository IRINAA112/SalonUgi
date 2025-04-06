using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

            // Use regex to separate commands and numbers
            var regex = new Regex(@"([MLCZmlcz])|([-+]?[0-9]*\.?[0-9]+(?:[eE][-+]?[0-9]+)?)");
            var matches = regex.Matches(svgPath);

            int i = 0;
            string currentCommand = "";

            while (i < matches.Count)
            {
                var token = matches[i].Value;

                if (Regex.IsMatch(token, @"[MLCZmlcz]"))
                {
                    currentCommand = token.ToUpper(); // We assume all commands are absolute (for simplicity)
                    i++;
                    continue;
                }

                switch (currentCommand)
                {
                    case "M":
                        {
                            float x = float.Parse(matches[i++].Value, CultureInfo.InvariantCulture) * scale + offsetX;
                            float y = float.Parse(matches[i++].Value, CultureInfo.InvariantCulture) * scale + offsetY;
                            startX = x;
                            startY = y;

                            if (!hasFirstPoint)
                            {
                                firstX = startX;
                                firstY = startY;
                                hasFirstPoint = true;
                            }

                            // MoveTo sets the starting point but doesn't draw
                            break;
                        }
                    case "L":
                        {
                            float x = float.Parse(matches[i++].Value, CultureInfo.InvariantCulture) * scale + offsetX;
                            float y = float.Parse(matches[i++].Value, CultureInfo.InvariantCulture) * scale + offsetY;

                            path.AddLine(startX, startY, x, y);
                            startX = x;
                            startY = y;
                            break;
                        }
                    case "C":
                        {
                            float cx1 = float.Parse(matches[i++].Value, CultureInfo.InvariantCulture) * scale + offsetX;
                            float cy1 = float.Parse(matches[i++].Value, CultureInfo.InvariantCulture) * scale + offsetY;
                            float cx2 = float.Parse(matches[i++].Value, CultureInfo.InvariantCulture) * scale + offsetX;
                            float cy2 = float.Parse(matches[i++].Value, CultureInfo.InvariantCulture) * scale + offsetY;
                            float x = float.Parse(matches[i++].Value, CultureInfo.InvariantCulture) * scale + offsetX;
                            float y = float.Parse(matches[i++].Value, CultureInfo.InvariantCulture) * scale + offsetY;

                            path.AddBezier(startX, startY, cx1, cy1, cx2, cy2, x, y);
                            startX = x;
                            startY = y;
                            break;
                        }
                    case "Z":
                        {
                            path.CloseFigure();
                            startX = firstX;
                            startY = firstY;
                            break;
                        }
                    default:
                        throw new NotSupportedException($"Unsupported or missing SVG command near: {token}");
                }
            }

            return new Region(path);
        }
    }
}
