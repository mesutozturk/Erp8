namespace AracTakip.Helpers;

public static class FormExtension //sınıf tanımı da statik olmalı
{
    //Extansin method
    //Statik olarak tanımlanmaktadır. 
    public static void FormCleaner(this Form form, Control.ControlCollection container) //this ifadesinden sonra yazılan nesneye extend edilecektir. 
    {
        foreach (Control item in container)
        {
            if (item is TextBox)
                item.Text = string.Empty;
            else if (item is ComboBox cmb)
                cmb.SelectedIndex = 0;
            else if (item is NumericUpDown nud)
                nud.Value = 0;
            else if (item is DateTimePicker dtp)
                dtp.Value = DateTime.Now;
            else if (item is CheckBox chk)
                chk.Checked = false;
            else if (item is RadioButton rdb)
                rdb.Checked = false;
            else if (item is PictureBox pic)
                pic.Image = null;
            else if(item is GroupBox gbox)
                FormCleaner(form, gbox.Controls);
            else if (item is Panel pnl)
                FormCleaner(form, pnl.Controls);
        }
    }
}