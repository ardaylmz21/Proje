using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERSONEL_TAKİP_OTOMASyonu
{
    public partial class frmizinHareketRaporu : Form
    {
        public frmizinHareketRaporu()
        {
            InitializeComponent();
        }

        private void frmizinHareketRaporu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personellTakibi1DataSet.İzinRapor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.İzinRaporTableAdapter.izinrapor(this.personellTakibi1DataSet.İzinRapor);

            this.reportViewer1.RefreshReport();
        }
    }
}
