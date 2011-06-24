using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using FontBuilder.Core;

namespace FontBuilder.UI
{
    public partial class ExportWindow : Form
    {
        public ExportWindow()
        {
            InitializeComponent();
        }

        public FontConfiguration Configuration { get; set; }

        private void ExportWindow_Load(object sender, EventArgs e)
        {
            var formats = new[] {
                new KeyValuePair<string, ImageFormat>("Bitmap", ImageFormat.Bmp),
                new KeyValuePair<string, ImageFormat>("Emf file", ImageFormat.Emf),
                new KeyValuePair<string, ImageFormat>("Exif image", ImageFormat.Exif),
                new KeyValuePair<string, ImageFormat>("Gif Image", ImageFormat.Gif),
                new KeyValuePair<string, ImageFormat>("Jpeg image", ImageFormat.Jpeg),
                new KeyValuePair<string, ImageFormat>("Png image", ImageFormat.Png),
            };

            cmImageFormats.DisplayMember = "Key";
            cmImageFormats.ValueMember = "Value";
            cmImageFormats.DataSource = formats;
        }

        private void Button1Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Button2Click(object sender, EventArgs e)
        {
            if ( Configuration == null )
            {
                Button1Click(this, EventArgs.Empty);
                return;
            }

            var bmp = Configuration.ExportAsBitmap();
            var selectedFormat = (ImageFormat) cmImageFormats.SelectedValue;
            var fileDialog = new SaveFileDialog { Title = "Save alphabet as..."};

            if (fileDialog.ShowDialog() != DialogResult.OK) return;

            bmp.Save(fileDialog.FileName, selectedFormat);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
