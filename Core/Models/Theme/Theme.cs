namespace ADay.Core.Models.Theme;

/// <summary>
/// Color schemes.
/// </summary>
public enum Theme
{
    /// <summary>
    /// Text.
    /// </summary>
    None = 0,

    /// <summary>
    /// Red.
    /// </summary>
    Red = 1,

    /// <summary>
    /// Orange.
    /// </summary>
    Orange = 2,

    /// <summary>
    /// Green.
    /// </summary>
    Green = 3,

    /// <summary>
    /// Teal.
    /// </summary>
    Teal = 4,

    /// <summary>
    /// Blue.
    /// </summary>
    Blue = 5,

    /// <summary>
    /// Violet.
    /// </summary>
    Violet = 6,

    /// <summary>
    /// Slate.
    /// </summary>
    Slate = 7,
}

public static class RecipeThemeExtensions
{
    public static string Color(this Theme theme) => theme switch
    {
        Theme.Red => "palevioletred",
        Theme.Orange => "lightsalmon",
        Theme.Green => "lightgreen",
        Theme.Teal => "teal",
        Theme.Blue => "lightskyblue",
        Theme.Violet => "mediumpurple",
        Theme.Slate => "slategray",
        _ => "currentColor"
    };

    public static string BackgroundColor(this Theme theme) => theme switch
    {
        Theme.Red => "rgba(250,200,200,.1)",
        Theme.Orange => "rgba(250,200,150,.1)",
        Theme.Green => "rgba(200,250,200,.1)",
        Theme.Teal => "rgba(200,225,225,.1)",
        Theme.Blue => "rgba(200,200,250,.1)",
        Theme.Violet => "rgba(250,200,250,.1)",
        Theme.Slate => "rgba(200,225,250,.1)",
        _ => "transparent"
    };
}
