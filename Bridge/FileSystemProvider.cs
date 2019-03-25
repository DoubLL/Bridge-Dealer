using System.IO;
using System.Windows.Forms;

namespace Bridge
{
    class FileSystemProvider
    {
        public static void Save(string value)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "bdD-File|*.bdD";
            dialog.Title = "Save generated file";
            dialog.ShowDialog();
            if (!string.IsNullOrEmpty(dialog.FileName))
            {
                using (var fs = new StreamWriter(dialog.OpenFile()))
                {
                    fs.WriteLine(value);
                }
            }
        }
    }
}
