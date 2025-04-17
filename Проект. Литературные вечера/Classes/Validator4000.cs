using System.Drawing;
using System.Windows.Forms;

public static class FormValidator
{
    public static bool ValidateCurrentForm(Control[] textControls, ComboBox categoryCombo)
    {
        ResetControlStyles(textControls);
        ResetControlStyles(new[] { categoryCombo });

        bool isValid = true;
        bool comboBoxIsEmpty = false;

        foreach (var control in textControls)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                SetInvalidStyle(control);
                isValid = false;
            }
        }

        if (categoryCombo.SelectedItem == null)
        {
            SetInvalidStyle(categoryCombo);
            isValid = false;
            comboBoxIsEmpty = true;
        }

        if (comboBoxIsEmpty)
        {
            MessageBox.Show("Необходимо выбрать категорию!", "Ошибка",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return isValid;
    }

    private static void ResetControlStyles(Control[] controls)
    {
        foreach (var control in controls)
            control.BackColor = SystemColors.Window;
    }

    private static void SetInvalidStyle(Control control)
    {
        control.BackColor = Color.LightPink;
    }
}