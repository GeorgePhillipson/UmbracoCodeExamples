using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Web.Helper.EnumHelper
{
    public static class EnumFontSize
    {
        
        public enum FontSizeEnum
        {
            [Description("twelvePx")]
            TwelvePx    = 12,
            [Description("fourteenPx")]
            FourteenPx  = 14,
            [Description("sixteenPx")]
            SixteenPx   = 16,
            [Description("twentyPx")]
            TwentyPx    = 20,
            // [Description("50")] 
            // 50 = 50 //This will not work, if you want to use a numbers use the extension below

        }
    }

    public static class DisplayFontSize
    {
        private static string DisplayFontDescription(this Enum value)
        {
            return ((DescriptionAttribute)Attribute.GetCustomAttribute(
                       value.GetType().GetFields(BindingFlags.Public | BindingFlags.Static)
                           .Single(x => x.GetValue(null).Equals(value)), typeof(DescriptionAttribute)))?.Description ??
                   value.ToString();
        }
        public static string SectionFontSize(int enumFontSize)
        {  
            string displayFontSize = "twelvePx";
            switch (enumFontSize)
            {
                case (int)EnumFontSize.FontSizeEnum.TwelvePx:
                    displayFontSize = EnumFontSize.FontSizeEnum.TwelvePx.DisplayFontDescription();
                    break;
                case (int)EnumFontSize.FontSizeEnum.FourteenPx:
                    displayFontSize = EnumFontSize.FontSizeEnum.FourteenPx.DisplayFontDescription();
                    break;
                case (int)EnumFontSize.FontSizeEnum.SixteenPx:
                    displayFontSize = EnumFontSize.FontSizeEnum.SixteenPx.DisplayFontDescription();
                    break;
                case (int)EnumFontSize.FontSizeEnum.TwentyPx:
                    displayFontSize = EnumFontSize.FontSizeEnum.TwentyPx.DisplayFontDescription();
                    break;
            }

            return displayFontSize;
        }
    }
    public static class EnumColourPicker
    {
        public enum ColourPickerEnum
        {
            Red,
            Black,
            Tomato,
            DarkOrange
        }
    }
}
