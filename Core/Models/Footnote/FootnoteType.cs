using System.ComponentModel.DataAnnotations;

namespace ADay.Core.Models.Footnote;

[Flags]
public enum FootnoteType
{
    [Display(Name = "None")]
    None = 0,

    /// <summary>
    /// User defined footnotes.
    /// </summary>
    [Display(Name = "Custom")]
    Custom = 1 << 0, // 1

    /// <summary>
    /// Good vibes. Re-parenting.
    /// 
    /// sa. You are beautiful!
    /// </summary>
    [Display(Name = "Good Vibes")]
    GoodVibes = 1 << 1, // 2

    /// <summary>
    /// Mindfulness
    /// 
    /// sa. Breathe deeply. You are in the present moment.
    /// </summary>
    [Display(Name = "Mindfulness")]
    Mindfulness = 1 << 2, // 4

    /// <summary>
    /// Life advice and tips.
    /// 
    /// sa. Practicing everyday mindfulness can improve your memory and concentration skills....
    /// </summary>
    [Display(Name = "Health Tips")]
    HealthTips = 1 << 3, // 8

    /// <summary>
    /// Health facts.
    /// </summary>
    [Display(Name = "Health Facts")]
    HealthFacts = 1 << 4, // 16

    /// <summary>
    /// Fitness advice and tips. 
    /// 
    /// sa. Take five to 10 minutes to warm up and cool down properly.
    /// </summary>
    [Display(Name = "Fitness Tips")]
    FitnessTips = 1 << 5, // 32

    /// <summary>
    /// User defined footnotes.
    /// </summary>
    [Display(Name = "Fitness Facts")]
    FitnessFacts = 1 << 6, // 64

    /// <summary>
    /// Fitness motivation.
    /// 
    /// sa. Never give up!
    /// </summary>
    [Display(Name = "Fitness Motivation")]
    FitnessMotivation = 1 << 7, // 128

    /// <summary>
    /// Fitness affirmations. 
    /// 
    /// sa. I'm getting stronger after every workout.
    /// </summary>
    [Display(Name = "Fitness Affirmations")]
    FitnessAffirmations = 1 << 8, // 256

    /// <summary>
    /// Cooking advice and tips. 
    /// 
    /// sa. Roll a lime around on a counter before cutting to get more juice.
    /// </summary>
    [Display(Name = "Cooking Tips")]
    CookingTips = 1 << 9, // 512

    /// <summary>
    /// Cooking facts. 
    /// 
    /// sa. A sharp knife is safer than dull one.
    /// </summary>
    [Display(Name = "Cooking Facts")]
    CookingFacts = 1 << 10, // 1024

    /// <summary>
    /// Digestion advice and tips.
    /// 
    /// sa. Chew your food at least 20 times before swallowing.
    /// </summary>
    [Display(Name = "Digestion Tips")]
    DigestionTips = 1 << 11, // 2048

    /// <summary>
    /// Digestion facts.
    /// 
    /// sa. Fat needs to be suspended in water in an “emulsion” that starts with chewing.
    /// </summary>
    [Display(Name = "Digestion Facts")]
    DigestionFacts = 1 << 12, // 4096

    /// <summary>
    /// Cooking motivation.
    /// 
    /// sa. Never give up!
    /// </summary>
    [Display(Name = "Cooking Motivation")]
    CookingMotivation = 1 << 13, // 8192

    /// <summary>
    /// Cooking affirmations. 
    /// 
    /// sa. My curiosity is stronger than my fear.
    /// </summary>
    [Display(Name = "Cooking Affirmations")]
    CookingAffirmations = 1 << 14, // 16384

    System = All & ~Custom, // Exerything except Custom.

    All = HealthTips | HealthFacts | GoodVibes | Mindfulness | Custom
        | FitnessTips | FitnessFacts | FitnessMotivation | FitnessAffirmations
        | CookingTips | CookingFacts | DigestionTips | DigestionFacts | CookingMotivation | CookingAffirmations
}
