using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kancolle_ship_diff
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 艦種リスト用の文字列配列
            string[] shipClassList =
            {
                "戦艦/航空戦艦",
                "正規空母/装甲空母",
                "軽空母",
                "重巡洋艦/航空巡洋艦",
                "重雷装巡洋艦",
                "軽巡洋艦",
                "駆逐艦",
                "潜水艦/潜水空母",
                "補給艦",
                "水上機母艦",
                "揚陸艦",
                "工作艦",
                "潜水母艦",
                "練習巡洋艦"
            };

            // 列の追加
            shipClassListView.Columns.Add("艦種", -2, HorizontalAlignment.Left);
            shipTypeListView.Columns.Add("艦型", -2, HorizontalAlignment.Left);

            // 項目の追加
            for (int i = 0; i < shipClassList.Length; i++)
            {
                ListViewItem item_shipClassList = new ListViewItem();

                item_shipClassList.Text = shipClassList[i];
                shipClassListView.Items.Add(item_shipClassList);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // 入力データ等の保存処理

            // OKボタンが押された
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            // ShowDialog()による表示のため閉じる必要がある

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // キャンセルボタンが押された
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // ShowDialog()による表示のため閉じる必要がある
            this.Close();
        }

        /// <summary>
        /// 選択されている項目が変更された場合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shipTypeClassView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idx;
            if (shipClassListView.SelectedItems.Count > 0) {
                // 選択されている項目の文字列を取得
                idx = shipClassListView.SelectedItems[0].Text;

                // 現在表示されているリストビューの項目の総数を取得
                int shipTypeList_max = shipTypeListView.Items.Count;

                // アイテム削除前にデータを格納


                // 現在のアイテムを削除
                shipTypeListView.Items.Clear();
                /*
                for (int i = 0; i < shipTypeList_max; i++)
                {
                    ListViewItem item_shipClassList = new ListViewItem();
                    shipTypeListView.Items.Remove(item_shipClassList);
                }
                */

                // 選択された項目についてリストビューアイテムを追加
                switch (idx) {
                    case "戦艦/航空戦艦" :
                        SelectedShipTypeToListView(shipTypeList.BattleShipType);
                        break;

                    case "正規空母/装甲空母" :
                        SelectedShipTypeToListView(shipTypeList.StandardAircraftCarrierType);
                        break;

                    case "軽空母" :
                        SelectedShipTypeToListView(shipTypeList.LightAircraftCarrierType);
                        break;

                    case "重巡洋艦/航空巡洋艦":
                        SelectedShipTypeToListView(shipTypeList.HeavyCruiserType);
                        break;

                    case "重雷装巡洋艦":
                        SelectedShipTypeToListView(shipTypeList.TorpedoCruiserType);
                        break;

                    case "軽巡洋艦":
                        SelectedShipTypeToListView(shipTypeList.LightCruiserType);
                        break;

                    case "駆逐艦":
                        SelectedShipTypeToListView(shipTypeList.DestroyerType);
                        break;

                    case "潜水艦/潜水空母":
                        SelectedShipTypeToListView(shipTypeList.SubmarineType);
                        break;

                    case "補給艦":
                        SelectedShipTypeToListView(shipTypeList.FleetOilerType);
                        break;

                    case "水上機母艦":
                        SelectedShipTypeToListView(shipTypeList.SeaplaneTenderType);
                        break;

                    case "揚陸艦":
                        SelectedShipTypeToListView(shipTypeList.AmphibiousAssultShipType);
                        break;

                    case "工作艦":
                        SelectedShipTypeToListView(shipTypeList.RepairShipType);
                        break;

                    case "潜水母艦":
                        SelectedShipTypeToListView(shipTypeList.SubmarineTenderType);
                        break;

                    case "練習巡洋艦":
                        SelectedShipTypeToListView(shipTypeList.TrainingCruiserType);
                        break;

                    default:
                        break;
                }
            }
        }



        private void SelectedShipTypeSave(string shipClass, string[] shipTypeData)
        {
            switch (shipClass)
            {
                case "戦艦/航空戦艦":
                    for (int i = 0; i < shipTypeList.BattleShipType.Length; i++)
                    {

                    }
                    break;
                default:
                    break;
            }
        }

        private void SelectedShipTypeToListView(string[] TypeList)
        {
            for (int i = 0; i < TypeList.Length; i++)
            {
                ListViewItem item_shipTypeList = new ListViewItem();

                item_shipTypeList.Text = TypeList[i];
                shipTypeListView.Items.Add(item_shipTypeList);
            }
        }
    }
}
