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
            var comboBoxIsEmpty = false;

            foreach (var control in textControls)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    SetInvalidStyle(control);
                    isValid = false;
                }
            }

            if (comboBox.SelectedItem == null)
            {
                SetInvalidStyle(comboBox);
                isValid = false;
                comboBoxIsEmpty = true;
            }

            if (comboBoxIsEmpty)
            {
                MessageBox.Show(comboBoxError, "Ошибка",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            return isValid;
        }

        public static void ResetControlStyles(Control[] controls)
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

        
    }
}