namespace TestProject_PowerSupply
{
    public class SinglePowerSupply
    {
        public SwitchState OutputState { get; set; }
        public double OutputVoltage { get; set; }

        public SinglePowerSupply()
        {
            OutputVoltage = 0.0;
            OutputState = SwitchState.Undefined;
            busAddress = null;
        }

        public void Initialize(string busAddress)
        {
            this.busAddress = busAddress;
            Reset();
        }

        public void Reset()
        {
            OutputState = SwitchState.HighImpediance;
            OutputVoltage = 0.0;
        }

        public double MeasureCurrent()
        {
            if (OutputState == SwitchState.On)
                return OutputVoltage / powerConsumption;
            else
                return 0.0;
        }

        private const double powerConsumption = 5;
        private string busAddress;
    }
}
