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
            for (int i = 0; i < _floorCount; ++i)
            {
                _floorControllingPanel[i] = false;
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
            _isGateOpen = true;
        }

        public int getFloor()
        {
            return _floor;
        }

        public bool getFloorControllingButtonStatus(int floor)
        {
            return _floorControllingPanel[floor];
        }

        public void setFloorControllingButtonStatus(int floor, bool status)
        {
            if(floor < _floorCount)
            {
                _floorControllingPanel[floor] = status;
            }
            else
            {
                Exception excep = new Exception("Invalid value of floor.");
                throw excep;
            }
        }

        public int getFloorCount()
        {
            return _floorCount;
        }

        public void setDirection(Direction dir)
        {
            _direction = dir;
        }
    }
}
