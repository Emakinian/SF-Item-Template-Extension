using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SitefinityWidgetWizard.Properties;

namespace SitefinityWidgetWizard
{
    public partial class Form1 : Form
    {
        public List<ModelItem> ModelItems = new List<ModelItem>();
        public Form1()
        {
            InitializeComponent();
            modelFieldsGridView.AutoGenerateColumns = false;
            propertyTypeCombobox.SelectedIndex = 0;
        }

        private void addNewFieldButton_Click(object sender, EventArgs e)
        {
            if (!ValidatePropertyName())
            {
                MessageBox.Show(Resources.PropertyNameRequired);
                return;
            }
            var newItem = new ModelItem
            {
                IsRequired = isRequiredCheckbox.Checked.ToString(),
                PropertyName = propertyNameTextbox.Text.CapitalizeFirstCharacter().Replace(" ", ""),
                PropertyType = propertyTypeCombobox.Text
            };
            ModelItems.Add(newItem);
            modelFieldsGridView.Rows.Add(newItem.PropertyName, newItem.PropertyType, newItem.IsRequired);
            CleanFields();
        }

        private void CleanFields()
        {
            propertyNameTextbox.Text = "";
            isRequiredCheckbox.Checked = false;
        }

        private bool ValidatePropertyName()
        {
            return !string.IsNullOrEmpty(propertyNameTextbox.Text);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (modelFieldsGridView.SelectedCells.Count == 0) return;
            var selectedCell = modelFieldsGridView.SelectedCells[0];
            var selectedIndex = selectedCell.RowIndex;

            if (selectedIndex > ModelItems.Count - 1) return;
            ModelItems.RemoveAt(selectedIndex);
            modelFieldsGridView.Rows.RemoveAt(selectedIndex);
        }

        private void createButton_Click(object sender, EventArgs e)
        {

        }
    }
}
