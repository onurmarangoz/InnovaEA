using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibilty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /*
             * Her koyun kendi bacağından asılmalıdır. Her sınıf sadece kendi işinden sorumlu olmalıdır. 
             * 
             * 1. Bir sınıfta değişiklik yapmak için çok sebebiniz varsa; bu prensibi ihlal ediyorsunuz demektir.
             * 2. Yazmakta olduğunuz sınıfın görevini sorun.
             * 
             */
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            int affectedRows = new ProductBusiness().AddProduct(name, price);

            string message = affectedRows > 0 ? "Kayıt başarılı " : "Kayıt başarısız";
            MessageBox.Show(message);

        }

     
    }
}
