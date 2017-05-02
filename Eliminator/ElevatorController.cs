//
//  ElevatorController.cs
//  Eliminator
//
//  Created by Emoin Lam on 30/04/2017.
//  Copyright © 2017 Emoin Lam. All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Eliminator
{
    class ElevatorController
    {
        private Elevator[] _elevators;
        private int _elevatorCount;
        private FloorController[] _floorControllerPanel;

        public ElevatorController()
        {
            _elevatorCount = 5;
            _elevators = new Elevator[5];
            for(int i = 0; i < _elevatorCount; ++i)
            {
                _elevators[i] = new Elevator();
            }
            int _floorCount = _elevators[0].getFloorCount();
            _floorControllerPanel = new FloorController[_floorCount];
            for (int i = 0; i < _floorCount; ++i)
            {
                _floorControllerPanel[i] = new FloorController();
            }
        }

        public int getCount()
        {
            return _elevatorCount;
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

        public void runElevator(int index)
        {
            if (!_elevators[index].getRunningStatus())
            {
                _elevators[index].startRunning();
                Thread thread = new Thread(new ParameterizedThreadStart(run));
                thread.IsBackground = true;
                thread.Start(index);
            }
        }

        public void run(object param)
        {
            int index = (int)param;
            //MessageBox.Show(index.ToString());
            do
            {
                for (openDoor(index); _elevators[index].getDoorStatus(); openDoor(index))
                {
                    if (_elevators[index].getDoorStatus())
                    {
                        Thread.Sleep(3000);
                    }
                    //MessageBox.Show(index.ToString());
                    while (_elevators[index].getGateControllingButtonStatus())
                    {
                    }
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
            } while (!isArrived(index));
            
            /*for (openDoor(index); _elevators[index].getDoorStatus(); openDoor(index))
            {
                if (_elevators[index].getDoorStatus())
                {
                    Thread.Sleep(3000);
                }
                //MessageBox.Show(index.ToString());
            }*/
            while (_elevators[index].getGateControllingButtonStatus())
            {
                if (!_elevators[index].getDoorStatus())
                {
                    _elevators[index].openDoor();
                }
            }
            _elevators[index].closeDoor();

            _elevators[index]._shiftingCheck = false;
            _elevators[index].stop();
        }

        public bool isArrived(int index)
        {
            if (nextTaskExists(index))
            {
                return false;
            }
            return true;
        }

        public Direction acquireTask(int index)
        {
            if (_elevators[index].getDirection() == Direction.UP)
            {
                if (nextTaskUpwardExists(index))
                {
                    return Direction.UP;
                }
                else if (nextTaskDownwardExists(index))
                {
                    return Direction.DOWN;
                }
            }
            else if (_elevators[index].getDirection() == Direction.DOWN)
            {
                if (nextTaskDownwardExists(index))
                {
                    return Direction.DOWN;
                }
                else if (nextTaskUpwardExists(index))
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


        public bool nextTaskExists(int index)
        {
            for(int i = 0; i < _elevators[index].getFloorCount(); ++i)
            {
                if (_elevators[index].getFloorControllingButtonStatus(i) || _floorControllerPanel[i].getUpButtonStatus() || _floorControllerPanel[i].getDownButtonStatus())
                {
                    return true;
                }
            }
            return false;
        } 

        public bool nextTaskUpwardExists(int index)
        {
            for (int i = _elevators[index].getFloor() + 1; i < _elevators[index].getFloorCount(); ++i)
            {
                if (_elevators[index].getFloorControllingButtonStatus(i) || _floorControllerPanel[i].getUpButtonStatus() || _floorControllerPanel[i].getDownButtonStatus())
                {
                    return true;
                }
            }
            return false;
        }

        public bool nextTaskDownwardExists(int index)
        {
            for (int i = _elevators[index].getFloor() - 1; i >= 0; --i)
            {
                if (_elevators[index].getFloorControllingButtonStatus(i) || _floorControllerPanel[i].getDownButtonStatus() || _floorControllerPanel[i].getUpButtonStatus())
                {
                    return true;
                }
            }
            return false;
        }

        public void openDoor(int index)
        {
            //MessageBox.Show(_elevators[index].getFloor().ToString());
            if (_elevators[index].getDirection() == Direction.UP)
            {
                if (_elevators[index].getFloorControllingButtonStatus(_elevators[index].getFloor()) || _floorControllerPanel[_elevators[index].getFloor()].getUpButtonStatus())
                {
                    _elevators[index].openDoor();
                    _elevators[index].setFloorControllingButtonStatus(_elevators[index].getFloor(), false);
                    _floorControllerPanel[_elevators[index].getFloor()].upButtonReleased();
                }
                else if ((!nextTaskUpwardExists(index) && nextTaskDownwardExists(index)) || _floorControllerPanel[_elevators[index].getFloor()].getDownButtonStatus())
                {
                    if (_elevators[index]._shiftingCheck)
                    {
                        _elevators[index].openDoor();
                    }
                    else
                    {
                        _elevators[index]._shiftingCheck = true;
                    }
                    _elevators[index].setDirection(Direction.DOWN);
                    _floorControllerPanel[_elevators[index].getFloor()].downButtonReleased();
                }
            }
            else if (_elevators[index].getDirection() == Direction.DOWN)
            {
                if (_elevators[index].getFloorControllingButtonStatus(_elevators[index].getFloor()) || _floorControllerPanel[_elevators[index].getFloor()].getDownButtonStatus())
                {
                    _elevators[index].openDoor();
                    _elevators[index].setFloorControllingButtonStatus(_elevators[index].getFloor(), false);
                    _floorControllerPanel[_elevators[index].getFloor()].downButtonReleased();
                }
                else if ((!nextTaskDownwardExists(index) && nextTaskUpwardExists(index)) || _floorControllerPanel[_elevators[index].getFloor()].getUpButtonStatus())
                {
                    if (_elevators[index]._shiftingCheck)
                    {
                        _elevators[index].openDoor();
                    }
                    else
                    {
                        _elevators[index]._shiftingCheck = true;
                    }
                    _elevators[index].setDirection(Direction.UP);
                    _floorControllerPanel[_elevators[index].getFloor()].upButtonReleased();
                }
            }
            else
            {
                Exception excep = new Exception("Invalid elevator status.");
                throw excep;
            }
        }

        public void floorControllerUpButtonPressed(int index)
        {
            if (index < _elevators[0].getFloorCount())
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
            if (index < _elevators[0].getFloorCount())
            {
                _floorControllerPanel[index].downButtonPressed();
            }
            else
            {
                Exception excep = new Exception("Invalid value of floor index.");
                throw excep;
            }
        }

        public void floorControllerUpButtonReleased(int index)
        {
            if (index < _elevators[0].getFloorCount())
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
            if (index < _elevators[0].getFloorCount())
            {
                _floorControllerPanel[index].downButtonReleased();
            }
            else
            {
                Exception excep = new Exception("Invalid value of floor index.");
                throw excep;
            }
        }

        public bool getUpButtonStatusAtFloor(int index)
        {
            return _floorControllerPanel[index].getUpButtonStatus();
        }

        public bool getDownButtonStatusAtFloor(int index)
        {
            return _floorControllerPanel[index].getDownButtonStatus();
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

            runElevator(elevatorIndex);
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

            runElevator(elevatorIndex);
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
                    floorControllerUpButtonPressed(floor);
                }
                else if (direction == Direction.DOWN)
                {
                    floorControllerDownButtonPressed(floor);
                }
                else
                {
                    Exception excep = new Exception("Invalid value of direction.");
                    throw excep;
                }
            }

            runElevator();
        }

        public int getCurrentFloorElevatorAt(int index)
        {
            return _elevators[index].getFloor();
        }

        public bool getFloorControllerPanelStatusUp(int floor)
        {
            return getUpButtonStatusAtFloor(floor);
        }

        public bool getFloorControllerPanelStatusDown(int floor)
        {
            return getDownButtonStatusAtFloor(floor);
        }

        public bool getFloorControllingPanelStatus(int index, int floor)
        {
            return _elevators[index].getFloorControllingButtonStatus(floor);
        }

        public Direction getDirection(int index)
        {
            return _elevators[index].getDirection();
        }

        public bool getDoorStatus(int index)
        {
            return _elevators[index].getDoorStatus();
        }

        public void openDoorAt(int index)
        {
            _elevators[index].gateControllingButtonOpen();
        }

        public void closeDoorAt(int index)
        {
            _elevators[index].gateControllingButtonClose();
        }
    }
}
