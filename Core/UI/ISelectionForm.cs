using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Core.UI
{
    public enum ClassifierListMode
    {
    Edit,
    SingleSelect,
    MultiSelect
    }

    public interface ISelectionForm
    {
        DialogResult ShowDialog();
        object Selection { get;set;}
        ClassifierListMode FormMode {get;set;}
        Queue<KeyValuePair<String,Object>> SearchObjectPropertyPresets { set;}
    }
}
