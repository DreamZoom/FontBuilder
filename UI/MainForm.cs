using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using FontBuilder.Core;

namespace FontBuilder.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            var fc = ExtractFontConfiguration();
            fc.ShowGridLines = true;
            var bm = fc.ExportAsBitmap();

            var frm = new Form {
                ShowInTaskbar = false,
                Text = "FontBuilder Font Preview",
                MaximizeBox = false,
                FormBorderStyle = FormBorderStyle.FixedSingle
            };

            var control = new PictureBox {Dock = DockStyle.Fill, Image = bm};

            frm.Controls.Add(control);
            frm.Width = bm.Width + 20;
            frm.Height = bm.Height + 50;
            frm.Show();
        }

        private FontConfiguration ExtractFontConfiguration()
        {
            var ff = (FontFamily) cmbFontFamily.SelectedValue;
            
            var font = new Font(ff, 10, FontStyle.Regular);
            
            var characters = ExtractChars();
            var height = numCharHeight.Value;

            var fc = new FontConfiguration(font, characters) {
                CharSize = new Size((int) txtCharWidth.Value, (int) txtCharHeight.Value),
                ItemsPerRow = (int) height,
                BackColor = lblBackgroundColor.BackColor,
                ForeColor = lblForegroundColor.BackColor
            };

            return fc;
        }

        private List<char> ExtractChars()
        {
            var selectedItem = cmbPrintedChars.SelectedIndex;
            var chType = PrefinedListType.AlphanumericAndSymbols;

            if (selectedItem == 0)
                chType = PrefinedListType.Numeric;

            if (selectedItem == 1)
                chType = PrefinedListType.Alphabet;

            if (selectedItem == 2)
                chType = PrefinedListType.Alphanumeric;

            return Helper.GetCharList(chType);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ifc = new InstalledFontCollection();
            var fontFamilies = ifc.Families;

            cmbFontFamily.DisplayMember = "Name";
            cmbFontFamily.DataSource = fontFamilies;

            cmbPrintedChars.SelectedIndex = 0;

            lblForegroundColor.BackColor = Color.Black;
            lblBackgroundColor.BackColor = Color.Transparent;
        }

        private void RefreshSelectedFont(object sender, EventArgs e)
        {
            var ff = (FontFamily) cmbFontFamily.SelectedValue;
            var style = Helper.GetFittingStyle(ff);
            var font = new Font(ff, 12, style);

            fontPreview.Font = font;
        }

        private void CmbPrintedCharsSelectedIndexChanged(object sender, EventArgs e)
        {
            var chars = ExtractChars();
            var count = chars.Count;

            numCharWidth.Text = count.ToString();

            if ( numCharHeight.Value < count )
                numCharHeight.Value = 1;

            numCharHeight.Maximum = count;
        }

        private void PickBackgroundColor( object sender, EventArgs e)
        {
            var picker = sender as Control;

            if (picker == null)
                return;

            var colorDialog = new ColorDialog();

            if ( colorDialog.ShowDialog() == DialogResult.OK )
                picker.BackColor = colorDialog.Color;
        }

        private void Button2Click(object sender, EventArgs e)
        {
            var ew = new ExportWindow {Configuration = ExtractFontConfiguration()};
            ew.ShowDialog();
        }
    }
}
