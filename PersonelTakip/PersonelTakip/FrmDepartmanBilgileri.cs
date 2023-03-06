using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using DAL.DataAccesObject;

namespace PersonelTakip
{
    public partial class FrmDepartmanBilgileri : Form
    {
        public FrmDepartmanBilgileri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtDepartman.Text.Trim() == "")
                MessageBox.Show("Departman Adı girin");

            else
            {
                Departman dpt = new Departman();
                dpt.DepartmanName = TxtDepartman.Text;
                DepartmanBLL.DepartmanEkle(dpt);
                MessageBox.Show("Departman Eklendi");
                TxtDepartman.Clear();

            }


            
         
            
           
        }
    }
}
