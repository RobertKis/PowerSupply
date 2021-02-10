namespace TestProject_PowerSupply
{
    public enum SwitchState
    {
        Undefined = -1,
        Off = 0,
        On = 1,
        HighImpediance = 2
    }

    interface IPowerSupply
    {
        void Initialize(string busAddress, int powerSuppyId);
        void Reset(int powerSuppyId);
        SwitchState OutputState1 { get; set; }
        SwitchState OutputState2 { get; set; }
        double OutputVoltage1 { get; set; }
        double OutputVoltage2 { get; set; }
        void MeasureCurrent();
    }
}
