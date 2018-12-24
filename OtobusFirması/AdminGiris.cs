using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusFirması
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void AdminGiris_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if(groupBox3.Visible)groupBox3.Visible = false;
            if(groupBox2.Visible)groupBox2.Visible = false;
            if(groupBox1.Visible)groupBox1.Visible = false;
            if(dataGridView1.Visible)dataGridView1.Visible = false;
        }

        private void üyelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox3.Visible == true || groupBox3.Visible == false) groupBox3.Visible = true;
            if (groupBox2.Visible == true || groupBox2.Visible == false) groupBox2.Visible = false;
            if (groupBox1.Visible == true || groupBox1.Visible == false) groupBox1.Visible = false;
            if (dataGridView1.Visible != true) dataGridView1.Visible = true;
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == true || groupBox2.Visible == false) groupBox2.Visible = true;
            if (groupBox3.Visible == false || groupBox3.Visible == true) groupBox3.Visible = false;
            if(groupBox1.Visible==false || groupBox1.Visible == true) groupBox1.Visible = false;
            if (dataGridView1.Visible == true || dataGridView1.Visible == false) dataGridView1.Visible = true;
        }

        private void seferlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == true || groupBox2.Visible == false) groupBox2.Visible = false;
            if (groupBox3.Visible == true || groupBox3.Visible == false) groupBox3.Visible = false;
            if (groupBox1.Visible == true || groupBox1.Visible == false) groupBox1.Visible = true;
            if (dataGridView1.Visible == true || dataGridView1.Visible == false) dataGridView1.Visible = true;
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }
    }
}
