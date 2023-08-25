using System;
using System.Windows.Forms;

namespace RawImageViewerDemo
{
    /// <summary>
    /// A form that allows to specify white color balance.
    /// </summary>
    public partial class WhiteBalanceForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WhiteBalanceForm"/> class.
        /// </summary>
        private WhiteBalanceForm()
        {
            InitializeComponent();
        }

        #endregion



        #region Properties

        double _whiteBalanceRed;
        /// <summary>
        /// Gets or sets a value of red channel.
        /// </summary>
        public double WhiteBalanceRed
        {
            get
            {
                return _whiteBalanceRed;
            }
            set
            {
                redValueTrackBar.Value = (int)Math.Round(value * redValueTrackBar.Maximum);

                _whiteBalanceRed = value;
            }
        }

        double _whiteBalanceGreen;
        /// <summary>
        /// Gets or sets a value of green channel.
        /// </summary>
        public double WhiteBalanceGreen
        {
            get
            {
                return _whiteBalanceGreen;
            }
            set
            {
                greenValueTrackBar.Value = (int)Math.Round(value * greenValueTrackBar.Maximum);

                _whiteBalanceGreen = value;
            }
        }

        double _whiteBalanceBlue;
        /// <summary>
        /// Gets or sets a value of blue channel.
        /// </summary>
        public double WhiteBalanceBlue
        {
            get
            {
                return _whiteBalanceBlue;
            }
            set
            {
                blueValueTrackBar.Value = (int)Math.Round(value * blueValueTrackBar.Maximum);

                _whiteBalanceBlue = value;
            }
        }

        #endregion



        #region Methods

        #region PUBLIC

        /// <summary>
        /// Changes the channels values according to the specified track bars values.
        /// </summary>
        /// <param name="red">Red channel value.</param>
        /// <param name="green">Green channel value.</param>
        /// <param name="blue">Blue channel value.</param>
        /// <returns>A value indicating whether changes have been applied.</returns>
        public static bool GetValueChannels(ref double red, ref double green, ref double blue)
        {
            using (WhiteBalanceForm dlg = new WhiteBalanceForm())
            {
                dlg.WhiteBalanceRed = red;
                dlg.WhiteBalanceGreen = green;
                dlg.WhiteBalanceBlue = blue;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    red = dlg.WhiteBalanceRed;
                    green = dlg.WhiteBalanceGreen;
                    blue = dlg.WhiteBalanceBlue;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        #endregion


        #region PRIVATE

        #region UI

        /// <summary>
        /// Handles the Click event of OkButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            _whiteBalanceRed = GetValue(redValueTrackBar);
            _whiteBalanceGreen = GetValue(greenValueTrackBar);
            _whiteBalanceBlue = GetValue(blueValueTrackBar);

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the ValueChanged event of RedValueTrackBar object.
        /// </summary>
        private void redValueTrackBar_ValueChanged(object sender, EventArgs e)
        {
            redValueLabel.Text = GetValue(redValueTrackBar).ToString("0.00");
        }

        /// <summary>
        /// Handles the ValueChanged event of GreenValueTrackBar object.
        /// </summary>
        private void greenValueTrackBar_ValueChanged(object sender, EventArgs e)
        {
            greenValueLabel.Text = GetValue(greenValueTrackBar).ToString("0.00");
        }

        /// <summary>
        /// Handles the ValueChanged event of BlueValueTrackBar object.
        /// </summary>
        private void blueValueTrackBar_ValueChanged(object sender, EventArgs e)
        {
            blueValueLabel.Text = GetValue(blueValueTrackBar).ToString("0.00");
        }

        #endregion


        /// <summary>
        /// Returns the track bar value.
        /// </summary>
        /// <param name="trackBar">Specified track bar.</param>
        /// <returns>Track bar value.</returns>
        private double GetValue(TrackBar trackBar)
        {
            return (double)trackBar.Value / trackBar.Maximum;
        }

        #endregion

        #endregion

    }
}
