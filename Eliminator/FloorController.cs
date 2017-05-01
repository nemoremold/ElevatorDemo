using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Eliminator
{
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
}
