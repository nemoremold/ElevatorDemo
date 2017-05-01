using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Eliminator
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    enum Direction
    {
        UP,
        DOWN,
        NONE
    }

    class FloorController
    {
        private bool _upButton;
        private bool _downButton;

        public FloorController()
        {
            _upButton = false;
            _downButton = false;
        }

        public void upButtonPressed()
        {
            _upButton = true;
        }

        public void downButtonPressed()
        {
            _downButton = true;
        }

        public void upButtonReleased()
        {
            _upButton = false;
        }

        public void downButtonReleased()
        {
            _downButton = false;
        }

        public bool getUpButtonStatus()
        {
            return _upButton;
        }

        public bool getDownButtonStatus()
        {
            return _downButton;
        }
    }

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
            _floor = 1;
            _floorCount = 20;
            
            _gateControllingPanel = false;
            _alertControllingButton = false;
            _floorControllingPanel = new bool[_floorCount];
            _floorControllerPanel = new FloorController[_floorCount];
            for (int i = 0; i < _floorCount; ++i)
            {
                _floorControllingPanel[i] = false;
                _floorControllerPanel[i].upButtonReleased();
                _floorControllerPanel[i].downButtonReleased();
            }
        }

        public void floorControllingButtonPressed(int index)
        {
            if(index < _floorCount)
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
            if(nextTaskDownwardExists() || nextTaskUpwardExists())
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
            if(_floor > 0)
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
            if(_floor < 0 || _floor >= _floorCount)
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
            for(int i = _floor + 1; i < _floorCount; ++i)
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
            if(_direction == Direction.UP)
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
            else if(_direction == Direction.DOWN)
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
    }

    class ElevatorController
    {
        private Elevator[] _elevators;
        private int _elevatorCount;

        public ElevatorController()
        {
            _elevatorCount = 5;
            _elevators = new Elevator[5];
        }

        public void runElevator()
        {
            for(int i = 0; i < _elevatorCount; ++i)
            {
                if (!_elevators[i].getRunningStatus())
                {
                    _elevators[i].startRunning();
                    Thread thread = new Thread(new ParameterizedThreadStart(run));
                    thread.IsBackground = true;
                    thread.Start(i);
                    break;
                }
            }
        }

        public void run(object param)
        {
            int index = (int)param;

            do
            {
                for (_elevators[index].openDoor(); _elevators[index].getDoorStatus(); _elevators[index].openDoor())
                {
                    Thread.Sleep(3000);
                    _elevators[index].closeDoor();
                }

                Direction task = Direction.NONE;
                task = acquireTask(index);

                if (task == Direction.UP)
                {
                    _elevators[index].moveUp();
                    Thread.Sleep(1000);
                }
                else if (task == Direction.DOWN)
                {
                    _elevators[index].moveDown();
                    Thread.Sleep(1000);
                }
                else if (task == Direction.NONE)
                {
                    _elevators[index].checkFloor();
                }
                else
                {
                    Exception excep = new Exception("Invalid value of task.");
                    throw excep;
                }
            } while (!_elevators[index].isArrived());
            _elevators[index].stop();
        }

        public Direction acquireTask(int index)
        {
            if(_elevators[index].getDirection() == Direction.UP)
            {
                if (_elevators[index].nextTaskUpwardExists())
                {
                    return Direction.UP;
                }
                else if (_elevators[index].nextTaskDownwardExists())
                {
                    return Direction.DOWN;
                }
            }
            else if(_elevators[index].getDirection() == Direction.DOWN)
            {
                if (_elevators[index].nextTaskDownwardExists())
                {
                    return Direction.DOWN;
                }
                else if (_elevators[index].nextTaskUpwardExists())
                {
                    return Direction.UP;
                }
            }
            else if(_elevators[index].getDirection() == Direction.NONE)
            {
                return Direction.NONE;
            }
            else
            {
                Exception excep = new Exception("Invalid status of elevator.");
                throw excep;
            }
            return Direction.NONE;
        }

        public void interiorRequestFloorControlling(int elevatorIndex, int floor)
        {
            if(elevatorIndex < _elevatorCount)
            {
                _elevators[elevatorIndex].floorControllingButtonPressed(floor);
            }
            else
            {
                Exception excep = new Exception("Invalid value of elevator's index.");
                throw excep;
            }

            runElevator();
        }

        public void interiorRequestGateControlling(int elevatorIndex, bool check)
        {
            if (elevatorIndex < _elevatorCount)
            {
                if (check)
                {
                    _elevators[elevatorIndex].openGateButtonPressed();
                }
                else
                {
                    _elevators[elevatorIndex].closeGateButtonPressed();
                }
            }
            else
            {
                Exception excep = new Exception("Invalid value of elevator's index.");
                throw excep;
            }
        }

        public void interiorRequestAlerted(int elevatorIndex)
        {
            if (elevatorIndex < _elevatorCount)
            {
                _elevators[elevatorIndex].alertButtonPressed();
            }
            else
            {
                Exception excep = new Exception("Invalid value of elevator's index.");
                throw excep;
            }
        }

        public void interiorRequestAlertCanceled(int elevatorIndex)
        {
            if (elevatorIndex < _elevatorCount)
            {
                _elevators[elevatorIndex].alertButtonReleased();
            }
            else
            {
                Exception excep = new Exception("Invalid value of elevator's index.");
                throw excep;
            }
        }

        public void exteriorRequest(int floor, Direction direction)
        {
            for (int i = 0; i < _elevatorCount; ++i)
            {
                if(direction == Direction.UP)
                {
                    _elevators[i].floorControllerUpButtonPressed(floor);
                }
                else if(direction == Direction.DOWN)
                {
                    _elevators[i].floorControllerDownButtonPressed(floor);
                }
                else
                {
                    Exception excep = new Exception("Invalid value of direction.");
                    throw excep;
                }
            }

            runElevator();
        }
        
        
    }
}
