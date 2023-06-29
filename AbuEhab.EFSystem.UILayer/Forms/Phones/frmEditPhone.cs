using AbuEhab.EFSystem.DataLayer.Entities;
using AbuEhab.EFSystem.DataLayer.Repositories;
using AbuEhab.EFSystem.UILayer.Interfaces;
using AbuEhab.EFSystem.UILayer.Services;

namespace AbuEhab.EFSystem.UILayer.Forms.Phones
{
	public partial class frmEditPhone : Form
	{
		public frmEditPhone()
		{
			InitializeComponent();
		}

		public Phone TargetPhone { get; set; }
		private IRepository<Phone> repository = new Repository<Phone>();
		private IHelper helper = new Helper();
		private void frmEditPhone_Load(object sender, EventArgs e)
		{
			this.txtName.Text = this.TargetPhone.Name.ToString();
			this.txtJawwal.Text = this.TargetPhone.Jawwal.ToString();
			this.txtOoredoo.Text = this.TargetPhone.Ooredoo.ToString();
		}

		private void btnOkay_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				txtName.Focus();
				return;
			}
			var phone = this.repository.FindById(this.TargetPhone.Id);

			phone.Name = txtName.Text;
			phone.Jawwal = txtJawwal.Text;
			phone.Ooredoo = txtOoredoo.Text;


			this.repository.Update(this.TargetPhone.Id);
			this.TargetPhone = phone;
			frmPhones frm = new frmPhones();
			frm.Show();
			this.Hide();
		}
		#region  "  Events  "
		private void txtJawwal_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtJawwal.Text)) { txtJawwal.Text = "0"; txtJawwal.SelectAll(); }
		}

		private void txtOoredoo_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtOoredoo.Text)) { txtOoredoo.Text = "0"; txtOoredoo.SelectAll(); }
		}


		private void txtJawwal_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.helper.TextKeyPress(this.txtJawwal, sender, e);
		}

		private void txtOoredoo_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.helper.TextKeyPress(this.txtOoredoo, sender, e);
		}


		#endregion
	}
}
