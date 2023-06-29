using AbuEhab.EFSystem.DataLayer.Entities;
using AbuEhab.EFSystem.DataLayer.Repositories;
using AbuEhab.EFSystem.UILayer.Interfaces;
using AbuEhab.EFSystem.UILayer.Services;

namespace AbuEhab.EFSystem.UILayer.Forms.Phones
{
	public partial class frmPhones : Form
	{
		public frmPhones()
		{
			InitializeComponent();
		}
	
        private IRepository<Phone> repository = new Repository<Phone>();
		private IStyler styler = new Styler();

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmAddPhone frm = new frmAddPhone();
			frm.ShowDialog();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			if (txtSearch.Text != string.Empty)
			{

				dgv.DataSource = null;
				dgv.Rows.Clear();
				var q = repository.GetBy(p =>
						  p.Name.Contains(txtSearch.Text)
								   ).OrderByDescending(c => c.CreationDate).ToList();
				q.ForEach(i =>
				{
					dgv.Rows.Add(i.Id.ToString(), i.Name, i.Jawwal, i.Ooredoo);
				});

				q = null;
			}
			else
			{
				dgv.DataSource = null;
				this.PopulateDgv();
			}
		}

		void PopulateDgv()
		{
			dgv.DataSource = null;
			txtSearch.Clear();
			txtSearch.Focus();
            // I used delegate here :
            this.Invoke((MethodInvoker)delegate
			{

				dgv.Rows.Clear();
				var q = repository.GetAll().OrderByDescending(c => c.CreationDate).ToList();
				q.ForEach(i =>
				{
					dgv.Rows.Add(i.Id.ToString(), i.Name, i.Jawwal, i.Ooredoo);
				});

				q = null;
			});

			this.styler.GridFullStyle(dgv);
		}

		private void frmPhones_Load(object sender, EventArgs e)
		{
			this.PopulateDgv();

		}


		private void btnRefrish_Click(object sender, EventArgs e)
		{
			this.PopulateDgv();
		}

		private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgv.Rows.Count > 0)
			{
				int col = this.dgv.CurrentCell.ColumnIndex;

				int xId = int.Parse(dgv.CurrentRow.Cells[0].Value.ToString());

				Phone rw = repository.FindById(xId);

				// Edit
				if (col.ToString() == "4")
				{
					frmEditPhone frm = new frmEditPhone();
					frm.TargetPhone = rw;
					frm.ShowDialog();
					this.Hide();
				}
				// Delete
				if (col.ToString() == "5")
				{

					if (MessageBox.Show("Are you sure ?? ", "delete",
					  MessageBoxButtons.OKCancel,
					  MessageBoxIcon.Question,
					  MessageBoxDefaultButton.Button1,
					  MessageBoxOptions.RtlReading |
					  MessageBoxOptions.RightAlign) == System.Windows.Forms.DialogResult.OK)
					{

						repository.Delete(rw.Id);

						frmPhones_Load(sender, e);

						Messages.Save();
					}
				}
			}
		}

	
		private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.ColumnIndex == 4 && e.RowIndex >= 0)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);

				Bitmap img = new Bitmap(AbuEhab.EFSystem.UILayer.Properties.Resources.edit);

				e.Graphics.DrawImage(img, e.CellBounds.Left, e.CellBounds.Top + 10, 20, 20);

				e.Handled = true;
			}

			if (e.ColumnIndex == 5 && e.RowIndex >= 0)
			{
				e.Paint(e.CellBounds, DataGridViewPaintParts.All);

				Bitmap img = new Bitmap(AbuEhab.EFSystem.UILayer.Properties.Resources.delete);

				e.Graphics.DrawImage(img, e.CellBounds.Left, e.CellBounds.Top + 10, 20, 20);

				e.Handled = true;
			}


		}
	}
}
