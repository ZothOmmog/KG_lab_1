using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KG_lab_1
{
    public partial class MainForm : Form
    {
        private bool createLine = false; //рисовать ли линию при следующей перерисовке


        public MainForm()
        {
            InitializeComponent();
        }

        //Создать линию
        private void CreateLine(Graphics g)
        {
            Pen blackPen = new Pen(Color.Black, 3);

            Point point1 = new Point(100, 100);
            Point point2 = new Point(300, 100);

            g.DrawLine(blackPen, point1, point2);

            createLine = false;
        }

        private void ButtonCreateLine_Click(object sender, EventArgs e)
        {
            createLine = true;
            panelGraphics.Visible = false;
            panelGraphics.Visible = true;
        }

        private void PanelGraphics_Paint(object sender, PaintEventArgs e)
        {
            if(createLine) CreateLine(e.Graphics);
            
        }

        
    }
}
