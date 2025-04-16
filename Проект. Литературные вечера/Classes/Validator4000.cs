using System;
using System.Drawing;
using System.Windows.Forms;

namespace Проект.Литературные_вечера.Validator4000
{
    /// <summary>
    /// класс для валидации элементов управления форм редактирования и создания событий
    /// </summary>
    public static class FormValidator
    {
        /// <summary>
        /// Проверяет текстовые поля и комбобокс на наличие символов
        /// </summary>
        public static bool ValidateFormFields(Control[] textControls, ComboBox comboBox, string comboBoxError)
        {
            ResetControlStyles(textControls);
            ResetControlStyles(new Control[] { comboBox });

            var isValid = true;

            foreach (var control in textControls)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    SetInvalidStyle(control);
                    isValid = false;
                }
            }

            if (string.IsNullOrWhiteSpace(comboBox.Text))
            {
                SetInvalidStyle(comboBox);
                ShowErrorMessage(comboBoxError);
                isValid = false;
            }

            return isValid;
        }

        private static void ResetControlStyles(Control[] controls)
        {
            foreach (var control in controls)
            {
                control.BackColor = SystemColors.Window;
            }
        }

        private static void SetInvalidStyle(Control control)
        {
            control.BackColor = Color.LightPink;
        }

        private static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}