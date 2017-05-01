using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Eliminator
{
    class Elevator
    {
        private Direction _direction;
        private bool _isGateOpen;
        private bool _isRunning;
        private int _floor;
        private int _floorCount;

        private bool[] _floorControllingPanel;
        private bool _gateControllingPanel;
        private bool _alertControllingButton;
        private FloorController[] _floorControllerPanel;

        public Elevator()
        {
            _direction = Direction.UP;
            _isGateOpen = false;
            _isRunning = false;
            _floor = 0;
            _floorCount = 20;

            _gateControllingPanel = false;
            _alertControllingButton = false;
            _floorControllingPanel = new bool[_floorCount];
            _floorControllerPanel = new FloorController[_floorCount];
            for (int i = 0; i < _floorCount; ++i)
            {
                _floorControllingPanel[i] = false;
                _floorControllerPanel[i] = new FloorController();
            }
        }

        public void floorControllingButtonPressed(int index)
        {
            if (index < _floorCount)
            {
                _floorControllingPanel[index] = true;
            }
            else
            {
                Exception excep = new Exception("Invalid value of floor index.");
                throw excep;
            }
        }

        public void floorControllerUpButtonPressed(int index)
        {
            if (index < _floorCount)
            {
                _floorControllerPanel[index].upButtonPressed();
            }
            else
            {
                Exception excep = new Exception("Invalid value of floor index.");
                throw excep;
            }
        }

        public void floorControllerDownButtonPressed(int index)
        {
            if (index < _floorCount)
            {
                _floorControllerPanel[index].downButtonPressed();
            }
            else
            {
                Exception excep = new Exception("Invalid value of floor index.");
                throw excep;
            }
        }

        public void openGateButtonPressed()
        {
            _gateControllingPanel = true;
        }

        public void closeGateButtonPressed()
        {
            _gateControllingPanel = false;
        }

        public void alertButtonPressed()
        {
            _alertControllingButton = true;
        }

        public void floorControllingButtonReleased(int index)
        {
            if (index < _floorCount)
            {
                _floorControllingPanel[index] = false;
            }
            else
            {
                Exception excep = new Exception("Invalid value of floor index.");
                throw excep;
            }
        }

        public void floorControllerUpButtonReleased(int index)
        {
            if (index < _floorCount)
            {
                _floorControllerPanel[index].upButtonReleased();
            }
            else
            {
                Exception excep = new Exception("Invalid value of floor index.");
                throw excep;
            }
        }

        public void floorControllerDownButtonReleased(int index)
        {
            if (index < _floorCount)
            {
                _floorControllerPanel[index].downButtonReleased();
            }
            else
            {
                Exception excep = new Exception("Invalid value of floor index.");
                throw excep;
            }
        }

        public void alertButtonReleased()
        {
            _alertControllingButton = false;
        }

        public bool getRunningStatus()
        {
            return _isRunning;
        }

        public void startRunning()
        {
            _isRunning = true;
        }

        public void stop()
        {
            _isRunning = false;
        }

        public bool isArrived()
        {
            if (nextTaskDownwardExists() || nextTaskUpwardExists())
            {
                return false;
            }
            return true;
        }

        public void moveUp()
        {
            if (_floor < _floorCount - 1)
            {
                ++_floor;
            }
            else
            {
                Exception excep = new Exception("Invalid operation of floor shifting.");
                throw excep;
            }
        }

        public void moveDown()
        {
            if (_floor > 0)
            {
                --_floor;
            }
            else
            {
                Exception excep = new Exception("Invalid operation of floor shifting.");
                throw excep;
            }
        }

        public void checkFloor()
        {
            if (_floor < 0 || _floor >= _floorCount)
            {
                Exception excep = new Exception("Invalid value of floor.");
                throw excep;
            }
        }

        public Direction getDirection()
        {
            return _direction;
        }

        public bool nextTaskUpwardExists()
        {
            for (int i = _floor + 1; i < _floorCount; ++i)
            {
                if (_floorControllingPanel[i] || _floorControllerPanel[i].getUpButtonStatus())
                {
                    return true;
                }
            }
            return false;
        }

        public bool nextTaskDownwardExists()
        {
            for (int i = _floor - 1; i >= 0; --i)
            {
                if (_floorControllingPanel[i] || _floorControllerPanel[i].getDownButtonStatus())
                {
                    return true;
                }
            }
            return false;
        }

        public bool getDoorStatus()
        {
            return _isGateOpen;
        }

        public void closeDoor()
        {
            _isGateOpen = false;
        }

        public void openDoor()
        {
            if (_direction == Direction.UP)
            {
                _isGateOpen = true;
                if (_floorControllingPanel[_floor] || _floorControllerPanel[_floor].getUpButtonStatus())
                {
                    _floorControllingPanel[_floor] = false;
                    _floorControllerPanel[_floor].upButtonReleased();
                }
                else if (!nextTaskUpwardExists() || _floorControllerPanel[_floor].getDownButtonStatus())
                {
                    _direction = Direction.DOWN;
                    _floorControllerPanel[_floor].downButtonReleased();
                }
            }
            else if (_direction == Direction.DOWN)
            {
                _isGateOpen = true;
                if (_floorControllingPanel[_floor] || _floorControllerPanel[_floor].getDownButtonStatus())
                {
                    _floorControllingPanel[_floor] = false;
                    _floorControllerPanel[_floor].downButtonReleased();
                }
                else if (!nextTaskDownwardExists() || _floorControllerPanel[_floor].getUpButtonStatus())
                {
                    _direction = Direction.UP;
                    _floorControllerPanel[_floor].upButtonReleased();
                }
            }
            else
            {
                Exception excep = new Exception("Invalid elevator status.");
                throw excep;
            }
        }

        public int getFloor()
        {
            return _floor;
        }

        public bool getUpButtonStatusAtFloor(int index)
        {
            return _floorControllerPanel[index].getUpButtonStatus();
        }

        public bool getDownButtonStatusAtFloor(int index)
        {
            return _floorControllerPanel[index].getDownButtonStatus();
        }

        public bool getFloorControllingButtonStatus(int floor)
        {
            return _floorControllingPanel[floor];
        }
    }
}
