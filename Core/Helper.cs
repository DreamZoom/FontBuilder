using System.Collections.Generic;
using System.Drawing;

namespace FontBuilder.Core
{
    public class Helper
    {
        public static List<char> GetCharList(PrefinedListType listType)
        {
            var characters = new List<char>();

            switch (listType)
            {
                case PrefinedListType.Alphabet:
                    for (var i = 'a'; i <= 'z'; i++)
                        characters.Add(i);

                    for (var i = 'A'; i <= 'Z'; i++)
                        characters.Add(i);
                    break;

                case PrefinedListType.Numeric:

                    for (int i = 0; i <= 9; i++)
                    {
                        char character = i.ToString().ToCharArray()[0];
                        characters.Add(character);
                    }
                    break;

                case PrefinedListType.Alphanumeric:
                    var lst = GetCharList(PrefinedListType.Alphabet);
                    var num = GetCharList(PrefinedListType.Numeric);

                    characters.AddRange(lst);
                    characters.AddRange(num);
                    break;

                case PrefinedListType.AlphanumericAndSymbols:
                    var list = GetCharList(PrefinedListType.Alphanumeric);
                    var symbols = new[] {'.', ',', ';', ':', '-', '_', '!', '¡', '¿', '?'};

                    characters.AddRange(list);
                    characters.AddRange(symbols);

                    break;
            }

            return characters;
        }

        public static FontStyle GetFittingStyle(FontFamily ff)
        {
            var style = FontStyle.Regular;

            if (!ff.IsStyleAvailable(style))
            {
                style = ff.IsStyleAvailable(FontStyle.Bold)
                            ? FontStyle.Bold
                            : ff.IsStyleAvailable(FontStyle.Italic)
                                  ? FontStyle.Italic
                                  : ff.IsStyleAvailable(FontStyle.Strikeout)
                                        ? FontStyle.Strikeout
                                        : FontStyle.Underline;
            }

            return style;
        }
    }
}
