using ADay.Core.Consts;
using System.Drawing;

namespace ADay.Core.Models.Theme;

/// <summary>
/// Color themes.
/// </summary>
public enum Theme
{
    None = 0,
    Red = 1,
    Orange = 2,
    Green = 3,
    Teal = 4,
    Blue = 5,
    Violet = 6,
    Fuchsia = 7,
}

public static class RecipeThemeExtensions
{
    /// <summary>
    /// Get the foreground color associated with this theme.
    /// </summary>
    public static string Color(this Theme theme) => theme switch
    {
        Theme.Red => "palevioletred",
        Theme.Orange => "lightsalmon",
        Theme.Green => "limegreen",
        Theme.Teal => "lightseagreen",
        Theme.Blue => "lightskyblue",
        Theme.Violet => "mediumpurple",
        Theme.Fuchsia => "fuchsia",
        _ => "currentColor"
    };

    /// <summary>
    /// Get the background color associated with this theme.
    /// </summary>
    public static string BackgroundColor(this Theme theme)
    {
        if (ColorConsts.NamedColors.TryGetValue(theme.Color(), out string? hex))
        {
            var color = hex == null ? System.Drawing.Color.Empty : ColorTranslator.FromHtml(hex);
            return $"rgba({color.R},{color.G},{color.B},{ColorConsts.BackgroundOpacity})";
        }

        return "transparent";
    }
}
