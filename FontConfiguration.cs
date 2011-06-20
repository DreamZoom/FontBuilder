using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace FontBuilder
{
    public class FontConfiguration
    {
        public List<char> Characters { get; private set; }

        public Size CharSize { get; set; }

        public int ItemsPerRow { get; set; }

        public Font Font { get; set; }

        public Color BackColor { get; set; }

        public Color ForeColor { get; set; }

        public bool ShowGridLines { get; set; }

        public static readonly float FontFactor = .5f;

        public FontConfiguration(Font font, ICollection<char> characters)
        {
            Characters = new List<char>(characters);
            Font = font;
            ItemsPerRow = characters.Count;
        }

        public Bitmap ExportAsBitmap()
        {
            var bitmapSz = GetBitmapSize();
            var bm = new Bitmap(bitmapSz.Width, bitmapSz.Height);

            var graphics = Graphics.FromImage(bm);
            graphics.Clear(BackColor);
            
            var currentRowWidth = 0;
            var currentRowHeight = 0;

            for (int i = 0; i < Characters.Count; i++)
            {
                if (currentRowWidth >= ItemsPerRow)
                {
                    currentRowWidth = 0;
                    currentRowHeight++;
                }

                var x = currentRowWidth * CharSize.Width;
                var y = currentRowHeight * CharSize.Height;
                var sz = BestFittingSize(graphics);

                var font = new Font(Font.FontFamily, sz, GraphicsUnit.Pixel);
                var foreColor = new SolidBrush(ForeColor);

                graphics.DrawString(Characters[i].ToString(), font, foreColor, x, y, StringFormat.GenericDefault);
                
                currentRowWidth++;
            }

            if ( ShowGridLines )
            {
                var topCols = currentRowHeight + (currentRowWidth == 0 ? 0 : 1);
                currentRowHeight = 0;
                currentRowWidth = 0;

                for (int i = 0; i < Characters.Count; i++)
                {
                    if (currentRowWidth >= ItemsPerRow)
                    {
                        currentRowWidth = 0;
                        currentRowHeight++;
                    }

                    var x = currentRowWidth * CharSize.Width;
                    var y = currentRowHeight * CharSize.Height;
                    
                    

                    currentRowWidth++;
                }

                for (int i = 0; i < ItemsPerRow; i++)
                {
                    for (int j = 0; j < topCols; j++)
                    {
                        var x = i * CharSize.Width;
                        var y = j * CharSize.Height;

                        var pen = new Pen(Color.Black);
                        pen.DashStyle = DashStyle.Dot;

                        graphics.DrawLine(pen, x, y, x, topCols * CharSize.Height);
                        graphics.DrawLine(pen, x, y, ItemsPerRow * CharSize.Width, y);
                    }
                }

                graphics.DrawRectangle(new Pen(Color.Black, 1), 0, 0, bitmapSz.Width - 1, bitmapSz.Height - 1);
            }
            

            graphics.Flush();
            return bm;
        }

        private float BestFittingSize( Graphics graphics )
        {
            float width = 0;
            float height = 0;
            float fontSize = FontFactor;

            var font = new Font(Font.FontFamily, fontSize, GraphicsUnit.Pixel);
            
            while ( width < CharSize.Width && height < CharSize.Height )
            {
                fontSize += FontFactor;
                font = new Font(Font.FontFamily, fontSize, GraphicsUnit.Pixel);

                var sz = graphics.MeasureString("X", font);
                width = sz.Width;
                height = sz.Height;
            }

            return fontSize;
        }

        private Size GetBitmapSize()
        {
            var amountRows = (Characters.Count/ItemsPerRow);

            if (Characters.Count % ItemsPerRow != 0)
                amountRows++;

            return new Size( ItemsPerRow * CharSize.Width, amountRows * CharSize.Height);
        }
    }
}
