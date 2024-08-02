namespace RawImageViewerDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Vintasoft.Imaging.Utils.WinFormsSystemClipboard winFormsSystemClipboard1 = new Vintasoft.Imaging.Utils.WinFormsSystemClipboard();
            Vintasoft.Imaging.Codecs.Decoders.RenderingSettings renderingSettings1 = new Vintasoft.Imaging.Codecs.Decoders.RenderingSettings();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance1 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance2 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance3 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance4 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailAppearance thumbnailAppearance5 = new Vintasoft.Imaging.UI.ThumbnailAppearance();
            Vintasoft.Imaging.UI.ThumbnailCaption thumbnailCaption1 = new Vintasoft.Imaging.UI.ThumbnailCaption();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thumbnailViewerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.imageScaleModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToHeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelToPixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.scale25ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale400ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.counterclockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageViewerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpolationModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneInterpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilinearInterpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variableInterpolationNumberGradientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaptiveInterpolationHomogeneityDirectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneWhiteBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoWhiteBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraWhiteBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userWhiteBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.imageInfoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarLoadingRawFile = new System.Windows.Forms.ToolStripProgressBar();
            this.imageViewer1 = new Vintasoft.Imaging.UI.ImageViewer();
            this.thumbnailViewer1 = new Vintasoft.Imaging.UI.ThumbnailViewer();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.imagePrintDocument1 = new Vintasoft.Imaging.Print.ImagePrintDocument();
            this.printImageDialog = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageViewerToolstrip1 = new DemosCommonCode.Imaging.ImageViewerToolStrip();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.pageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(855, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator1,
            this.pageSettingsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // pageSettingsToolStripMenuItem
            // 
            this.pageSettingsToolStripMenuItem.Name = "pageSettingsToolStripMenuItem";
            this.pageSettingsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pageSettingsToolStripMenuItem.Text = "Page Settings...";
            this.pageSettingsToolStripMenuItem.Click += new System.EventHandler(this.pageSettingsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.printToolStripMenuItem.Text = "Print...";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thumbnailViewerSettingsToolStripMenuItem,
            this.toolStripSeparator3,
            this.imageScaleModeToolStripMenuItem,
            this.rotateViewToolStripMenuItem,
            this.imageViewerSettingsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // thumbnailViewerSettingsToolStripMenuItem
            // 
            this.thumbnailViewerSettingsToolStripMenuItem.Name = "thumbnailViewerSettingsToolStripMenuItem";
            this.thumbnailViewerSettingsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.thumbnailViewerSettingsToolStripMenuItem.Text = "Thumbnail Viewer Settings...";
            this.thumbnailViewerSettingsToolStripMenuItem.Click += new System.EventHandler(this.thumbnailViewerSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(220, 6);
            // 
            // imageScaleModeToolStripMenuItem
            // 
            this.imageScaleModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalImageToolStripMenuItem,
            this.bestFitToolStripMenuItem,
            this.fitToWidthToolStripMenuItem,
            this.fitToHeightToolStripMenuItem,
            this.scaleToolStripMenuItem,
            this.pixelToPixelToolStripMenuItem,
            this.toolStripSeparator4,
            this.scale25ToolStripMenuItem,
            this.scale50ToolStripMenuItem,
            this.scale100ToolStripMenuItem,
            this.scale200ToolStripMenuItem,
            this.scale400ToolStripMenuItem});
            this.imageScaleModeToolStripMenuItem.Name = "imageScaleModeToolStripMenuItem";
            this.imageScaleModeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.imageScaleModeToolStripMenuItem.Text = "Image Scale Mode";
            // 
            // normalImageToolStripMenuItem
            // 
            this.normalImageToolStripMenuItem.Name = "normalImageToolStripMenuItem";
            this.normalImageToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.normalImageToolStripMenuItem.Text = "Normal";
            this.normalImageToolStripMenuItem.Click += new System.EventHandler(this.ImageScale_Click);
            // 
            // bestFitToolStripMenuItem
            // 
            this.bestFitToolStripMenuItem.Name = "bestFitToolStripMenuItem";
            this.bestFitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.bestFitToolStripMenuItem.Text = "Best fit";
            this.bestFitToolStripMenuItem.Click += new System.EventHandler(this.ImageScale_Click);
            // 
            // fitToWidthToolStripMenuItem
            // 
            this.fitToWidthToolStripMenuItem.Name = "fitToWidthToolStripMenuItem";
            this.fitToWidthToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fitToWidthToolStripMenuItem.Text = "Fit to width";
            this.fitToWidthToolStripMenuItem.Click += new System.EventHandler(this.ImageScale_Click);
            // 
            // fitToHeightToolStripMenuItem
            // 
            this.fitToHeightToolStripMenuItem.Name = "fitToHeightToolStripMenuItem";
            this.fitToHeightToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fitToHeightToolStripMenuItem.Text = "Fit to height";
            this.fitToHeightToolStripMenuItem.Click += new System.EventHandler(this.ImageScale_Click);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scaleToolStripMenuItem.Text = "Scale";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.ImageScale_Click);
            // 
            // pixelToPixelToolStripMenuItem
            // 
            this.pixelToPixelToolStripMenuItem.Name = "pixelToPixelToolStripMenuItem";
            this.pixelToPixelToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pixelToPixelToolStripMenuItem.Text = "Pixel to pixel";
            this.pixelToPixelToolStripMenuItem.Click += new System.EventHandler(this.ImageScale_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(138, 6);
            // 
            // scale25ToolStripMenuItem
            // 
            this.scale25ToolStripMenuItem.Name = "scale25ToolStripMenuItem";
            this.scale25ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scale25ToolStripMenuItem.Text = "25%";
            this.scale25ToolStripMenuItem.Click += new System.EventHandler(this.ImageScale_Click);
            // 
            // scale50ToolStripMenuItem
            // 
            this.scale50ToolStripMenuItem.Name = "scale50ToolStripMenuItem";
            this.scale50ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scale50ToolStripMenuItem.Text = "50%";
            this.scale50ToolStripMenuItem.Click += new System.EventHandler(this.ImageScale_Click);
            // 
            // scale100ToolStripMenuItem
            // 
            this.scale100ToolStripMenuItem.Name = "scale100ToolStripMenuItem";
            this.scale100ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scale100ToolStripMenuItem.Text = "100%";
            this.scale100ToolStripMenuItem.Click += new System.EventHandler(this.ImageScale_Click);
            // 
            // scale200ToolStripMenuItem
            // 
            this.scale200ToolStripMenuItem.Name = "scale200ToolStripMenuItem";
            this.scale200ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scale200ToolStripMenuItem.Text = "200%";
            this.scale200ToolStripMenuItem.Click += new System.EventHandler(this.ImageScale_Click);
            // 
            // scale400ToolStripMenuItem
            // 
            this.scale400ToolStripMenuItem.Name = "scale400ToolStripMenuItem";
            this.scale400ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.scale400ToolStripMenuItem.Text = "400%";
            this.scale400ToolStripMenuItem.Click += new System.EventHandler(this.ImageScale_Click);
            // 
            // rotateViewToolStripMenuItem
            // 
            this.rotateViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateClockwiseToolStripMenuItem,
            this.counterclockwiseToolStripMenuItem});
            this.rotateViewToolStripMenuItem.Name = "rotateViewToolStripMenuItem";
            this.rotateViewToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.rotateViewToolStripMenuItem.Text = "Rotate View";
            // 
            // rotateClockwiseToolStripMenuItem
            // 
            this.rotateClockwiseToolStripMenuItem.Name = "rotateClockwiseToolStripMenuItem";
            this.rotateClockwiseToolStripMenuItem.ShortcutKeyDisplayString = "Shift+Ctrl+Plus";
            this.rotateClockwiseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Oemplus)));
            this.rotateClockwiseToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.rotateClockwiseToolStripMenuItem.Text = "Clockwise";
            this.rotateClockwiseToolStripMenuItem.Click += new System.EventHandler(this.rotateClockwiseToolStripMenuItem_Click);
            // 
            // counterclockwiseToolStripMenuItem
            // 
            this.counterclockwiseToolStripMenuItem.Name = "counterclockwiseToolStripMenuItem";
            this.counterclockwiseToolStripMenuItem.ShortcutKeyDisplayString = "Shift+Ctrl+Minus";
            this.counterclockwiseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.OemMinus)));
            this.counterclockwiseToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.counterclockwiseToolStripMenuItem.Text = "Counterclockwise";
            this.counterclockwiseToolStripMenuItem.Click += new System.EventHandler(this.counterclockwiseToolStripMenuItem_Click);
            // 
            // imageViewerSettingsToolStripMenuItem
            // 
            this.imageViewerSettingsToolStripMenuItem.Name = "imageViewerSettingsToolStripMenuItem";
            this.imageViewerSettingsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.imageViewerSettingsToolStripMenuItem.Text = "Image Viewer Settings...";
            this.imageViewerSettingsToolStripMenuItem.Click += new System.EventHandler(this.imageViewerSettingsToolStripMenuItem_Click);
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageMetadataToolStripMenuItem,
            this.interpolationModeToolStripMenuItem,
            this.whiteBalanceToolStripMenuItem});
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pageToolStripMenuItem.Text = "Page";
            // 
            // pageMetadataToolStripMenuItem
            // 
            this.pageMetadataToolStripMenuItem.Name = "pageMetadataToolStripMenuItem";
            this.pageMetadataToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.pageMetadataToolStripMenuItem.Text = "Page Metadata...";
            this.pageMetadataToolStripMenuItem.Click += new System.EventHandler(this.pageMetadataToolStripMenuItem_Click);
            // 
            // interpolationModeToolStripMenuItem
            // 
            this.interpolationModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneInterpolationToolStripMenuItem,
            this.bilinearInterpolationToolStripMenuItem,
            this.variableInterpolationNumberGradientsToolStripMenuItem,
            this.adaptiveInterpolationHomogeneityDirectedToolStripMenuItem});
            this.interpolationModeToolStripMenuItem.Name = "interpolationModeToolStripMenuItem";
            this.interpolationModeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.interpolationModeToolStripMenuItem.Text = "Interpolation mode";
            // 
            // noneInterpolationToolStripMenuItem
            // 
            this.noneInterpolationToolStripMenuItem.Name = "noneInterpolationToolStripMenuItem";
            this.noneInterpolationToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.noneInterpolationToolStripMenuItem.Text = "None";
            this.noneInterpolationToolStripMenuItem.Click += new System.EventHandler(this.interpolationModeToolStripMenuItem_Click);
            // 
            // bilinearInterpolationToolStripMenuItem
            // 
            this.bilinearInterpolationToolStripMenuItem.Checked = true;
            this.bilinearInterpolationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bilinearInterpolationToolStripMenuItem.Name = "bilinearInterpolationToolStripMenuItem";
            this.bilinearInterpolationToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.bilinearInterpolationToolStripMenuItem.Text = "Bilinear";
            this.bilinearInterpolationToolStripMenuItem.Click += new System.EventHandler(this.interpolationModeToolStripMenuItem_Click);
            // 
            // variableInterpolationNumberGradientsToolStripMenuItem
            // 
            this.variableInterpolationNumberGradientsToolStripMenuItem.Name = "variableInterpolationNumberGradientsToolStripMenuItem";
            this.variableInterpolationNumberGradientsToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.variableInterpolationNumberGradientsToolStripMenuItem.Text = "Variable number gradients";
            this.variableInterpolationNumberGradientsToolStripMenuItem.Click += new System.EventHandler(this.interpolationModeToolStripMenuItem_Click);
            // 
            // adaptiveInterpolationHomogeneityDirectedToolStripMenuItem
            // 
            this.adaptiveInterpolationHomogeneityDirectedToolStripMenuItem.Name = "adaptiveInterpolationHomogeneityDirectedToolStripMenuItem";
            this.adaptiveInterpolationHomogeneityDirectedToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.adaptiveInterpolationHomogeneityDirectedToolStripMenuItem.Text = "Adaptive homogeneity directed";
            this.adaptiveInterpolationHomogeneityDirectedToolStripMenuItem.Click += new System.EventHandler(this.interpolationModeToolStripMenuItem_Click);
            // 
            // whiteBalanceToolStripMenuItem
            // 
            this.whiteBalanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneWhiteBalanceToolStripMenuItem,
            this.autoWhiteBalanceToolStripMenuItem,
            this.cameraWhiteBalanceToolStripMenuItem,
            this.userWhiteBalanceToolStripMenuItem});
            this.whiteBalanceToolStripMenuItem.Name = "whiteBalanceToolStripMenuItem";
            this.whiteBalanceToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.whiteBalanceToolStripMenuItem.Text = "White balance";
            // 
            // noneWhiteBalanceToolStripMenuItem
            // 
            this.noneWhiteBalanceToolStripMenuItem.Name = "noneWhiteBalanceToolStripMenuItem";
            this.noneWhiteBalanceToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.noneWhiteBalanceToolStripMenuItem.Text = "None";
            this.noneWhiteBalanceToolStripMenuItem.Click += new System.EventHandler(this.whiteBalanceToolStripMenuItem_Click);
            // 
            // autoWhiteBalanceToolStripMenuItem
            // 
            this.autoWhiteBalanceToolStripMenuItem.Name = "autoWhiteBalanceToolStripMenuItem";
            this.autoWhiteBalanceToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.autoWhiteBalanceToolStripMenuItem.Text = "Auto";
            this.autoWhiteBalanceToolStripMenuItem.Click += new System.EventHandler(this.whiteBalanceToolStripMenuItem_Click);
            // 
            // cameraWhiteBalanceToolStripMenuItem
            // 
            this.cameraWhiteBalanceToolStripMenuItem.Name = "cameraWhiteBalanceToolStripMenuItem";
            this.cameraWhiteBalanceToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cameraWhiteBalanceToolStripMenuItem.Text = "Camera";
            this.cameraWhiteBalanceToolStripMenuItem.Click += new System.EventHandler(this.whiteBalanceToolStripMenuItem_Click);
            // 
            // userWhiteBalanceToolStripMenuItem
            // 
            this.userWhiteBalanceToolStripMenuItem.Name = "userWhiteBalanceToolStripMenuItem";
            this.userWhiteBalanceToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.userWhiteBalanceToolStripMenuItem.Text = "Specified";
            this.userWhiteBalanceToolStripMenuItem.Click += new System.EventHandler(this.whiteBalanceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageInfoToolStripStatusLabel,
            this.progressBarLoadingRawFile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(855, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // imageInfoToolStripStatusLabel
            // 
            this.imageInfoToolStripStatusLabel.Name = "imageInfoToolStripStatusLabel";
            this.imageInfoToolStripStatusLabel.Size = new System.Drawing.Size(840, 17);
            this.imageInfoToolStripStatusLabel.Spring = true;
            this.imageInfoToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBarLoadingRawFile
            // 
            this.progressBarLoadingRawFile.Name = "progressBarLoadingRawFile";
            this.progressBarLoadingRawFile.Size = new System.Drawing.Size(150, 16);
            this.progressBarLoadingRawFile.Visible = false;
            // 
            // imageViewer1
            // 
            this.imageViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer1.CenterImage = true;
            this.imageViewer1.Clipboard = winFormsSystemClipboard1;
            this.imageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer1.FastScrollingCursor = System.Windows.Forms.Cursors.SizeAll;
            this.imageViewer1.FastScrollingInterval = 10;
            this.imageViewer1.FastScrollingMinDistance = 5F;
            this.imageViewer1.FastScrollingMouseButton = System.Windows.Forms.MouseButtons.Middle;
            this.imageViewer1.FastScrollingScale = 0.5F;
            this.imageViewer1.FocusPointAnchor = Vintasoft.Imaging.AnchorType.None;
            this.imageViewer1.ImageRenderingSettings = renderingSettings1;
            this.imageViewer1.ImageRotationAngle = 0;
            this.imageViewer1.Location = new System.Drawing.Point(0, 0);
            this.imageViewer1.MasterViewer = this.thumbnailViewer1;
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.Size = new System.Drawing.Size(658, 513);
            this.imageViewer1.TabIndex = 5;
            this.imageViewer1.Text = "imageViewer1";
            this.imageViewer1.ImageLoadingProgress += new System.EventHandler<Vintasoft.Imaging.ProgressEventArgs>(this.UpdateProgress);
            this.imageViewer1.ZoomChanged += new System.EventHandler<Vintasoft.Imaging.UI.ZoomChangedEventArgs>(this.imageViewer1_ZoomChanged);
            this.imageViewer1.FocusedIndexChanged += new System.EventHandler<Vintasoft.Imaging.UI.FocusedIndexChangedEventArgs>(this.imageViewer1_FocusedIndexChanged);
            // 
            // thumbnailViewer1
            // 
            this.thumbnailViewer1.AllowDrop = true;
            this.thumbnailViewer1.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.thumbnailViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumbnailViewer1.Clipboard = winFormsSystemClipboard1;
            this.thumbnailViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thumbnailViewer1.FastScrollingCursor = System.Windows.Forms.Cursors.SizeAll;
            this.thumbnailViewer1.FastScrollingInterval = 10;
            this.thumbnailViewer1.FastScrollingMinDistance = 5F;
            this.thumbnailViewer1.FastScrollingMouseButton = System.Windows.Forms.MouseButtons.Middle;
            this.thumbnailViewer1.FastScrollingScale = 0.5F;
            thumbnailAppearance1.BackColor = System.Drawing.Color.Transparent;
            thumbnailAppearance1.BorderColor = System.Drawing.Color.Gray;
            thumbnailAppearance1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            thumbnailAppearance1.BorderWidth = 1;
            this.thumbnailViewer1.FocusedThumbnailAppearance = thumbnailAppearance1;
            thumbnailAppearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            thumbnailAppearance2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            thumbnailAppearance2.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance2.BorderWidth = 2;
            this.thumbnailViewer1.HoveredThumbnailAppearance = thumbnailAppearance2;
            this.thumbnailViewer1.ImageRotationAngle = 0;
            this.thumbnailViewer1.Location = new System.Drawing.Point(0, 0);
            this.thumbnailViewer1.Name = "thumbnailViewer1";
            thumbnailAppearance3.BackColor = System.Drawing.Color.Black;
            thumbnailAppearance3.BorderColor = System.Drawing.Color.Black;
            thumbnailAppearance3.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance3.BorderWidth = 0;
            this.thumbnailViewer1.NotReadyThumbnailAppearance = thumbnailAppearance3;
            thumbnailAppearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(238)))), ((int)(((byte)(253)))));
            thumbnailAppearance4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(222)))), ((int)(((byte)(253)))));
            thumbnailAppearance4.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance4.BorderWidth = 1;
            this.thumbnailViewer1.SelectedThumbnailAppearance = thumbnailAppearance4;
            this.thumbnailViewer1.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.thumbnailViewer1.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.thumbnailViewer1.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.thumbnailViewer1.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.thumbnailViewer1.Size = new System.Drawing.Size(193, 513);
            this.thumbnailViewer1.TabIndex = 4;
            this.thumbnailViewer1.Text = "thumbnailViewer1";
            thumbnailAppearance5.BackColor = System.Drawing.Color.Transparent;
            thumbnailAppearance5.BorderColor = System.Drawing.Color.Transparent;
            thumbnailAppearance5.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            thumbnailAppearance5.BorderWidth = 1;
            this.thumbnailViewer1.ThumbnailAppearance = thumbnailAppearance5;
            thumbnailCaption1.Padding = new Vintasoft.Imaging.PaddingF(0F, 0F, 0F, 0F);
            thumbnailCaption1.TextColor = System.Drawing.Color.Black;
            this.thumbnailViewer1.ThumbnailCaption = thumbnailCaption1;
            this.thumbnailViewer1.ThumbnailControlPadding = new Vintasoft.Imaging.PaddingF(0F, 0F, 0F, 0F);
            this.thumbnailViewer1.ThumbnailImagePadding = new Vintasoft.Imaging.PaddingF(0F, 0F, 0F, 0F);
            this.thumbnailViewer1.ThumbnailMargin = new System.Windows.Forms.Padding(3);
            this.thumbnailViewer1.ThumbnailRenderingSettings = null;
            this.thumbnailViewer1.ThumbnailSize = new System.Drawing.Size(100, 100);
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.Filter = resources.GetString("openImageFileDialog.Filter");
            // 
            // imagePrintDocument1
            // 
            this.imagePrintDocument1.Center = false;
            this.imagePrintDocument1.DistanceBetweenImages = 0;
            this.imagePrintDocument1.PrintScaleMode = Vintasoft.Imaging.Print.PrintScaleMode.BestFit;
            // 
            // printImageDialog
            // 
            this.printImageDialog.AllowCurrentPage = true;
            this.printImageDialog.AllowSelection = true;
            this.printImageDialog.AllowSomePages = true;
            this.printImageDialog.Document = this.imagePrintDocument1;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.imagePrintDocument1;
            this.pageSetupDialog1.EnableMetric = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.thumbnailViewer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.imageViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(855, 513);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 6;
            // 
            // imageViewerToolstrip1
            // 
            this.imageViewerToolstrip1.AssociatedZoomTrackBar = null;
            this.imageViewerToolstrip1.CanSaveFile = false;
            this.imageViewerToolstrip1.CaptureFromCameraButtonEnabled = true;
            this.imageViewerToolstrip1.ImageViewer = this.imageViewer1;
            this.imageViewerToolstrip1.Location = new System.Drawing.Point(0, 24);
            this.imageViewerToolstrip1.Name = "imageViewerToolstrip1";
            this.imageViewerToolstrip1.PageCount = 0;
            this.imageViewerToolstrip1.PrintButtonEnabled = true;
            this.imageViewerToolstrip1.ScanButtonEnabled = true;
            this.imageViewerToolstrip1.Size = new System.Drawing.Size(855, 25);
            this.imageViewerToolstrip1.TabIndex = 3;
            this.imageViewerToolstrip1.Text = "imageViewerToolstrip1";
            this.imageViewerToolstrip1.UseImageViewerImages = true;
            this.imageViewerToolstrip1.OpenFile += new System.EventHandler(this.openToolStripMenuItem_Click);
            this.imageViewerToolstrip1.Print += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 584);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.imageViewerToolstrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAW Image Viewer Demo";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DemosCommonCode.Imaging.ImageViewerToolStrip imageViewerToolstrip1;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private Vintasoft.Imaging.UI.ThumbnailViewer thumbnailViewer1;
        private Vintasoft.Imaging.UI.ImageViewer imageViewer1;
        private System.Windows.Forms.ToolStripStatusLabel imageInfoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBarLoadingRawFile;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem thumbnailViewerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem imageScaleModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageViewerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageMetadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Vintasoft.Imaging.Print.ImagePrintDocument imagePrintDocument1;
        private System.Windows.Forms.PrintDialog printImageDialog;
        private System.Windows.Forms.ToolStripMenuItem pageSettingsToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripMenuItem normalImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestFitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitToWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitToHeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelToPixelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem scale25ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale400ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateClockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem counterclockwiseToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem interpolationModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneInterpolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilinearInterpolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variableInterpolationNumberGradientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaptiveInterpolationHomogeneityDirectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneWhiteBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoWhiteBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraWhiteBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userWhiteBalanceToolStripMenuItem;
    }
}