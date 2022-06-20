using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MtankersleyDemo2UC
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
           
            InitializeComponent();
            UserControl1 uc1 = new UserControl1(); 
            
            
            uc1.Dock = DockStyle.None;
            uc1.Location = new Point(223, 302);
            this.Controls.Add(uc1);
        }

      
    }


    }


