using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using Newtonsoft.Json;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Deployment.Internal;
using System.Reflection;
namespace Cashalot_Dev
{
    public partial class Form1 : Form
    { 
        private SqlConnection sqlConnection = null;
        private Handler outageSchedule = new Handler();
        public Form1()
        {
            InitializeComponent();
            dataGridViewSql.SelectionChanged += dataGridViewSql_SelectionChanged;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Підєднуємося до БД
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CashalotDB"].ConnectionString);
            sqlConnection.Open();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        outageSchedule.ImportOutageSchedules(openFileDialog.FileName);
                        MessageBox.Show("Дані успішно імпортовано.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        outageSchedule.PopulateDataGridView(dataGridView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка під час імпорту файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnGroupStatus_Click(object sender, EventArgs e)
        {
            txtStatus.Text = outageSchedule.GetCurrentOutages();
            // Викликаємо метод для виділення поточних відключень
            outageSchedule.HighlightCurrentOutagesAll(dataGridView);
        }

        private void btnCurrentGroups_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cmbGroupNum.Text, out int groupNumber))
            {
                txtStatus.Text = outageSchedule.GetGroupStatus(groupNumber);
            }
            else
            {
                MessageBox.Show("Номер групи може бути тільки число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Викликаємо метод для виділення поточних відключень
            outageSchedule.HighlightCurrentOutagesGroup(dataGridView, groupNumber);
        }

        private void btnImportCorrectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        outageSchedule.ImportCorrectionFile(openFileDialog.FileName);
                        MessageBox.Show("Дані успішно скориговано.", "Коригування завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        outageSchedule.UpdateDataGridView(dataGridView);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при імпорті коригуючого файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
 
        private void btnExportJson_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        outageSchedule.ExportToJson(saveFileDialog.FileName);
                        MessageBox.Show("Експорт успішно виконано.", "Експорт завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка при експорті: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            try
            {
                if (sqlConnection == null || sqlConnection.State != ConnectionState.Open)
                {
                    MessageBox.Show("З'єднання з базою даних не встановлено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlFromDb dbSql = new SqlFromDb(sqlConnection);
                DataTable resultTable = dbSql.SelectFromTable(txtSelect.Text);
                dataGridViewSql.DataSource = resultTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Невірний запит: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInsertAddress_Click(object sender, EventArgs e)
        {
            try
            {
                int? groupId = null;
                if (!string.IsNullOrEmpty(txtInsertGroup.Text))
                {
                    if (int.TryParse(txtInsertGroup.Text, out int parsedGroupId))
                    {
                        groupId = parsedGroupId;
                    }
                    else
                    {
                        MessageBox.Show("Неправильний формат групи.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                SqlFromDb dbSql = new SqlFromDb(sqlConnection);
                dbSql.InsertAddress(txtInsertAddres.Text, groupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка придодаванні адреси: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public int Id;
        private void dataGridViewSql_SelectionChanged(object sender, EventArgs e)
        {
            List<string> selectedColumnNames = new List<string>();

            // Перевіряємо наявність рядків
            if (dataGridViewSql.SelectedRows.Count > 0)
            {
                // Отримання виділеного рядка
                DataGridViewRow selectedRow = dataGridViewSql.SelectedRows[0];
                // Потрібно створити список згідно якого ми будемо заповнювати дані для оновлення Адоеси. В нашому випадку ще "Id, Address, GroupId"
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    selectedColumnNames.Add(cell.OwningColumn.Name);
                }
                if (string.Join(", ", selectedColumnNames) == "Id, Address, GroupId")
                {
                    // Отримання даних з клітинок виділеного рядка
                    txtUpdateId.Text = selectedRow.Cells["Id"].Value?.ToString();
                    txtUpdateAddres.Text = selectedRow.Cells["Address"].Value?.ToString();
                    txtUpdateGroup.Text = selectedRow.Cells["GroupId"].Value?.ToString();
                }
            }

        }

        private void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            try
            {
                int? groupId = null;
                if (!string.IsNullOrEmpty(txtUpdateGroup.Text))
                {
                    if (int.TryParse(txtUpdateGroup.Text, out int parsedGroupId))
                    {
                        groupId = parsedGroupId;
                    }
                    else
                    {
                        MessageBox.Show("Неправильний формат групи.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                SqlFromDb dbSql = new SqlFromDb(sqlConnection);
                dbSql.UpdateAddress(txtUpdateId.Text, txtUpdateAddres.Text, groupId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка придодаванні адреси: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}