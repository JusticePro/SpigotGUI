using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpigotGUI
{
    public class Style
    {

        // Default Styles
        public static Style Spigot_Gui_Home =
            new Style(
                Color.FromArgb(66, 157, 244), // Background
                Color.FromArgb(66, 197, 244), // Panel
                Color.FromArgb(66, 167, 244), // Group
                Color.Black, // Text
                "SpigotGUI Home"); // Name

        public static Style Spigot_Gui_Standard =
            new Style(
                Color.FromArgb(255, 174, 3), // Background
                Color.FromArgb(255, 209, 49), // Panel
                Color.FromArgb(255, 180, 49), // Group
                Color.Black, // Text
                "SpigotGUI Standard");

        public static Style Spigot_Gui_Pro =
            new Style(
                Color.FromArgb(180, 0, 0), // Background
                Color.FromArgb(220, 100, 100), // Panel
                Color.FromArgb(220, 50, 50), // Group
                Color.Black, // Text
                "SpigotGUI Professional"); // Name

        public static Style Spigot_Gui_Dark =
            new Style(
                Color.FromArgb(180, 180, 180), // Background
                Color.FromArgb(100, 100, 100), // Panel
                Color.FromArgb(50, 50, 50), // Group
                Color.Black, // Text
                "SpigotGUI Dark"); // Name


        private Color background, panel, group, text;
        public string name;

        public Style(Color background, Color panel, Color group, Color text, string name)
        {
            this.background = background;
            this.panel = panel;
            this.group = group;
            this.text = text;

            this.name = name;
        }

        public Color getBackground()
        {
            return background;
        }

        public Color getPanel()
        {
            return panel;
        }

        public Color getGroup()
        {
            return group;
        }

        public Color getText()
        {
            return text;
        }

    }
}
