using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.ImageFiles.Raw;
using Vintasoft.Imaging.Metadata;
using Vintasoft.Imaging.UI;

using DemosCommonCode;
using DemosCommonCode.Imaging;


namespace RawImageViewerDemo
{
    /// <summary>
    /// Main form of RAW Image Viewer Demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        /// <summary>
        /// Application's title.
        /// </summary>
        string _title = string.Format("VintaSoft RAW Image Viewer Demo v{0}", ImagingGlobalSettings.ProductVersion);

        /// <summary>
        /// Opened RAW file.
        /// </summary>
        RawImageFile _rawFile;

        /// <summary>
        /// Original image of opened RAW file.
        /// </summary>
        VintasoftImage _originalImage;

        /// <summary>
        /// Selected "View - Image scale mode" menu item.
        /// </summary>
        ToolStripMenuItem _imageScaleSelectedMenuItem;

        /// <summary>
        /// Selected "Interpolation mode" menu
        /// </summary>
        ToolStripMenuItem _interpolationMenuItem;

        /// <summary>
        /// Selected "White balance" menu
        /// </summary>
        ToolStripMenuItem _whiteBalanceMenuItem;

        /// <summary>
        /// White point for red channel.
        /// </summary>
        double _whitePointRed;

        /// <summary>
        /// White point for green channel.
        /// </summary>
        double _whitePointGreen;

        /// <summary>
        /// White point for blue channel.
        /// </summary>
        double _whitePointBlue;

        /// <summary>
        /// ThumbnailViewer print manager.
        /// </summary>
        ImageViewerPrintManager _thumbnailViewerPrintManager;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // register the evaluation license for VintaSoft Imaging .NET SDK
            Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

            InitializeComponent();

            this.Text = _title;

            // init "View => Image Scale Mode" menu
            normalImageToolStripMenuItem.Tag = ImageSizeMode.Normal;
            bestFitToolStripMenuItem.Tag = ImageSizeMode.BestFit;
            fitToWidthToolStripMenuItem.Tag = ImageSizeMode.FitToWidth;
            fitToHeightToolStripMenuItem.Tag = ImageSizeMode.FitToHeight;
            pixelToPixelToolStripMenuItem.Tag = ImageSizeMode.PixelToPixel;
            scaleToolStripMenuItem.Tag = ImageSizeMode.Zoom;
            scale25ToolStripMenuItem.Tag = 25;
            scale50ToolStripMenuItem.Tag = 50;
            scale100ToolStripMenuItem.Tag = 100;
            scale200ToolStripMenuItem.Tag = 200;
            scale400ToolStripMenuItem.Tag = 400;
            _imageScaleSelectedMenuItem = normalImageToolStripMenuItem;
            _imageScaleSelectedMenuItem.Checked = true;

            // init "Page => Interpolation mode" menu
            noneInterpolationToolStripMenuItem.Tag = BayerGridInterpolationMethod.None;
            bilinearInterpolationToolStripMenuItem.Tag = BayerGridInterpolationMethod.Bilinear;
            variableInterpolationNumberGradientsToolStripMenuItem.Tag = BayerGridInterpolationMethod.Vng;
            adaptiveInterpolationHomogeneityDirectedToolStripMenuItem.Tag = BayerGridInterpolationMethod.Ahd;
            _interpolationMenuItem = bilinearInterpolationToolStripMenuItem;
            _interpolationMenuItem.Checked = true;

            // init "Page => White balance" menu
            noneWhiteBalanceToolStripMenuItem.Tag = WhiteBalanceMethod.None;
            autoWhiteBalanceToolStripMenuItem.Tag = WhiteBalanceMethod.Auto;
            cameraWhiteBalanceToolStripMenuItem.Tag = WhiteBalanceMethod.Camera;
            userWhiteBalanceToolStripMenuItem.Tag = WhiteBalanceMethod.User;
            _whiteBalanceMenuItem = cameraWhiteBalanceToolStripMenuItem;
            _whiteBalanceMenuItem.Checked = true;

            // init white points for RGB channels
            _whitePointRed = 1.0f;
            _whitePointGreen = 1.0f;
            _whitePointBlue = 1.0f;

            // create the print manager
            _thumbnailViewerPrintManager = new ImageViewerPrintManager(thumbnailViewer1, imagePrintDocument1, printImageDialog);

            // set the initial directory in open file dialog
            DemosTools.SetTestFilesFolder(openImageFileDialog);

            // update UI
            UpdateUI();
        }

        #endregion



        #region Properties

        bool _isRawFileOpening = false;
        /// <summary>
        /// Gets or sets a value indicating whether RAW file is opening.
        /// </summary>
        internal bool IsRawFileOpening
        {
            get
            {
                return _isRawFileOpening;
            }
            set
            {
                _isRawFileOpening = value;
                UpdateUI();
            }
        }

        #endregion



        #region Methods

        #region PROTECTED

        /// <summary>
        /// Processes a command key.
        /// </summary>
        /// <param name="msg">A <see cref="T:System.Windows.Forms.Message" />,
        /// passed by reference, that represents the window message to process.</param>
        /// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values
        /// that represents the key to process.</param>
        /// <returns>
        /// <b>true</b> if the character was processed by the control; otherwise, <b>false</b>.
        /// </returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Shift | Keys.Control | Keys.Add))
            {
                RotateViewClockwise();
                return true;
            }

            if (keyData == (Keys.Shift | Keys.Control | Keys.Subtract))
            {
                RotateViewCounterClockwise();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion


        #region PRIVATE

        #region UI

        #region 'File' menu

        /// <summary>
        /// Handles the Click event of openToolStripMenuItem object.
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenRawFile(openImageFileDialog.FileName);
            }
        }

        /// <summary>
        /// Handles the Click event of closeToolStripMenuItem object.
        /// </summary>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseRawFile();
        }

        /// <summary>
        /// Handles the Click event of pageSettingsToolStripMenuItem object.
        /// </summary>
        private void pageSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of printToolStripMenuItem object.
        /// </summary>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _thumbnailViewerPrintManager.Print();
        }

        /// <summary>
        /// Handles the Click event of exitToolStripMenuItem object.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseRawFile();

            Close();
        }

        #endregion


        #region 'View' menu

        /// <summary>
        /// Handles the Click event of thumbnailViewerSettingsToolStripMenuItem object.
        /// </summary>
        private void thumbnailViewerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ThumbnailViewerSettingsForm dlg = new ThumbnailViewerSettingsForm(thumbnailViewer1))
            {
                dlg.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Click event of ImageScale object.
        /// </summary>
        private void ImageScale_Click(object sender, EventArgs e)
        {
            _imageScaleSelectedMenuItem.Checked = false;
            _imageScaleSelectedMenuItem = (ToolStripMenuItem)sender;
            if (_imageScaleSelectedMenuItem.Tag is ImageSizeMode)
            {
                imageViewer1.SizeMode = (ImageSizeMode)_imageScaleSelectedMenuItem.Tag;
                _imageScaleSelectedMenuItem.Checked = true;
            }
            else
            {
                int zoomValue = (int)_imageScaleSelectedMenuItem.Tag;
                imageViewer1.SizeMode = ImageSizeMode.Zoom;
                imageViewer1.Zoom = zoomValue;
            }
        }

        /// <summary>
        /// Handles the Click event of rotateClockwiseToolStripMenuItem object.
        /// </summary>
        private void rotateClockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateViewClockwise();
        }

        /// <summary>
        /// Handles the Click event of counterclockwiseToolStripMenuItem object.
        /// </summary>
        private void counterclockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateViewCounterClockwise();
        }

        /// <summary>
        /// Handles the Click event of imageViewerSettingsToolStripMenuItem object.
        /// </summary>
        private void imageViewerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ImageViewerSettingsForm dlg = new ImageViewerSettingsForm(imageViewer1))
            {
                dlg.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the ZoomChanged event of imageViewer1 object.
        /// </summary>
        private void imageViewer1_ZoomChanged(object sender, ZoomChangedEventArgs e)
        {
            _imageScaleSelectedMenuItem.Checked = false;

            // change zoom factor in image viewer
            switch (imageViewer1.SizeMode)
            {
                case ImageSizeMode.BestFit:
                    _imageScaleSelectedMenuItem = bestFitToolStripMenuItem;
                    break;
                case ImageSizeMode.FitToHeight:
                    _imageScaleSelectedMenuItem = fitToHeightToolStripMenuItem;
                    break;
                case ImageSizeMode.FitToWidth:
                    _imageScaleSelectedMenuItem = fitToWidthToolStripMenuItem;
                    break;
                case ImageSizeMode.Normal:
                    _imageScaleSelectedMenuItem = normalImageToolStripMenuItem;
                    break;
                case ImageSizeMode.PixelToPixel:
                    _imageScaleSelectedMenuItem = pixelToPixelToolStripMenuItem;
                    break;
                case ImageSizeMode.Zoom:
                    _imageScaleSelectedMenuItem = scaleToolStripMenuItem;
                    break;
            }
            _imageScaleSelectedMenuItem.Checked = true;
        }

        #endregion


        #region 'Page' menu

        /// <summary>
        /// Handles the Click event of pageMetadataToolStripMenuItem object.
        /// </summary>
        private void pageMetadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MetadataEditorForm dlg = new MetadataEditorForm())
            {
                dlg.RootMetadataNode = new DigitalCameraRawMetadata(_rawFile.Page);
                //  show a dialog with image metadata
                dlg.ShowDialog();

                UpdateUI();
            }
        }

        /// <summary>
        /// Handles the Click event of interpolationModeToolStripMenuItem object.
        /// </summary>
        private void interpolationModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            // disable previously selected menu item
            _interpolationMenuItem.Checked = false;
            // save information about selected menu item
            _interpolationMenuItem = menuItem;
            // enable selected menu item
            _interpolationMenuItem.Checked = true;

            // update the original image
            UpdateOriginalImage();
        }

        /// <summary>
        /// Handles the Click event of whiteBalanceToolStripMenuItem object.
        /// </summary>
        private void whiteBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            // disable previously selected menu item
            _whiteBalanceMenuItem.Checked = false;
            // save information about selected menu item
            _whiteBalanceMenuItem = menuItem;
            // enable selected menu item
            _whiteBalanceMenuItem.Checked = true;

            // update the original image
            UpdateOriginalImage();
        }

        #endregion


        #region 'Help' menu

        /// <summary>
        /// Handles the Click event of aboutToolStripMenuItem object.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm dlg = new AboutBoxForm())
            {
                dlg.ShowDialog();
            }
        }

        #endregion


        /// <summary>
        /// Handles the FocusedIndexChanged event of imageViewer1 object.
        /// </summary>
        private void imageViewer1_FocusedIndexChanged(object sender, FocusedIndexChangedEventArgs e)
        {
            UpdateImageInfo();
        }

        #endregion


        #region UI state

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            bool isRawFileOpened = thumbnailViewer1.Images.Count > 0;

            closeToolStripMenuItem.Enabled = isRawFileOpened;
            printToolStripMenuItem.Enabled = isRawFileOpened;
            interpolationModeToolStripMenuItem.Enabled = isRawFileOpened;
            whiteBalanceToolStripMenuItem.Enabled = isRawFileOpened;

            pageMetadataToolStripMenuItem.Enabled = isRawFileOpened;

            imageViewerToolstrip1.PrintButtonEnabled = isRawFileOpened;

            UpdateImageInfo();
        }

        /// <summary>
        /// Updates information about focused image.
        /// </summary>
        private void UpdateImageInfo()
        {
            try
            {
                if (imageViewer1.FocusedIndex == -1 || IsRawFileOpening)
                {
                    imageInfoToolStripStatusLabel.Text = "";
                    return;
                }

                VintasoftImage image = imageViewer1.Image;

                // image size (megapixels or gigapixels)
                string sizeInfo;
                float mpx = (float)image.Width * image.Height / (1000f * 1000f);
                if (mpx < 0.01)
                    sizeInfo = (image.Width * image.Height).ToString() + "Px";
                else if (mpx < 10)
                    sizeInfo = mpx.ToString("F2", CultureInfo.InvariantCulture) + "MPx";
                else if (mpx < 1000)
                    sizeInfo = mpx.ToString("F1", CultureInfo.InvariantCulture) + "MPx";
                else
                    sizeInfo = (mpx / 1000f).ToString("F2", CultureInfo.InvariantCulture) + "GPx";

                // show information about the current image
                imageInfoToolStripStatusLabel.Text = string.Format(
                    "Width={0}, Height={1} ({2}); PixelFormat={3}; Resolution={4}",
                    image.Width, image.Height, sizeInfo, image.PixelFormat, image.Resolution);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Updates the original image.
        /// </summary>
        private void UpdateOriginalImage()
        {
            BayerGridInterpolationMethod bayerGridInterpolation = (BayerGridInterpolationMethod)_interpolationMenuItem.Tag;
            WhiteBalanceMethod whiteBalance = (WhiteBalanceMethod)_whiteBalanceMenuItem.Tag;

            RawImagePageBase page = _rawFile.Page;

            if (bayerGridInterpolation != page.InterpolationMethod ||
                whiteBalance != page.WhiteBalanceMethod ||
                whiteBalance == WhiteBalanceMethod.User)
            {
                if (page.InterpolationMethod == bayerGridInterpolation &&
                    whiteBalance == WhiteBalanceMethod.User)
                {
                    if (!WhiteBalanceForm.GetValueChannels(ref _whitePointRed, ref _whitePointGreen, ref _whitePointBlue))
                        return;

                    page.UserWhitePointForRedChannel = _whitePointRed;
                    page.UserWhitePointForGreenChannel = _whitePointGreen;
                    page.UserWhitePointForBlueChannel = _whitePointBlue;
                }
                page.InterpolationMethod = bayerGridInterpolation;
                page.WhiteBalanceMethod = whiteBalance;

                EventHandler<ProgressEventArgs> progress = new EventHandler<ProgressEventArgs>(UpdateProgress);
                _originalImage.SetImage(_rawFile.Page.GetImage(progress));
            }
        }

        #endregion


        #region View Rotation

        /// <summary>
        /// Rotates images in image viewer and thumbnail viewer by 90 degrees clockwise.
        /// </summary>
        private void RotateViewClockwise()
        {
            if (imageViewer1.ImageRotationAngle != 270)
            {
                imageViewer1.ImageRotationAngle += 90;
                thumbnailViewer1.ImageRotationAngle += 90;
            }
            else
            {
                imageViewer1.ImageRotationAngle = 0;
                thumbnailViewer1.ImageRotationAngle = 0;
            }
        }

        /// <summary>
        /// Rotates images in image viewer and thumbnail viewer by 90 degrees counterclockwise.
        /// </summary>
        private void RotateViewCounterClockwise()
        {
            if (imageViewer1.ImageRotationAngle != 0)
            {
                imageViewer1.ImageRotationAngle -= 90;
                thumbnailViewer1.ImageRotationAngle -= 90;
            }
            else
            {
                imageViewer1.ImageRotationAngle = 270;
                thumbnailViewer1.ImageRotationAngle = 270;
            }
        }

        #endregion


        /// <summary>
        /// Opens a RAW file and loads thumbnail, preview image, RAW preview image and original image.
        /// </summary>
        /// <param name="filename">File to open.</param>
        private void OpenRawFile(string filename)
        {
            // close the previously opened RAW file
            CloseRawFile();

            IsRawFileOpening = true;

            EventHandler<ProgressEventArgs> progress = new EventHandler<ProgressEventArgs>(UpdateProgress);

            this.Text = string.Format("{0} - {1}", _title, filename);
            this.Cursor = Cursors.WaitCursor;

            try
            {
                _rawFile = new RawImageFile(filename, FileMode.Open, FileAccess.Read);

                RawImagePageBase rawImagePage = _rawFile.Page as RawImagePageBase;

                // get a thumbnail image
                VintasoftImage rawThumbnailImage = rawImagePage.GetThumbnailImage(progress);
                if (rawThumbnailImage != null)
                {
                    rawThumbnailImage.Thumbnail.ToolTip = "Thumbnail image";
                    thumbnailViewer1.Images.Add(rawThumbnailImage);
                    Application.DoEvents();
                }

                // get a preview image
                VintasoftImage previewImage = rawImagePage.GetPreviewImage(progress);
                if (previewImage != null)
                {
                    previewImage.Thumbnail.ToolTip = "Preview image";
                    thumbnailViewer1.Images.Add(previewImage);
                    Application.DoEvents();
                }

                // get a RAW preview image if available
                Cr2Page cr2Page = rawImagePage as Cr2Page;
                if (cr2Page != null)
                {
                    VintasoftImage rawPreviewImage = cr2Page.GetRawPreviewImage(progress);
                    if (rawPreviewImage != null)
                    {
                        rawPreviewImage.Thumbnail.ToolTip = "RAW preview image";
                        thumbnailViewer1.Images.Add(rawPreviewImage);
                        Application.DoEvents();
                    }
                }

                adaptiveInterpolationHomogeneityDirectedToolStripMenuItem.Enabled = rawImagePage.ColorSpace == RawColorSpaceType.RGB;

                if (rawImagePage.ColorSpace == RawColorSpaceType.CMYK &&
                   (BayerGridInterpolationMethod)_interpolationMenuItem.Tag == BayerGridInterpolationMethod.Ahd)
                {
                    _interpolationMenuItem.Checked = false;
                    _interpolationMenuItem = bilinearInterpolationToolStripMenuItem;
                    _interpolationMenuItem.Checked = true;
                }

                // get a source image
                rawImagePage.InterpolationMethod = (BayerGridInterpolationMethod)_interpolationMenuItem.Tag;
                rawImagePage.WhiteBalanceMethod = (WhiteBalanceMethod)_whiteBalanceMenuItem.Tag;
                _originalImage = rawImagePage.GetImage(progress);
                if (_originalImage != null)
                {
                    _originalImage.Thumbnail.ToolTip = "RAW image";
                    thumbnailViewer1.Images.Add(_originalImage);
                }
            }
            catch (Exception ex)
            {
                this.Text = _title;
                thumbnailViewer1.Images.Clear();
                DemosTools.ShowErrorMessage(ex);
            }
            finally
            {
                IsRawFileOpening = false;
                this.Cursor = Cursors.Default;
                UpdateUI();
            }
        }

        /// <summary>
        /// Closes the RAW file.
        /// </summary>
        private void CloseRawFile()
        {
            if (_rawFile != null)
            {
                _rawFile.Dispose();
                _rawFile = null;
            }

            if (thumbnailViewer1.Images.Count > 0)
            {
                thumbnailViewer1.Images.Clear();
            }

            this.Text = _title;

            imageInfoToolStripStatusLabel.Text = "";
            UpdateUI();
        }

        /// <summary>
        /// Handler of the image loading progress event.
        /// </summary>
        private void UpdateProgress(object sender, ProgressEventArgs e)
        {
            progressBarLoadingRawFile.Visible = e.Progress != 100;
            progressBarLoadingRawFile.Value = e.Progress;
        }

        #endregion

        #endregion

    }
}
