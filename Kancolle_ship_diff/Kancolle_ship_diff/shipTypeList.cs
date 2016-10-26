using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kancolle_ship_diff
{
    class shipTypeList
    {
        // 各艦型の配列

        // 戦艦(Battleship : BB)
        // 高速戦艦(Fast Battleship : FBB)
        // 航空戦艦(Avitation Battleship : BBV)
        public static string[] BattleShipType =
        {
            "扶桑型",
            "伊勢型",
            "金剛型",
            "長門型",
            "大和型",
            "Bismarck級",
            "Queen Elizabeth級",
            "Vittorio Veneto級",
            "Iowa級"
        };

        // 正規空母(Standard Aircraft Carrier : CV)
        // 装甲空母(Armored Aircraft Carrier : CVB)
        public static string[] StandardAircraftCarrierType =
        {
            "赤城型",
            "加賀型",
            "蒼龍型",
            "飛龍型",
            "翔鶴型",
            "大鳳型",
            "雲龍型",
            "Aquila級",
            "Graf Zeppelin級"
        };

        // 軽空母(Light Aircraft Carrier : CVL)
        public static string[] LightAircraftCarrierType =
        {
            "祥鳳型",
            "飛鷹型",
            "龍驤型",
            "鳳翔型",
            "千歳型",
            "龍鳳型"
        };

        // 重巡洋艦(Heavy Cruiser : CA)
        // 航空巡洋艦(Avitation Cruiser : CAV)
        public static string[] HeavyCruiserType =
        {
            "古鷹型",
            "青葉型",
            "妙高型",
            "高雄型",
            "最上型",
            "利根型",
            "Admiral Hipper型",
            "Zara型"
        };

        // 重雷装巡洋艦(Torpedo Cruiser : CLT)
        public static string[] TorpedoCruiserType =
        {
            "球磨型"
        };

        // 軽巡洋艦(Light Cruiser : CL)
        public static string[] LightCruiserType =
        {
            "長良型",
            "球磨型",
            "天竜型",
            "川内型",
            "夕張型",
            "阿賀野型",
            "大淀型"
        };

        // 駆逐艦(Destroyer : DD)
        public static string[] DestroyerType =
        {
            "睦月型",
            "吹雪型",
            "綾波型",
            "陽炎型",
            "暁型",
            "初春型",
            "白露型",
            "朝潮型",
            "島風型",
            "夕雲型",
            "Z1型",
            "秋月型",
            "Maestrale型",
            "神風型"
        };

        // 潜水艦(Submarine : SS)
        // 潜水空母(Submarine Aircraft Carrier : SSV)
        public static string[] SubmarineType =
        {
            "海大Ⅵ型(伊168)",
            "巡潜乙型改二(伊58)",
            "巡潜3型(伊8)",
            "潜特型(伊400型潜水艦)",
            "三式潜航輸送艇(まるゆ)",
            "巡潜乙型(伊19、伊26)",
            "UボートⅨC型(U-511、呂500)"
        };

        // 補給艦(Fleet Oiler : AO)
        public static string[] FleetOilerType =
        {
            "改風早型"
        };

        // 水上機母艦(Seeplane Tender : AV)
        public static string[] SeaplaneTendertype =
        {
            "千歳型",
            "秋津洲型",
            "瑞穂型"
        };
    }
}
