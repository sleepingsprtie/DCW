using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DCW
{
    public partial class Form_q_daten_fragebogen : Form
    {
        public Form_q_daten_fragebogen()
        {
            InitializeComponent();
        }

        private void t_wer_macht_wasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_wer_macht_wasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dcwDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dcwDataSet.t_wer_macht_was”中。您可以根据需要移动或删除它。
            this.t_wer_macht_wasTableAdapter.Fill(this.dcwDataSet.t_wer_macht_was);

        }
    }
}
