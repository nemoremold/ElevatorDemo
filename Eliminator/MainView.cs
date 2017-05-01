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
                    }
                    else
                    {
                        pictureBox1.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 1)
                    {
                        pictureBox2.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox2.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 2)
                    {
                        pictureBox3.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox3.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 3)
                    {
                        pictureBox4.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox4.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 4)
                    {
                        pictureBox5.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox5.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 5)
                    {
                        pictureBox6.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox6.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 6)
                    {
                        pictureBox7.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox7.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 7)
                    {
                        pictureBox8.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox8.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 8)
                    {
                        pictureBox9.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox9.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 9)
                    {
                        pictureBox10.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox10.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 10)
                    {
                        pictureBox11.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox11.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 11)
                    {
                        pictureBox12.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox12.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 12)
                    {
                        pictureBox13.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox13.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 13)
                    {
                        pictureBox14.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox14.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 14)
                    {
                        pictureBox15.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox15.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 15)
                    {
                        pictureBox16.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox16.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 16)
                    {
                        pictureBox17.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox17.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 17)
                    {
                        pictureBox18.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox18.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 18)
                    {
                        pictureBox19.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox19.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(0) == 19)
                    {
                        pictureBox20.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox20.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 19)
                    {
                        pictureBox21.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox21.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 18)
                    {
                        pictureBox22.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox22.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 17)
                    {
                        pictureBox23.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox23.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 16)
                    {
                        pictureBox24.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox24.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 15)
                    {
                        pictureBox25.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox25.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 14)
                    {
                        pictureBox26.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox26.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 13)
                    {
                        pictureBox27.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox27.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 12)
                    {
                        pictureBox28.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox28.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 11)
                    {
                        pictureBox29.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox29.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 10)
                    {
                        pictureBox30.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox30.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 9)
                    {
                        pictureBox31.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox31.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 8)
                    {
                        pictureBox32.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox32.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 7)
                    {
                        pictureBox33.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox33.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 6)
                    {
                        pictureBox34.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox34.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 5)
                    {
                        pictureBox35.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox35.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 4)
                    {
                        pictureBox36.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox36.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 3)
                    {
                        pictureBox37.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox37.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 2)
                    {
                        pictureBox38.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox38.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 1)
                    {
                        pictureBox39.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox39.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(1) == 0)
                    {
                        pictureBox40.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox40.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 19)
                    {
                        pictureBox41.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox41.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 18)
                    {
                        pictureBox42.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox42.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 17)
                    {
                        pictureBox43.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox43.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 16)
                    {
                        pictureBox44.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox44.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 15)
                    {
                        pictureBox45.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox45.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 14)
                    {
                        pictureBox46.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox46.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 13)
                    {
                        pictureBox47.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox47.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 12)
                    {
                        pictureBox48.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox48.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 11)
                    {
                        pictureBox49.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox49.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 10)
                    {
                        pictureBox50.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox50.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 9)
                    {
                        pictureBox51.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox51.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 8)
                    {
                        pictureBox52.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox52.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 7)
                    {
                        pictureBox53.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox53.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 6)
                    {
                        pictureBox54.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox54.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 5)
                    {
                        pictureBox55.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox55.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 4)
                    {
                        pictureBox56.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox56.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 3)
                    {
                        pictureBox57.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox57.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 2)
                    {
                        pictureBox58.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox58.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 1)
                    {
                        pictureBox59.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox59.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(2) == 0)
                    {
                        pictureBox60.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox60.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 19)
                    {
                        pictureBox61.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox61.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 18)
                    {
                        pictureBox62.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox62.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 17)
                    {
                        pictureBox63.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox63.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 16)
                    {
                        pictureBox64.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox64.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 15)
                    {
                        pictureBox65.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox65.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 14)
                    {
                        pictureBox66.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox66.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 13)
                    {
                        pictureBox67.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox67.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 12)
                    {
                        pictureBox68.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox68.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 11)
                    {
                        pictureBox69.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox69.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 10)
                    {
                        pictureBox70.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox70.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 9)
                    {
                        pictureBox71.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox71.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 8)
                    {
                        pictureBox72.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox72.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 7)
                    {
                        pictureBox73.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox73.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 6)
                    {
                        pictureBox74.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox74.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 5)
                    {
                        pictureBox75.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox75.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 4)
                    {
                        pictureBox76.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox76.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 3)
                    {
                        pictureBox77.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox77.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 2)
                    {
                        pictureBox78.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox78.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 1)
                    {
                        pictureBox79.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox79.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(3) == 0)
                    {
                        pictureBox80.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox80.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 19)
                    {
                        pictureBox81.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox81.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 18)
                    {
                        pictureBox82.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox82.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 17)
                    {
                        pictureBox83.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox83.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 16)
                    {
                        pictureBox84.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox84.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 15)
                    {
                        pictureBox85.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox85.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 14)
                    {
                        pictureBox86.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox86.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 13)
                    {
                        pictureBox87.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox87.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 12)
                    {
                        pictureBox88.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox88.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 11)
                    {
                        pictureBox89.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox89.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 10)
                    {
                        pictureBox90.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox90.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 9)
                    {
                        pictureBox91.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox91.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 8)
                    {
                        pictureBox92.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox92.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 7)
                    {
                        pictureBox93.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox93.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 6)
                    {
                        pictureBox94.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox94.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 5)
                    {
                        pictureBox95.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox95.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 4)
                    {
                        pictureBox96.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox96.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 3)
                    {
                        pictureBox97.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox97.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 2)
                    {
                        pictureBox98.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox98.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 1)
                    {
                        pictureBox99.BackColor = System.Drawing.Color.Blue;
                    }
                    else
                    {
                        pictureBox99.BackColor = System.Drawing.Color.White;
                    }
                    if (controller.getCurrentFloorElevatorAt(4) == 0)
                    {
                        pictureBox100.BackColor = System.Drawing.Color.Blue;
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

                    label1.Text = "Elevator1: FLOOR " + controller.getCurrentFloorElevatorAt(0).ToString();
                    label2.Text = "Elevator1: FLOOR " + controller.getCurrentFloorElevatorAt(1).ToString();
                    label3.Text = "Elevator1: FLOOR " + controller.getCurrentFloorElevatorAt(2).ToString();
                    label4.Text = "Elevator1: FLOOR " + controller.getCurrentFloorElevatorAt(3).ToString();
                    label5.Text = "Elevator1: FLOOR " + controller.getCurrentFloorElevatorAt(4).ToString();

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
    }
}
