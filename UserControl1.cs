using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MtankersleyDemo2UC
{





    [System.ComponentModel.DefaultEvent("ButtonClicked")]
    public partial class UserControl1 : UserControl


    {
        public int lbl1Ct = 0;
        public int lbl2Ct = 0;
        public int btn1Click = 0;
        public int btn2Click = 0;
        public bool WasClicked = false;
        public string adduc1 = "Add UC1";
        public string remuc1 = "Remove UC1";

        public string adduc2 = "Add UC2";
        public string remuc2 = "Remove UC2";

        public string lbl1TBuc1 = "User Control 1";
        public string lbl2TBuc2 = "User Control 2";

        public string remlbl2UC2 = "";
        public string remlbl2UC1 = "";

        public List<string> lbl1Strings = new List<string>();
        public List<string> lbl2Strings = new List<string>();
        public bool disposedOfuc2 = false;
        public UserControl2 uc2 = null;
        






        public UserControl1()
        {
            ;
            InitializeComponent();

        }

        public Form1 frmMain
        {
            get
            {
                var parent = Parent;
                while (parent != null && (parent as Form1 == null))
                {
                    parent = parent.Parent;
                }
                return parent as Form1;
            }
        }

        public void lable1Ct()
        {
            if (lbl1Strings.Count > 2)
            {
                lbl1Strings.RemoveAt(lbl1Strings.Count - 1);
            }
            {

            }
        }

        public void lable2Ct()
        {
            if (lbl2Strings.Count > 2)
            {
                lbl2Strings.RemoveAt(lbl2Strings.Count - 1);
            }
            {

            }
        }
        public void DisposeOfUC2Check()
        {
            if (button1.Text == adduc1 && button2.Text == adduc2 && btn1Click > 0 && btn2Click > 0)
            {
                foreach (Control c in frmMain.Controls.OfType<UserControl2>().ToList())
                {
                    frmMain.Controls.Remove(c);
                    c.Dispose();
                    disposedOfuc2 = true;
                }
                
            }
            
        }
  

       



        public void buttonEvents1()
        {


            if (button1.Text == remuc1 && btn1Click > 0)
            {
                button1.Text = remuc1;
                uc2.tb1.Text = lbl1TBuc1;
                uc2.lb1.Text += lbl1TBuc1;
                lbl1Strings.Add(lbl1TBuc1);


            }

            if (button1.Text == adduc1 && btn1Click > 0)
            {
                button1.Text = remuc1;
                uc2.tb1.Text = lbl1TBuc1;
                uc2.lb1.Text += lbl1TBuc1;
                lbl1Strings.Add(lbl1TBuc1);




            }
            else if (button1.Text == remuc1)
            {


                button1.Text = adduc1;
                uc2.lb1.Text = "";
                uc2.tb1.Text = "";
                if (lbl1Strings.Count > 1)
                {
                    lbl1Strings.RemoveAt(lbl1Strings.Count - 1);

                }


            }


            return;
        }


        public void buttonEvents2()
        {

            if (button2.Text == remuc2 && btn2Click > 0)
            {
                button2.Text = remuc2;
                uc2.tb2.Text = lbl2TBuc2;
                uc2.lb2.Text += lbl2TBuc2;
                lbl2Strings.Add(lbl2TBuc2);




            }



            if (button2.Text == adduc2 && btn2Click > 0)
            {
                button2.Text = remuc2;
                uc2.tb2.Text = lbl2TBuc2;
                uc2.lb2.Text += lbl2TBuc2;
                lbl2Strings.Add(lbl2TBuc2);




            }
            else if (button2.Text == remuc2)
            {


                button2.Text = adduc2;
                uc2.lb2.Text = "";
                uc2.tb2.Text = "";
                if (lbl2Strings.Count > 1)
                {
                    lbl2Strings.RemoveAt(lbl2Strings.Count - 1);

                }
                ;

            }


            return;
        }




        public void button1_Click(object sender, EventArgs e)
        {
            
            if (uc2 == null || disposedOfuc2 == true)
            {
                uc2 = new UserControl2();
                uc2.Name = "uc2";
                uc2.Dock = DockStyle.None;
                uc2.Location = new Point(258, 36);
                frmMain.Controls.Add(uc2);
                disposedOfuc2 = false;
                

            }

            btn1Click += 1;

            buttonEvents1();
            DisposeOfUC2Check();

        }


        public void button2_Click(object sender, EventArgs e)
        {


            if (uc2 == null || disposedOfuc2 == true)
            {
                uc2 = new UserControl2();
                uc2.Name = "uc2";
                uc2.Dock = DockStyle.None;
                uc2.Location = new Point(258, 36);
                frmMain.Controls.Add(uc2);
                disposedOfuc2 = false;
            }


            btn2Click += 1;
            
            buttonEvents2();
            DisposeOfUC2Check();
        }





        public void disposeOfUC()
        {

            List<UserControl2> rem2 = frmMain.Controls.OfType<UserControl2>().ToList();
            foreach (UserControl2 rem2Item in rem2)
            {
                frmMain.Controls.Remove(rem2Item);
                rem2Item.Dispose();
            }
            lbl1Strings.Clear();
            lbl2Strings.Clear();
            WasClicked = false;
            btn1Click = 0;
            btn2Click = 0;
            uc2 = null;




        }
    }
}
    

    


           
        
            
    













