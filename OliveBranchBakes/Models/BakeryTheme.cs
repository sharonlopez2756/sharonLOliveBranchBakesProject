using System.Drawing;

namespace OliveBranchBakes.Models
{
    
    public static class BakeryTheme
    {
        // Primary palette
        public static readonly Color Cream = Color.FromArgb(255, 248, 231);          
        public static readonly Color OliveGreen = Color.FromArgb(85, 107, 47);      
        public static readonly Color WarmBrown = Color.FromArgb(139, 90, 43);        
        public static readonly Color HoneyGold = Color.FromArgb(218, 165, 32);       
        public static readonly Color SoftCream = Color.FromArgb(255, 253, 245);     

        // Seasonal accents 
        public static readonly Color SeasonalBerry = Color.FromArgb(178, 84, 84);    
        public static readonly Color SeasonalSage = Color.FromArgb(143, 160, 120);   

        // Supporting neutrals
        public static readonly Color TextDark = Color.FromArgb(62, 44, 28);         
        public static readonly Color BorderSoft = Color.FromArgb(200, 180, 140);     
        public static readonly Color ButtonHover = Color.FromArgb(100, 125, 55);     

        // Typography
        public const string PrimaryFontFamily = "Segoe UI";
        public const float TitleFontSize = 22f;
        public const float HeadingFontSize = 14f;
        public const float BodyFontSize = 12f;
        public const float ButtonFontSize = 12f;

        // tablet touch friendly planning
        public const int MinTouchHeight = 40;
        public const int MinTouchWidth = 100;
        public const int FormPadding = 20;
        public const int ControlSpacing = 12;
    }
}
