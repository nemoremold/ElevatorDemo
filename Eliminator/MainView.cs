using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Eliminator
{
    public partial class MainView : Form
    {
        private ElevatorController controller;
        public MainView()
        {
            controller = new ElevatorController();
            InitializeComponent();
            Thread UIController = new Thread(new ThreadStart(UIControl));
            UIController.Start();
            //UIControl();
        }
        
        public void UIControl()
        {
            try
            {
                for(;;)
                {
                    //MessageBox.Show(controller.getCurrentFloorElevatorAt(1).ToString());
                    if (controller.getCurrentFloorElevatorAt(0) == 0)
                    {
                        pictureBox1.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox1.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox1.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 1)
                    {
                        pictureBox2.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox2.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox2.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 2)
                    {
                        pictureBox3.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox3.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox3.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 3)
                    {
                        pictureBox4.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox4.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox4.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 4)
                    {
                        pictureBox5.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox5.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox5.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 5)
                    {
                        pictureBox6.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox6.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox6.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 6)
                    {
                        pictureBox7.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox7.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox7.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 7)
                    {
                        pictureBox8.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox8.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox8.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 8)
                    {
                        pictureBox9.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox9.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox9.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 9)
                    {
                        pictureBox10.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox10.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox10.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 10)
                    {
                        pictureBox11.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox11.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox11.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 11)
                    {
                        pictureBox12.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox12.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox12.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 12)
                    {
                        pictureBox13.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox13.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox13.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 13)
                    {
                        pictureBox14.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox14.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox14.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 14)
                    {
                        pictureBox15.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox15.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox15.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 15)
                    {
                        pictureBox16.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox16.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox16.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 16)
                    {
                        pictureBox17.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox17.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox17.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 17)
                    {
                        pictureBox18.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox18.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox18.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 18)
                    {
                        pictureBox19.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox19.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox19.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 19)
                    {
                        pictureBox20.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(0))
                        {
                            pictureBox20.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox20.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 19)
                    {
                        pictureBox21.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox21.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox21.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 18)
                    {
                        pictureBox22.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox22.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox22.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 17)
                    {
                        pictureBox23.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox23.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox23.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 16)
                    {
                        pictureBox24.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox24.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox24.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 15)
                    {
                        pictureBox25.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox25.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox25.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 14)
                    {
                        pictureBox26.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox26.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox26.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 13)
                    {
                        pictureBox27.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox27.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox27.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 12)
                    {
                        pictureBox28.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox28.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox28.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 11)
                    {
                        pictureBox29.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox29.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox29.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 10)
                    {
                        pictureBox30.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox30.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox30.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 9)
                    {
                        pictureBox31.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox31.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox31.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 8)
                    {
                        pictureBox32.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox32.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox32.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 7)
                    {
                        pictureBox33.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox33.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox33.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 6)
                    {
                        pictureBox34.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox34.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox34.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 5)
                    {
                        pictureBox35.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox35.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox35.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 4)
                    {
                        pictureBox36.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox36.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox36.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 3)
                    {
                        pictureBox37.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox37.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox37.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 2)
                    {
                        pictureBox38.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox38.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox38.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 1)
                    {
                        pictureBox39.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox39.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox39.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 0)
                    {
                        pictureBox40.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(1))
                        {
                            pictureBox40.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox40.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 19)
                    {
                        pictureBox41.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox41.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox41.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 18)
                    {
                        pictureBox42.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox42.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox42.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 17)
                    {
                        pictureBox43.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox43.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox43.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 16)
                    {
                        pictureBox44.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox44.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox44.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 15)
                    {
                        pictureBox45.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox45.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox45.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 14)
                    {
                        pictureBox46.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox46.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox46.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 13)
                    {
                        pictureBox47.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox47.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox47.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 12)
                    {
                        pictureBox48.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox48.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox48.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 11)
                    {
                        pictureBox49.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox49.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox49.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 10)
                    {
                        pictureBox50.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox50.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox50.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 9)
                    {
                        pictureBox51.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox51.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox51.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 8)
                    {
                        pictureBox52.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox52.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox52.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 7)
                    {
                        pictureBox53.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox53.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox53.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 6)
                    {
                        pictureBox54.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox54.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox54.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 5)
                    {
                        pictureBox55.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox55.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox55.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 4)
                    {
                        pictureBox56.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox56.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox56.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 3)
                    {
                        pictureBox57.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox57.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox57.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 2)
                    {
                        pictureBox58.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox58.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox58.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 1)
                    {
                        pictureBox59.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox59.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox59.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 0)
                    {
                        pictureBox60.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(2))
                        {
                            pictureBox60.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox60.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 19)
                    {
                        pictureBox61.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox61.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox61.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 18)
                    {
                        pictureBox62.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox62.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox62.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 17)
                    {
                        pictureBox63.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox63.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox63.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 16)
                    {
                        pictureBox64.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox64.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox64.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 15)
                    {
                        pictureBox65.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox65.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox65.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 14)
                    {
                        pictureBox66.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox66.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox66.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 13)
                    {
                        pictureBox67.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox67.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox67.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 12)
                    {
                        pictureBox68.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox68.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox68.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 11)
                    {
                        pictureBox69.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox69.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox69.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 10)
                    {
                        pictureBox70.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox70.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox70.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 9)
                    {
                        pictureBox71.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox71.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox71.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 8)
                    {
                        pictureBox72.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox72.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox72.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 7)
                    {
                        pictureBox73.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox73.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox73.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 6)
                    {
                        pictureBox74.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox74.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox74.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 5)
                    {
                        pictureBox75.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox75.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox75.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 4)
                    {
                        pictureBox76.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox76.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox76.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 3)
                    {
                        pictureBox77.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox77.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox77.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 2)
                    {
                        pictureBox78.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox78.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox78.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 1)
                    {
                        pictureBox79.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox79.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox79.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 0)
                    {
                        pictureBox80.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(3))
                        {
                            pictureBox80.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox80.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 19)
                    {
                        pictureBox81.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox81.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox81.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 18)
                    {
                        pictureBox82.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox82.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox82.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 17)
                    {
                        pictureBox83.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox83.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox83.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 16)
                    {
                        pictureBox84.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox84.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox84.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 15)
                    {
                        pictureBox85.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox85.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox85.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 14)
                    {
                        pictureBox86.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox86.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox86.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 13)
                    {
                        pictureBox87.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox87.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox87.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 12)
                    {
                        pictureBox88.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox88.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox88.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 11)
                    {
                        pictureBox89.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox89.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox89.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 10)
                    {
                        pictureBox90.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox90.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox90.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 9)
                    {
                        pictureBox91.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox91.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox91.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 8)
                    {
                        pictureBox92.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox92.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox92.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 7)
                    {
                        pictureBox93.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox93.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox93.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 6)
                    {
                        pictureBox94.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox94.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox94.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 5)
                    {
                        pictureBox95.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox95.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox95.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 4)
                    {
                        pictureBox96.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox96.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox96.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 3)
                    {
                        pictureBox97.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox97.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox97.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 2)
                    {
                        pictureBox98.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox98.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox98.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 1)
                    {
                        pictureBox99.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox99.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox99.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 0)
                    {
                        pictureBox100.BackColor = System.Drawing.Color.Blue;
                        if (controller.getDoorStatus(4))
                        {
                            pictureBox100.BackColor = System.Drawing.Color.Green;
                        }
                    }
                    else
                    {
                        pictureBox100.BackColor = System.Drawing.Color.White;
                    }
                    /*string picture = "pictureBox";
                    for (int i = 1; i <= 20; ++i)
                    {
                        string temp = picture + i.ToString() + ".BackColor";
                        //MessageBox.Show(temp);
                        MessageBox.Show(this.GetType().GetField(temp).GetValue(this).ToString());
                        this.GetType().GetField(temp).SetValue(this, System.Drawing.Color.White);
                    }*/
                    if(controller.getFloorControllerPanelStatusUp(0) == true)
                    {
                        button116.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button116.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(1) == true)
                    {
                        button119.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button119.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(2) == true)
                    {
                        button121.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button121.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(3) == true)
                    {
                        button123.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button123.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(4) == true)
                    {
                        button125.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button125.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(5) == true)
                    {
                        button127.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button127.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(6) == true)
                    {
                        button129.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button129.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(7) == true)
                    {
                        button131.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button131.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(8) == true)
                    {
                        button133.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button133.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(9) == true)
                    {
                        button135.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button135.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(10) == true)
                    {
                        button137.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button137.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(11) == true)
                    {
                        button139.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button139.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(12) == true)
                    {
                        button141.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button141.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(13) == true)
                    {
                        button143.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button143.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(14) == true)
                    {
                        button145.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button145.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(15) == true)
                    {
                        button147.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button147.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(16) == true)
                    {
                        button149.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button149.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(17) == true)
                    {
                        button151.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button151.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusUp(18) == true)
                    {
                        button153.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button153.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(1) == true)
                    {
                        button118.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button118.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(2) == true)
                    {
                        button120.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button120.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(3) == true)
                    {
                        button122.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button122.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(4) == true)
                    {
                        button124.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button124.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(5) == true)
                    {
                        button126.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button126.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(6) == true)
                    {
                        button128.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button128.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(7) == true)
                    {
                        button130.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button130.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(8) == true)
                    {
                        button132.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button132.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(9) == true)
                    {
                        button134.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button134.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(10) == true)
                    {
                        button136.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button136.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(11) == true)
                    {
                        button138.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button138.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(12) == true)
                    {
                        button140.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button140.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(13) == true)
                    {
                        button142.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button142.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(14) == true)
                    {
                        button144.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button144.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(15) == true)
                    {
                        button146.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button146.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(16) == true)
                    {
                        button148.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button148.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(17) == true)
                    {
                        button150.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button150.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(18) == true)
                    {
                        button152.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button152.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllerPanelStatusDown(19) == true)
                    {
                        button154.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button154.BackColor = System.Drawing.Color.Gray;
                    }
                    //
                    //
                    //
                    if (controller.getFloorControllingPanelStatus(0, 0))
                    {
                        button1.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button1.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 1))
                    {
                        button2.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button2.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 2))
                    {
                        button3.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button3.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 3))
                    {
                        button4.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button4.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 4))
                    {
                        button5.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button5.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 5))
                    {
                        button6.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button6.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 6))
                    {
                        button7.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button7.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 7))
                    {
                        button8.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button8.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 8))
                    {
                        button9.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button9.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 9))
                    {
                        button10.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button10.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 10))
                    {
                        button11.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button11.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 11))
                    {
                        button12.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button12.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 12))
                    {
                        button13.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button13.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 13))
                    {
                        button14.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button14.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 14))
                    {
                        button15.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button15.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 15))
                    {
                        button16.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button16.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 16))
                    {
                        button17.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button17.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 17))
                    {
                        button18.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button18.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 18))
                    {
                        button19.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button19.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(0, 19))
                    {
                        button20.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button20.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 0))
                    {
                        button46.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button46.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 1))
                    {
                        button45.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button45.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 2))
                    {
                        button44.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button44.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 3))
                    {
                        button43.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button43.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 4))
                    {
                        button42.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button42.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 5))
                    {
                        button41.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button41.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 6))
                    {
                        button40.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button40.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 7))
                    {
                        button39.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button39.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 8))
                    {
                        button38.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button38.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 9))
                    {
                        button37.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button37.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 10))
                    {
                        button36.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button36.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 11))
                    {
                        button35.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button35.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 12))
                    {
                        button34.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button34.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 13))
                    {
                        button33.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button33.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 14))
                    {
                        button32.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button32.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 15))
                    {
                        button31.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button31.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 16))
                    {
                        button30.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button30.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 17))
                    {
                        button29.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button29.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 18))
                    {
                        button28.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button28.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(1, 19))
                    {
                        button27.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button27.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 0))
                    {
                        button69.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button69.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 1))
                    {
                        button68.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button68.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 2))
                    {
                        button67.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button67.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 3))
                    {
                        button66.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button66.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 4))
                    {
                        button65.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button65.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 5))
                    {
                        button64.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button64.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 6))
                    {
                        button63.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button63.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 7))
                    {
                        button62.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button62.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 8))
                    {
                        button61.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button61.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 9))
                    {
                        button60.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button60.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 10))
                    {
                        button59.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button59.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 11))
                    {
                        button58.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button58.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 12))
                    {
                        button57.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button57.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 13))
                    {
                        button56.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button56.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 14))
                    {
                        button55.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button55.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 15))
                    {
                        button54.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button54.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 16))
                    {
                        button53.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button53.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 17))
                    {
                        button52.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button52.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 18))
                    {
                        button51.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button51.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(2, 19))
                    {
                        button50.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button50.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 0))
                    {
                        button92.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button92.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 1))
                    {
                        button91.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button91.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 2))
                    {
                        button90.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button90.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 3))
                    {
                        button89.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button89.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 4))
                    {
                        button88.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button88.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 5))
                    {
                        button87.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button87.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 6))
                    {
                        button86.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button86.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 7))
                    {
                        button85.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button85.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 8))
                    {
                        button84.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button84.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 9))
                    {
                        button83.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button83.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 10))
                    {
                        button82.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button82.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 11))
                    {
                        button81.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button81.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 12))
                    {
                        button80.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button80.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 13))
                    {
                        button79.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button79.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 14))
                    {
                        button78.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button78.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 15))
                    {
                        button77.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button77.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 16))
                    {
                        button76.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button76.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 17))
                    {
                        button75.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button75.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 18))
                    {
                        button74.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button74.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(3, 19))
                    {
                        button73.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button73.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 0))
                    {
                        button115.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button115.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 1))
                    {
                        button114.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button114.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 2))
                    {
                        button113.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button113.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 3))
                    {
                        button112.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button112.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 4))
                    {
                        button111.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button111.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 5))
                    {
                        button110.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button110.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 6))
                    {
                        button109.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button109.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 7))
                    {
                        button108.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button108.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 8))
                    {
                        button107.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button107.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 9))
                    {
                        button106.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button106.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 10))
                    {
                        button105.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button105.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 11))
                    {
                        button104.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button104.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 12))
                    {
                        button103.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button103.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 13))
                    {
                        button102.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button102.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 14))
                    {
                        button101.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button101.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 15))
                    {
                        button100.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button100.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 16))
                    {
                        button99.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button99.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 17))
                    {
                        button98.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button98.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 18))
                    {
                        button97.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button97.BackColor = System.Drawing.Color.Gray;
                    }
                    if (controller.getFloorControllingPanelStatus(4, 19))
                    {
                        button96.BackColor = System.Drawing.Color.Gold;
                    }
                    else
                    {
                        button96.BackColor = System.Drawing.Color.Gray;
                    }

                    if (controller.getDirection(0) == Direction.UP)
                    {
                        label1.Text = "Elevator1: FLOOR " + (controller.getCurrentFloorElevatorAt(0) + 1).ToString() + " UP";
                    }
                    else if (controller.getDirection(0) == Direction.DOWN)
                    {
                        label1.Text = "Elevator1: FLOOR " + (controller.getCurrentFloorElevatorAt(0) + 1).ToString() + " DOWN";
                    }
                    if (controller.getDirection(1) == Direction.UP)
                    {
                        label2.Text = "Elevator2: FLOOR " + (controller.getCurrentFloorElevatorAt(1) + 1).ToString() + " UP";
                    }
                    else if (controller.getDirection(1) == Direction.DOWN)
                    {
                        label2.Text = "Elevator2: FLOOR " + (controller.getCurrentFloorElevatorAt(1) + 1).ToString() + " DOWN";
                    }
                    if (controller.getDirection(2) == Direction.UP)
                    {
                        label3.Text = "Elevator3: FLOOR " + (controller.getCurrentFloorElevatorAt(2) + 1).ToString() + " UP";
                    }
                    else if (controller.getDirection(2) == Direction.DOWN)
                    {
                        label3.Text = "Elevator3: FLOOR " + (controller.getCurrentFloorElevatorAt(2) + 1).ToString() + " DOWN";
                    }
                    if (controller.getDirection(3) == Direction.UP)
                    {
                        label4.Text = "Elevator4: FLOOR " + (controller.getCurrentFloorElevatorAt(3) + 1).ToString() + " UP";
                    }
                    else if (controller.getDirection(3) == Direction.DOWN)
                    {
                        label4.Text = "Elevator4: FLOOR " + (controller.getCurrentFloorElevatorAt(3) + 1).ToString() + " DOWN";
                    }
                    if (controller.getDirection(4) == Direction.UP)
                    {
                        label5.Text = "Elevator5: FLOOR " + (controller.getCurrentFloorElevatorAt(4) + 1).ToString() + " UP";
                    }
                    else if (controller.getDirection(4) == Direction.DOWN)
                    {
                        label5.Text = "Elevator5: FLOOR " + (controller.getCurrentFloorElevatorAt(4) + 1).ToString() + " DOWN";
                    }

                    Thread.Sleep(100);
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void button116_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(0))
            {
                controller.exteriorRequest(0, Direction.UP);
            }
        }

        private void button119_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(1))
            {
                controller.exteriorRequest(1, Direction.UP);
            }
        }

        private void button121_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(2))
            {
                controller.exteriorRequest(2, Direction.UP);
            }
        }

        private void button123_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(3))
            {
                controller.exteriorRequest(3, Direction.UP);
            }
        }

        private void button125_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(4))
            {
                controller.exteriorRequest(4, Direction.UP);
            }
        }

        private void button127_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(5))
            {
                controller.exteriorRequest(5, Direction.UP);
            }
        }

        private void button129_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(6))
            {
                controller.exteriorRequest(6, Direction.UP);
            }
        }

        private void button131_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(7))
            {
                controller.exteriorRequest(7, Direction.UP);
            }
        }

        private void button133_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(8))
            {
                controller.exteriorRequest(8, Direction.UP);
            }
        }

        private void button135_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(9))
            {
                controller.exteriorRequest(9, Direction.UP);
            }
        }

        private void button137_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(10))
            {
                controller.exteriorRequest(10, Direction.UP);
            }
        }

        private void button139_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(11))
            {
                controller.exteriorRequest(11, Direction.UP);
            }
        }

        private void button141_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(12))
            {
                controller.exteriorRequest(12, Direction.UP);
            }
        }

        private void button143_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(13))
            {
                controller.exteriorRequest(13, Direction.UP);
            }
        }

        private void button145_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(14))
            {
                controller.exteriorRequest(14, Direction.UP);
            }
        }

        private void button147_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(15))
            {
                controller.exteriorRequest(15, Direction.UP);
            }
        }

        private void button149_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(16))
            {
                controller.exteriorRequest(16, Direction.UP);
            }
        }

        private void button151_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(17))
            {
                controller.exteriorRequest(17, Direction.UP);
            }
        }

        private void button153_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusUp(18))
            {
                controller.exteriorRequest(18, Direction.UP);
            }
        }

        private void button118_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(1))
            {
                controller.exteriorRequest(1, Direction.DOWN);
            }
        }

        private void button120_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(2))
            {
                controller.exteriorRequest(2, Direction.DOWN);
            }
        }

        private void button122_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(3))
            {
                controller.exteriorRequest(3, Direction.DOWN);
            }
        }

        private void button124_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(4))
            {
                controller.exteriorRequest(4, Direction.DOWN);
            }
        }

        private void button126_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(5))
            {
                controller.exteriorRequest(5, Direction.DOWN);
            }
        }

        private void button128_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(6))
            {
                controller.exteriorRequest(6, Direction.DOWN);
            }
        }

        private void button130_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(7))
            {
                controller.exteriorRequest(7, Direction.DOWN);
            }
        }

        private void button132_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(8))
            {
                controller.exteriorRequest(8, Direction.DOWN);
            }
        }

        private void button134_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(9))
            {
                controller.exteriorRequest(9, Direction.DOWN);
            }
        }

        private void button136_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(10))
            {
                controller.exteriorRequest(10, Direction.DOWN);
            }
        }

        private void button138_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(11))
            {
                controller.exteriorRequest(11, Direction.DOWN);
            }
        }

        private void button140_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(12))
            {
                controller.exteriorRequest(12, Direction.DOWN);
            }
        }

        private void button142_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(13))
            {
                controller.exteriorRequest(13, Direction.DOWN);
            }
        }

        private void button144_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(14))
            {
                controller.exteriorRequest(14, Direction.DOWN);
            }
        }

        private void button146_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(15))
            {
                controller.exteriorRequest(15, Direction.DOWN);
            }
        }

        private void button148_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(16))
            {
                controller.exteriorRequest(16, Direction.DOWN);
            }
        }

        private void button150_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(17))
            {
                controller.exteriorRequest(17, Direction.DOWN);
            }
        }

        private void button152_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(18))
            {
                controller.exteriorRequest(18, Direction.DOWN);
            }
        }

        private void button154_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllerPanelStatusDown(19))
            {
                controller.exteriorRequest(19, Direction.DOWN);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 0))
            {
                controller.interiorRequestFloorControlling(0, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 1))
            {
                controller.interiorRequestFloorControlling(0, 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 2))
            {
                controller.interiorRequestFloorControlling(0, 2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 3))
            {
                controller.interiorRequestFloorControlling(0, 3);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 4))
            {
                controller.interiorRequestFloorControlling(0, 4);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 5))
            {
                controller.interiorRequestFloorControlling(0, 5);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 6))
            {
                controller.interiorRequestFloorControlling(0, 6);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 7))
            {
                controller.interiorRequestFloorControlling(0, 7);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 8))
            {
                controller.interiorRequestFloorControlling(0, 8);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 9))
            {
                controller.interiorRequestFloorControlling(0, 9);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 10))
            {
                controller.interiorRequestFloorControlling(0, 10);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 11))
            {
                controller.interiorRequestFloorControlling(0, 11);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 12))
            {
                controller.interiorRequestFloorControlling(0, 12);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 13))
            {
                controller.interiorRequestFloorControlling(0, 13);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 14))
            {
                controller.interiorRequestFloorControlling(0, 14);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 15))
            {
                controller.interiorRequestFloorControlling(0, 15);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 16))
            {
                controller.interiorRequestFloorControlling(0, 16);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 17))
            {
                controller.interiorRequestFloorControlling(0, 17);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 18))
            {
                controller.interiorRequestFloorControlling(0, 18);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(0, 19))
            {
                controller.interiorRequestFloorControlling(0, 19);
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 0))
            {
                controller.interiorRequestFloorControlling(1, 0);
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 1))
            {
                controller.interiorRequestFloorControlling(1, 1);
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 2))
            {
                controller.interiorRequestFloorControlling(1, 2);
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 3))
            {
                controller.interiorRequestFloorControlling(1, 3);
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 4))
            {
                controller.interiorRequestFloorControlling(1, 4);
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 5))
            {
                controller.interiorRequestFloorControlling(1, 5);
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 6))
            {
                controller.interiorRequestFloorControlling(1, 6);
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 7))
            {
                controller.interiorRequestFloorControlling(1, 7);
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 8))
            {
                controller.interiorRequestFloorControlling(1, 8);
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 9))
            {
                controller.interiorRequestFloorControlling(1, 9);
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 10))
            {
                controller.interiorRequestFloorControlling(1, 10);
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 11))
            {
                controller.interiorRequestFloorControlling(1, 11);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 12))
            {
                controller.interiorRequestFloorControlling(1, 12);
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 13))
            {
                controller.interiorRequestFloorControlling(1, 13);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 14))
            {
                controller.interiorRequestFloorControlling(1, 14);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 15))
            {
                controller.interiorRequestFloorControlling(1, 15);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 16))
            {
                controller.interiorRequestFloorControlling(1, 16);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 17))
            {
                controller.interiorRequestFloorControlling(1, 17);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 18))
            {
                controller.interiorRequestFloorControlling(1, 18);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(1, 19))
            {
                controller.interiorRequestFloorControlling(1, 19);
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 0))
            {
                controller.interiorRequestFloorControlling(2, 0);
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 1))
            {
                controller.interiorRequestFloorControlling(2, 1);
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 2))
            {
                controller.interiorRequestFloorControlling(2, 2);
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 3))
            {
                controller.interiorRequestFloorControlling(2, 3);
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 4))
            {
                controller.interiorRequestFloorControlling(2, 4);
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 5))
            {
                controller.interiorRequestFloorControlling(2, 5);
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 6))
            {
                controller.interiorRequestFloorControlling(2, 6);
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 7))
            {
                controller.interiorRequestFloorControlling(2, 7);
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 8))
            {
                controller.interiorRequestFloorControlling(2, 8);
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 9))
            {
                controller.interiorRequestFloorControlling(2, 9);
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 10))
            {
                controller.interiorRequestFloorControlling(2, 10);
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 11))
            {
                controller.interiorRequestFloorControlling(2, 11);
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 12))
            {
                controller.interiorRequestFloorControlling(2, 12);
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 13))
            {
                controller.interiorRequestFloorControlling(2, 13);
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 14))
            {
                controller.interiorRequestFloorControlling(2, 14);
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 15))
            {
                controller.interiorRequestFloorControlling(2, 15);
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 16))
            {
                controller.interiorRequestFloorControlling(2, 16);
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 17))
            {
                controller.interiorRequestFloorControlling(2, 17);
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 18))
            {
                controller.interiorRequestFloorControlling(2, 18);
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(2, 19))
            {
                controller.interiorRequestFloorControlling(2, 19);
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 0))
            {
                controller.interiorRequestFloorControlling(3, 0);
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 1))
            {
                controller.interiorRequestFloorControlling(3, 1);
            }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 2))
            {
                controller.interiorRequestFloorControlling(3, 2);
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 3))
            {
                controller.interiorRequestFloorControlling(3, 3);
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 4))
            {
                controller.interiorRequestFloorControlling(3, 4);
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 5))
            {
                controller.interiorRequestFloorControlling(3, 5);
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 6))
            {
                controller.interiorRequestFloorControlling(3, 6);
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 7))
            {
                controller.interiorRequestFloorControlling(3, 7);
            }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 8))
            {
                controller.interiorRequestFloorControlling(3, 8);
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 9))
            {
                controller.interiorRequestFloorControlling(3, 9);
            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 10))
            {
                controller.interiorRequestFloorControlling(3, 10);
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 11))
            {
                controller.interiorRequestFloorControlling(3, 11);
            }
        }

        private void button80_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 12))
            {
                controller.interiorRequestFloorControlling(3, 12);
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 13))
            {
                controller.interiorRequestFloorControlling(3, 13);
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 14))
            {
                controller.interiorRequestFloorControlling(3, 14);
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 15))
            {
                controller.interiorRequestFloorControlling(3, 15);
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 16))
            {
                controller.interiorRequestFloorControlling(3, 16);
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 17))
            {
                controller.interiorRequestFloorControlling(3, 17);
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 18))
            {
                controller.interiorRequestFloorControlling(3, 18);
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(3, 19))
            {
                controller.interiorRequestFloorControlling(3, 19);
            }
        }

        private void button115_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 0))
            {
                controller.interiorRequestFloorControlling(4, 0);
            }
        }

        private void button114_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 1))
            {
                controller.interiorRequestFloorControlling(4, 1);
            }
        }

        private void button113_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 2))
            {
                controller.interiorRequestFloorControlling(4, 2);
            }
        }

        private void button112_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 3))
            {
                controller.interiorRequestFloorControlling(4, 3);
            }
        }

        private void button111_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 4))
            {
                controller.interiorRequestFloorControlling(4, 4);
            }
        }

        private void button110_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 5))
            {
                controller.interiorRequestFloorControlling(4, 5);
            }
        }

        private void button109_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 6))
            {
                controller.interiorRequestFloorControlling(4, 6);
            }
        }

        private void button108_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 7))
            {
                controller.interiorRequestFloorControlling(4, 7);
            }
        }

        private void button107_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 8))
            {
                controller.interiorRequestFloorControlling(4, 8);
            }
        }

        private void button106_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 9))
            {
                controller.interiorRequestFloorControlling(4, 9);
            }
        }

        private void button105_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 10))
            {
                controller.interiorRequestFloorControlling(4, 10);
            }
        }

        private void button104_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 11))
            {
                controller.interiorRequestFloorControlling(4, 11);
            }
        }

        private void button103_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 12))
            {
                controller.interiorRequestFloorControlling(4, 12);
            }
        }

        private void button102_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 13))
            {
                controller.interiorRequestFloorControlling(4, 13);
            }
        }

        private void button101_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 14))
            {
                controller.interiorRequestFloorControlling(4, 14);
            }
        }

        private void button100_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 15))
            {
                controller.interiorRequestFloorControlling(4, 15);
            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 16))
            {
                controller.interiorRequestFloorControlling(4, 16);
            }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 17))
            {
                controller.interiorRequestFloorControlling(4, 17);
            }
        }

        private void button97_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 18))
            {
                controller.interiorRequestFloorControlling(4, 18);
            }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            if (!controller.getFloorControllingPanelStatus(4, 19))
            {
                controller.interiorRequestFloorControlling(4, 19);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ELEVATOR1 sends an alert!");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ELEVATOR2 sends an alert!");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ELEVATOR3 sends an alert!");
        }

        private void button70_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ELEVATOR4 sends an alert!");
        }

        private void button93_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ELEVATOR5 sends an alert!");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == System.Drawing.Color.Gold)
            {
                return;
            }
            if (button21.BackColor == System.Drawing.Color.Gray)
            {
                button21.BackColor = System.Drawing.Color.Gold;
                controller.openDoorAt(0);
                controller.interiorRequestGateControlling(0, true);
            }
            else
            {
                button21.BackColor = System.Drawing.Color.Gray;
                controller.closeDoorAt(0);
                controller.interiorRequestGateControlling(0, false);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == System.Drawing.Color.Gold)
            {
                return;
            }
            if (button22.BackColor == System.Drawing.Color.Gray)
            {
                button22.BackColor = System.Drawing.Color.Gold;
                controller.closeDoorAt(0);
                controller.interiorRequestGateControlling(0, false);
            }
            else
            {
                button22.BackColor = System.Drawing.Color.Gray;
                controller.openDoorAt(0);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == System.Drawing.Color.Gold)
            {
                return;
            }
            if (button26.BackColor == System.Drawing.Color.Gray)
            {
                button26.BackColor = System.Drawing.Color.Gold;
                controller.openDoorAt(1);
                controller.interiorRequestGateControlling(1, true);
            }
            else
            {
                button26.BackColor = System.Drawing.Color.Gray;
                controller.closeDoorAt(1);
                controller.interiorRequestGateControlling(1, false);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button26.BackColor == System.Drawing.Color.Gold)
            {
                return;
            }
            if (button25.BackColor == System.Drawing.Color.Gray)
            {
                button25.BackColor = System.Drawing.Color.Gold;
                controller.closeDoorAt(1);
                controller.interiorRequestGateControlling(1, false);
            }
            else
            {
                button25.BackColor = System.Drawing.Color.Gray;
                controller.openDoorAt(1);
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (button48.BackColor == System.Drawing.Color.Gold)
            {
                return;
            }
            if (button49.BackColor == System.Drawing.Color.Gray)
            {
                button49.BackColor = System.Drawing.Color.Gold;
                controller.openDoorAt(2);
                controller.interiorRequestGateControlling(2, true);
            }
            else
            {
                button49.BackColor = System.Drawing.Color.Gray;
                controller.closeDoorAt(2);
                controller.interiorRequestGateControlling(2, false);
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (button49.BackColor == System.Drawing.Color.Gold)
            {
                return;
            }
            if (button48.BackColor == System.Drawing.Color.Gray)
            {
                button48.BackColor = System.Drawing.Color.Gold;
                controller.closeDoorAt(2);
                controller.interiorRequestGateControlling(2, false);
            }
            else
            {
                button48.BackColor = System.Drawing.Color.Gray;
                controller.openDoorAt(2);
            }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (button71.BackColor == System.Drawing.Color.Gold)
            {
                return;
            }
            if (button72.BackColor == System.Drawing.Color.Gray)
            {
                button72.BackColor = System.Drawing.Color.Gold;
                controller.openDoorAt(3);
                controller.interiorRequestGateControlling(3, true);
            }
            else
            {
                button72.BackColor = System.Drawing.Color.Gray;
                controller.closeDoorAt(3);
                controller.interiorRequestGateControlling(3, false);
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (button72.BackColor == System.Drawing.Color.Gold)
            {
                return;
            }
            if (button71.BackColor == System.Drawing.Color.Gray)
            {
                button71.BackColor = System.Drawing.Color.Gold;
                controller.closeDoorAt(3);
                controller.interiorRequestGateControlling(3, false);
            }
            else
            {
                button71.BackColor = System.Drawing.Color.Gray;
                controller.openDoorAt(3);
            }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            if (button94.BackColor == System.Drawing.Color.Gold)
            {
                return;
            }
            if (button95.BackColor == System.Drawing.Color.Gray)
            {
                button95.BackColor = System.Drawing.Color.Gold;
                controller.openDoorAt(4);
                controller.interiorRequestGateControlling(4, true);
            }
            else
            {
                button95.BackColor = System.Drawing.Color.Gray;
                controller.closeDoorAt(4);
                controller.interiorRequestGateControlling(4, false);
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            if (button95.BackColor == System.Drawing.Color.Gold)
            {
                return;
            }
            if (button94.BackColor == System.Drawing.Color.Gray)
            {
                button94.BackColor = System.Drawing.Color.Gold;
                controller.closeDoorAt(4);
                controller.interiorRequestGateControlling(4, false);
            }
            else
            {
                button94.BackColor = System.Drawing.Color.Gray;
                controller.openDoorAt(4);
            }
        }
    }
}
