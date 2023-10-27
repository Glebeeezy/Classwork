namespace Classwork12
{
    public sealed class Boeing747 : IPlane
    {
        private int _altitude = 0; // in meters

        private int _speed = 0; // in km per hour

        private int _climbRate = 0; // in meters per second

        private bool _hasTookOff = false;

        private int _accelerationSpeed = 0; // in km per hour
        public void Accelerate(int toSpeed)
        {
            if (!_hasTookOff)
            {
                _accelerationSpeed = 40; // km\sec
                Console.WriteLine($"Набор скорости в км/сек {_accelerationSpeed}");
                while (_speed < toSpeed)
                {
                    _speed += _accelerationSpeed;
                }
            }
            else if(_hasTookOff)
            {
                _accelerationSpeed = 80; // km\sec
                Console.WriteLine($"Набор скорости в км/сек {_accelerationSpeed}");
                while (_speed < toSpeed)
                {
                    _speed += _accelerationSpeed;
                }
            }
            Console.WriteLine($"Самолёт набрал скорость {_speed} километров в час");
        }
        public void ClimbTo(int altitude) // altitude in meters
        {
            if (_hasTookOff)
            {
                _climbRate = _speed / 10;
                Console.WriteLine($"Климб {_climbRate} м/сек");
                while (_altitude < altitude)
                {
                    _altitude  += _climbRate;

                }
                Console.WriteLine($"Самолёт набрал нужную высоту- {altitude} метров");
            }
            else
            {
                throw new Exception("PlaneHasntTookOffExeption");
            }
        }

        public void TakeOff()
        {
            if (_speed >= 350)
            {
                _hasTookOff = true;
                Console.WriteLine("Самолёт взлетел");
            }
            else
            {
                throw new Exception("LowSpeedExeption");
            }
        }
    }
}
