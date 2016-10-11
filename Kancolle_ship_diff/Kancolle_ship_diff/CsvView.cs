using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Text;

public class CsvView : ListView
{
	public CsvView()
	{
        ArrayList list = new ArrayList();
        /// <summary>
        /// CSVファイルからの読み込み
        /// </summary>
        StreamReader srInf = new StreamReader(@"ship_data.csv", Encoding.Default);

        while (srInf.Peek() >= 0)
        {
            list.Add(srInf.ReadLine().Split(','));
        }

        srInf.Close();

        string[][] data = (string[][])list.ToArray(typeof(string[]));

        for (int k = 0; k < data[0].Length; k++)
        {
            this.Columns.Add(new ColHeader(data[0][k], 60, HorizontalAlignment.Left, true));
        }
        for (int i = 1; i < data.Length; i++)
        {
            this.Items.Add(new ListViewItem(data[i]));
        }
    }
}
