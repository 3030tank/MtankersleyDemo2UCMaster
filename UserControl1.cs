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
using System.Linq;


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

        public string lblTBuc1 = "User Control 1";
        public string lblTBuc2 = "User Control 2";

        public string remlbl2UC2 = "";
        public string remlbl2UC1 = "";

        public List<string> lbl1Strings = new List<string>();
        public List<string> lbl2Strings = new List<string>();

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
            if (lbl1Strings.Count >2)
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
                btn1Click = 0;
                btn2Click = 0;
                disposeOfUC();
                
            }
        }
        public void buttonEvents1()
        {

            
            if (button1.Text == remuc1 && btn1Click >0)
            {
                button1.Text = remuc1;
                uc2.tb1.Text = lblTBuc1;
                uc2.lb1.Text += lblTBuc1;
                lbl1Strings.Add(lblTBuc1);
                
                


            }



            


            if (button1.Text == adduc1 && btn1Click >0)
            {
                button1.Text = remuc1;
                uc2.tb1.Text = lblTBuc1;
                uc2.lb1.Text += lblTBuc1;
                lbl1Strings.Add(lblTBuc1);
                
                


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

        //public event EventHandler ButtonClicked;
        //protected virtual void OnButtonClicked(EventArgs e)
        //{
        //    var handler = ButtonClicked;
        //    if (handler != null)
        //        handler(this, e);
        //}
        public void buttonEvents2()
        {

            if (button2.Text == remuc2 && btn2Click > 0)
            {
                button2.Text = remuc2;
                uc2.tb2.Text = lblTBuc2;
                uc2.lb1.Text += lblTBuc2;
                lbl2Strings.Add(lblTBuc2);
               
                


            }






            if (button2.Text == adduc2 && btn2Click > 0)
            {
                button2.Text = remuc2;
                uc2.tb2.Text = lblTBuc2;
                uc2.lb1.Text += lblTBuc2;
                lbl2Strings.Add(lblTBuc2);
               
                


            }
            else if (button2.Text == remuc2)
            {


                button2.Text = adduc2;
                uc2.lb1.Text = "";
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
                DisposeOfUC2Check();
                if (uc2 == null)    
                {
                    uc2 = new UserControl2();
                    uc2.Dock = DockStyle.None;
                    uc2.Location = new Point(258, 36);
                    frmMain.Controls.Add(uc2);
                }


            //if (btn1Click == 0)
            //{
            //    button1.Text = remuc1;
            //    uc2.tb1.Text = lblTBuc1;
            //    uc2.lb1.Text = lblTBuc1;

            //}

            btn1Click += 1;

                buttonEvents1();
                
           

        }


        public void button2_Click(object sender, EventArgs e)
        {
            if (uc2 == null)
            {
                uc2 = new UserControl2();
                uc2.Dock = DockStyle.None;
                uc2.Location = new Point(258, 36);
                frmMain.Controls.Add(uc2);
            }
            //if (btn1Click == 0)
            //{
            //    button1.Text = remuc1;
            //    uc2.tb1.Text = lblTBuc1;
            //    uc2.lb1.Text = lblTBuc1;

            //}

            btn2Click += 1;

            buttonEvents2();



        }





        public void disposeOfUC()
            {

                frmMain.Controls.RemoveAt(1);
                lbl1Strings.Clear();
                lbl2Strings.Clear();
                WasClicked = false;
                btn1Click = 0;
                btn2Click = 0;
                uc2 = null;

            }




        }
    }


           
        
            
    













