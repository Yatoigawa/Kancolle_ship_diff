using System;
using System.Windows.Forms;

/// <summary>
/// ヘッダ定義クラス
/// </summary>
public class ColHeader : ColumnHeader
{
    public bool ascending;
    public ColHeader(string text, int width, HorizontalAlignment align, bool asc)
    {
        this.Text = text;
        this.Width = width;
        this.TextAlign = align;
        this.ascending = asc;
    }
}

