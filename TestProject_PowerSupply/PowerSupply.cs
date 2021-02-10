using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_PowerSupply
{
    public class PowerSupply : IPowerSupply
    {
        private string _busAddress;
        private const double powerConsumption1 = 5;
        private const double powerConsumption2 = 5;
        public SwitchState OutputState1 { get; set; }
        public SwitchState OutputState2 { get; set; }
        public double current1{ get; set; }
        public double current2 { get; set; }
        public double OutputVoltage1 { get;  set; }
        public double OutputVoltage2 { get;  set; }

        public void Initialize(string busAddress, int powerSuppyId)
        {
            _busAddress = busAddress;            
            Reset(powerSuppyId);
        }    

        public void Reset(int powerSuppyId)
        {
            if (powerSuppyId == 1)
            {
                OutputState1 = SwitchState.HighImpediance;
                OutputVoltage1 = 0.0;
            } else
            {
                OutputState2 = SwitchState.HighImpediance;
                OutputVoltage2 = 0.0;
            }
        }

        public void MeasureCurrent()
        {
            if (OutputState1 == SwitchState.On)
                current1 = OutputVoltage1 / powerConsumption1;
            else
                current1 = 0.0;

            if (OutputState2 == SwitchState.On)
                current2 = OutputVoltage2 / powerConsumption2;
            else
                current2 = 0.0;
        }
    }
}
