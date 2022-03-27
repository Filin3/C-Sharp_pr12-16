using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr12
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }
        private void Cancel()
        {
            MessageBox.Show("Cancel");
        }

        private void Create()
        {
            MessageBox.Show("Create");
        }

        private void Edit()
        {
            MessageBox.Show("Edit");
        }

        private void Save()
        {
            MessageBox.Show("Save");
        }

        private void Delete()
        {
            DialogResult result = MessageBox.Show(
                    "Удалить данные\nпосотруднику?", 
                    "Предупреждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Удаление данных");
            } else if (result == DialogResult.No)
            {
                MessageBox.Show("Отмена удаления");
            }
        }

        private void cancelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayForm(true);
            Cancel();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayForm(false);
            Create();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(false);
            Edit();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayForm(true);
            Save();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayForm(true);
            Delete();
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            DisplayForm(true);
            Cancel();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            DisplayForm(false);
            Create();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            DisplayForm(false);
            Edit();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            DisplayForm(true);
            Save();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            DisplayForm(true);
            Delete();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(true);
            Cancel();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(false);
            Create();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayForm(false);
            Edit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(true);
            Save();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm(true);
            Delete();
        }

        private void actionToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Выбор действий по сотрудникам";
        }

        private void actionToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void cancelToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Выбор действия отменить";
        }

        private void cancelToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void createToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Выбор действия создать";
        }

        private void createToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void editToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Выбор действия редактировать";
        }

        private void editToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void saveToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Выбор действия сохранить";
        }

        private void saveToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void deleteToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Выбор действия удалить";
        }

        private void deleteToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void reportToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Выбор действий по отчётам";
        }

        private void reportToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void byEmployeeToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Выбор действия по сотруднику";
        }

        private void byEmployeeToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }

        private void byAllEmployeeToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "Выбор действия по всем сотрудникам";
        }

        private void byAllEmployeeToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelEmployee.Text = "";
        }
        
        public void DisplayReadOnly(bool isReadOnly)
        {
            if (isReadOnly == true)
            {
                this.textBoxSurname.ReadOnly = true;
                this.textBoxName.ReadOnly = true;
                this.textBoxPatronymic.ReadOnly = true;
                this.textBoxNetName.ReadOnly = true;
                this.comboBoxJobRole.Enabled = false;
                this.comboBoxStatus.Enabled = false;
                this.comboBoxAccess.Enabled = false;
            } else
            {
                this.textBoxSurname.ReadOnly = false;
                this.textBoxName.ReadOnly = false;
                this.textBoxPatronymic.ReadOnly = false;
                this.textBoxNetName.ReadOnly = false;
                this.comboBoxJobRole.Enabled = true;
                this.comboBoxStatus.Enabled = true;
                this.comboBoxAccess.Enabled = true;
            }
        }

        private void MenuItemEnabled(bool itemEnabled)
        {
            if (itemEnabled == true)
            {
                this.editToolStripMenuItem1.Enabled = true;
                this.deleteToolStripMenuItem1.Enabled = true;
                this.createToolStripMenuItem1.Enabled = true;
                this.cancelToolStripMenuItem1.Enabled = false;
                this.saveToolStripMenuItem1.Enabled = false;
            } else
            {
                this.editToolStripMenuItem1.Enabled = false;
                this.deleteToolStripMenuItem1.Enabled = false;
                this.createToolStripMenuItem1.Enabled = false;
                this.cancelToolStripMenuItem1.Enabled = true;
                this.saveToolStripMenuItem1.Enabled = true;
            }
        }

        private void MenuItemContextEnabled(bool itemEnabled)
        {
            if (itemEnabled == true)
            {
                this.editToolStripMenuItem.Enabled = true;
                this.deleteToolStripMenuItem.Enabled = true;
                this.createToolStripMenuItem.Enabled = true;
                this.cancelToolStripMenuItem.Enabled = false;
                this.saveToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.editToolStripMenuItem.Enabled = false;
                this.deleteToolStripMenuItem.Enabled = false;
                this.createToolStripMenuItem.Enabled = false;
                this.cancelToolStripMenuItem.Enabled = true;
                this.saveToolStripMenuItem.Enabled = true;
            }
        }

        private void StripButtonEnabled(bool itemEnabled)
        {
            if (itemEnabled == true)
            {
                this.toolStripButtonEdit.Enabled = true;
                this.toolStripButtonRemove.Enabled = true;
                this.toolStripButtonNew.Enabled = true;
                this.toolStripButtonUndo.Enabled = false;
                this.toolStripButtonSave.Enabled = false;
            }
            else
            {
                this.toolStripButtonEdit.Enabled = false;
                this.toolStripButtonRemove.Enabled = false;
                this.toolStripButtonNew.Enabled = false;
                this.toolStripButtonUndo.Enabled = true;
                this.toolStripButtonSave.Enabled = true;
            }
        }

        private void DisplayForm(bool mode)
        {
            DisplayReadOnly(mode);
            MenuItemEnabled(mode);
            MenuItemContextEnabled(mode);
            StripButtonEnabled(mode);
        }


        private void FormEmployee_Load(object sender, EventArgs e)
        {
            DisplayForm(true);
        }
    }
}
