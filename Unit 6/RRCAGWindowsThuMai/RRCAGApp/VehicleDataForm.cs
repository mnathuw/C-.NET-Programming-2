using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RRCAGApp
{
    public partial class VehicleDataForm : Form
    {
        private OleDbDataAdapter dataAdapter;
        private BindingSource bindingSource;
        private DataSet dataSet;

        public VehicleDataForm()
        {
            InitializeComponent();
            InitialStatesForm();
        }

        private void InitialStatesForm()
        {

            mnuFileSave.Enabled = false;
            mnuEditDelete.Enabled = false;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void VehicleDataForm_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection();

                connection.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" +
                    "Data Source = AMDatabase.mdb";
                connection.Open();

                OleDbCommand _command = new OleDbCommand();
                _command.CommandText = "SELECT * FROM VehicleStock;";
                _command.Connection = connection;

                dataAdapter = new OleDbDataAdapter();
                dataAdapter.SelectCommand = _command;

                dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                bindingSource = new BindingSource();

                OleDbCommandBuilder _commandBuilder = new OleDbCommandBuilder(dataAdapter);

                dataAdapter.UpdateCommand = _commandBuilder.GetUpdateCommand();
                dataAdapter.InsertCommand = _commandBuilder.GetInsertCommand();
                dataAdapter.DeleteCommand = _commandBuilder.GetDeleteCommand();

                bindingSource.DataSource = dataSet.Tables[0];
                dgvVehicleData.DataSource = bindingSource;

                dgvVehicleData.Columns["ID"].Visible = false;

                // Disable functions
                dgvVehicleData.AllowUserToDeleteRows = false;
                dgvVehicleData.AllowUserToResizeRows = false;
                dgvVehicleData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvVehicleData.MultiSelect = false;
            }
            catch
            {
                MessageBox.Show("Unable to load vehicle data.",
                    "Data Load Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();
            }
        }


        private void dgvVehicleData_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVehicleData.SelectedRows.Count != 0)
            {
                if (!dgvVehicleData.SelectedRows[0].IsNewRow)
                {
                    mnuEditDelete.Enabled = true;
                    dgvVehicleData.AllowUserToDeleteRows = true;
                }
            }
        }

        private void dgvVehicleData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bindingSource.EndEdit();
            this.Text = "* Vehicle Data";
            mnuFileSave.Enabled = true;
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to permanently delete stock item?",
                    "Delete Stock Item",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    int rowIndex = dgvVehicleData.CurrentCell.RowIndex;
                    dgvVehicleData.Rows.RemoveAt(rowIndex);
                    dataAdapter.Update(dataSet.Tables[0]);
                    bindingSource.EndEdit();
                    mnuEditDelete.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("An error occurred while deleting the selected vehicle.",
                        "Deletion Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(dataSet.Tables[0]);
                bindingSource.EndEdit();
                this.Text = "Vehicle Data";
                mnuFileSave.Enabled = false;
            }
            catch
            {
                MessageBox.Show("An error occurred while saving the changes to the vehicle data.",
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Do you wish to save the changes?",
                        "Yes",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button3))
            {
                case DialogResult.Yes:
                    try
                    {
                        dataAdapter.Update(dataSet.Tables[0]);
                        bindingSource.EndEdit();
                        this.Close();
                    }
                    catch
                    {
                        if (MessageBox.Show("An error occurred while saving the changes. Do you still wish to close this window?",
                                "Save Error",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                    break;

                case DialogResult.No:
                    this.Close();
                    break;

                case DialogResult.Cancel:
                    break;
            }
        }
    }
}
