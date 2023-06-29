using AbuEhab.EFSystem.UILayer.Interfaces;

namespace AbuEhab.EFSystem.UILayer.Services
{
	// @@@@@@@@@@@@@@@@@@
	// Abu Ehab Mizyed
	//@@@@@@@@@@@@@@@@@@@
	internal class Styler : IStyler
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Dgv">DataGridView Name</param>
		public void GridFullStyle(DataGridView Dgv)
		{
			if (Dgv.ColumnCount != 0)
			{

				Dgv.Cursor = Cursors.Hand;
				Dgv.ReadOnly = true;
				Dgv.AllowUserToAddRows = false;

				Dgv.RowsDefaultCellStyle.BackColor = Color.Bisque;
				Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
				Dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

				Dgv.DefaultCellStyle.SelectionBackColor = Color.Blue;
				Dgv.DefaultCellStyle.SelectionForeColor = Color.Yellow;

				Dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
				Dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

				Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				Dgv.AllowUserToResizeColumns = false;
				//=================================================================
				Dgv.RowHeadersWidth = 70;
				Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				Dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				Dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


				foreach (DataGridViewRow R in Dgv.Rows)
				{
					R.HeaderCell.Style.ForeColor = Color.Yellow;
					R.HeaderCell.Style.BackColor = Color.Goldenrod;
					R.Height = 35;
					R.MinimumHeight = 20;
					R.HeaderCell.Value = (R.Index + 1).ToString();
				}
			}
		}
	}
}
