using System;
using System.Windows.Forms;
using TestProject_PowerSupply;

namespace PowerSupplyControl
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            busAddress = "GPIB0::5::INSTR";  // FUTURE: Add value to config file
            powerSupply = new PowerSupply();
        }

        #region Power Supply 1
        private void buttonInitialize1_Click(object sender, EventArgs e)
        {
            powerSupply.Initialize(busAddress, 1);
            nudVoltage1.Enabled = true;
            cbOutputState1.Enabled = true;
            buttonInitialize1.Enabled = false;
        }

        private void buttonReset1_Click(object sender, EventArgs e)
        {
            if (powerSupply != null)
            {
                powerSupply.Reset(1);
                cbOutputState1.Checked = false;
                nudVoltage1.Value = 0;
            }
        }

        private void cbOutputState1_CheckedChanged(object sender, EventArgs e)
        {
            if (powerSupply != null)
            {
                powerSupply.OutputState1 = cbOutputState1.Checked ? SwitchState.On : SwitchState.Off;
            }
            timerCurrentMeasurement.Enabled = cbOutputState1.Checked || cbOutputState2.Checked;
        }

        private void nudVoltage1_ValueChanged(object sender, EventArgs e)
        {
            if (powerSupply != null)
            {
                powerSupply.OutputVoltage1 = (double)nudVoltage1.Value;
            }
        }
        #endregion

        #region Power Supply 2
        private void buttonInitialize2_Click(object sender, EventArgs e)
        {
            powerSupply.Initialize(busAddress, 2);
            nudVoltage2.Enabled = true;
            cbOutputState2.Enabled = true;
            buttonInitialize2.Enabled = false;
        }

        private void buttonReset2_Click(object sender, EventArgs e)
        {
            if (powerSupply != null)
            {
                powerSupply.Reset(2);
                cbOutputState2.Checked = false;
                nudVoltage2.Value = 0;
            }
        }

        private void cbOutputState2_CheckedChanged(object sender, EventArgs e)
        {
            if (powerSupply != null)
            {
                powerSupply.OutputState2 = cbOutputState2.Checked ? SwitchState.On : SwitchState.Off;
            }
            timerCurrentMeasurement.Enabled = cbOutputState1.Checked || cbOutputState2.Checked;
        }

        private void nudVoltage2_ValueChanged(object sender, EventArgs e)
        {
            if (powerSupply != null)
            {
                powerSupply.OutputVoltage2 = (double)nudVoltage2.Value;
            }
        }
        #endregion

        private void timerCurrentMeasurement_Tick(object sender, EventArgs e)
        {
            if (powerSupply != null)
            {
                powerSupply.MeasureCurrent();
                tbMeasuredCurrent1.Text = string.Format("{0:N3}", powerSupply.current1);
                tbMeasuredCurrent2.Text = string.Format("{0:N3}", powerSupply.current2);
            }           
        }

        // TODO: Change to use the new class
        private PowerSupply powerSupply;

        private string busAddress;
    }
}
