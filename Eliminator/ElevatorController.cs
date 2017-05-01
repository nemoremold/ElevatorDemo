using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Eliminator
{
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
            for (int i = 0; i < _elevatorCount; ++i)
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
            if (_elevators[index].getDirection() == Direction.UP)
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
            else if (_elevators[index].getDirection() == Direction.DOWN)
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
            else if (_elevators[index].getDirection() == Direction.NONE)
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
            if (elevatorIndex < _elevatorCount)
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
                if (direction == Direction.UP)
                {
                    _elevators[i].floorControllerUpButtonPressed(floor);
                }
                else if (direction == Direction.DOWN)
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
