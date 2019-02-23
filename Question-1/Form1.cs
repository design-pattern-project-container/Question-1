using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace firstProject
{
    public partial class Form1 : Form
    {

        AllSwimmers notSorted, ageSorted, sexSorted, timeSorted;
        Swimmer swimmerHolder;
        public Form1()
        {
            InitializeComponent();
            notSorted = new AllSwimmers();
            ageSorted = notSorted.Clone();
            sexSorted = notSorted.Clone();
            timeSorted = notSorted.Clone();
            first_order(notSorted.OriginalList(), dataGridView12);
        }

        void first_order(List<Swimmer> swimmers , Bunifu.Framework.UI.BunifuCustomDataGrid CustomDataGridView) {
            DataTable second = new DataTable();
            
            second.Columns.Add("Full Name");
            second.Columns.Add("Age");
            second.Columns.Add("Sex");
            second.Columns.Add("Time");
            
            foreach (Swimmer a in swimmers)
            {
                rendering2(a, second, CustomDataGridView);
            }

        }
    
          
        public void rendering2(Swimmer s, DataTable second , Bunifu.Framework.UI.BunifuCustomDataGrid CustomdataGridView)
        {



            second.Clear();

                DataRow row2 = second.NewRow();

                row2["Full Name"] = s.fullName;
                row2["Age"] = s.age;
                row2["Sex"] = s.sex;
                row2["Time"] = s.time;

                second.Rows.Add(row2);




                foreach (DataRow Drow in second.Rows)
                {
                    int num = CustomdataGridView.Rows.Add();
                CustomdataGridView.Rows[num].Cells[0].Value = Drow["Full Name"].ToString();
                CustomdataGridView.Rows[num].Cells[1].Value = Drow["Age"].ToString();
                CustomdataGridView.Rows[num].Cells[2].Value = Drow["Sex"].ToString();
                CustomdataGridView.Rows[num].Cells[3].Value = Drow["Time"].ToString();



                }
            }
        

        private void AgeSorter_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            first_order(ageSorted.sortByAge(),dataGridView2);
        }

        private void sorterSex_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            first_order(ageSorted.sortBySex(),dataGridView2);
        }

        private void SorterTime_Click(object sender, EventArgs e)
        {


            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            first_order(ageSorted.sortByTime(),dataGridView2);
            
        }

    }
}
