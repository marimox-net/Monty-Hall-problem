using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Monty_Hall_problem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private int TotalLottery;
        private int TotalHitCnt;
        private int RemoveHitCnt;
        private int RemoveMissCnt;
        private int RunCnt;

        static System.Random r = new System.Random();

        private void TextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) 
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b') e.Handled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtinitialize();
        }

        private void txtinitialize()
        {
            txtHit.Text = "1";
            txtMiss.Text = "2";
            txtHitRemove.Text = "0";
            txtMissRemove.Text = "1";
            txtRunCnt.Text = "100";
        }
        
        private void GetPlayData()
        {
            TotalHitCnt = int.Parse(txtHit.Text);
            TotalLottery = TotalHitCnt + int.Parse(txtMiss.Text);
            RemoveHitCnt = int.Parse(txtHitRemove.Text);
            RemoveMissCnt = int.Parse(txtMissRemove.Text);
            RunCnt = int.Parse(txtRunCnt.Text);
        }

        public static void SetProgressBarValue(ProgressBar pb, int val)
        {
            if (pb.Value < val)
            {
                //値を増やす時
                if (val < pb.Maximum)
                {
                    //目的の値より一つ大きくしてから、目的の値にする
                    pb.Value = val + 1;
                    pb.Value = val;
                }
                else
                {
                    //最大値にする時
                    //最大値を1つ増やしてから、元に戻す
                    pb.Maximum++;
                    pb.Value = val + 1;
                    pb.Value = val;
                    pb.Maximum--;
                }
            }
            else
            {
                //値を減らす時は、そのまま
                pb.Value = val;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            int u;
            int Hit = 0;
            int Miss = 0;
            int progress = 0;
            int hisprogress = 0;

            var sw = new System.Diagnostics.Stopwatch();

            sw.Start();

            //ボタン押下不可に設定
            btnRun.Text = "実行中";
            btnRun.Enabled = false;

            gb3.Text = "処理進捗";

            SetProgressBarValue(progressBar, progress);

            //画面上の値を読み取る
            GetPlayData();
            
            //処理
            for (u = 0; u < RunCnt; u++)
            {
                if (Monty()) Hit++;
                else Miss++;

                //プログレスバーの更新(めもりは100)
                progress = (int)((u + 1f) / RunCnt * 100f);
                if (progress != hisprogress)
                {
                    SetProgressBarValue(progressBar, progress);
                    hisprogress = progress;
                }
            }

            if ( RunCnt != 1)
                CreateChart(Hit, Miss);

            //ボタン押下可能に設定
            btnRun.Text = "実行";
            btnRun.Enabled = true;

            sw.Stop();
            gb3.Text = $"処理時間：{sw.Elapsed.Hours}時間 {sw.Elapsed.Minutes}分 {sw.Elapsed.Seconds}秒 {sw.Elapsed.Milliseconds}ミリ秒";
        }

        private void CreateChart(int Hit, int Miss)
        {
            // フォームをロードするときの処理
            chart1.Series.Clear();  // ← 最初からSeriesが1つあるのでクリアします
            chart1.ChartAreas.Clear();

            // ChartにChartAreaを追加します
            string chart_area1 = "Area1";
            chart1.ChartAreas.Add(new ChartArea(chart_area1));
            // ChartにSeriesを追加します
            string legend1 = "Graph1";
            chart1.Series.Add(legend1);
            // グラフの種別を指定
            chart1.Series[legend1].ChartType = SeriesChartType.Pie; // 円グラフを指定してみます

            double[] values = new double[2] { Hit , Miss };

            // 各項目の値を加算して合計(全体の大きさ)を算出します
            double total = 0.0;
            foreach (double d in values)
            {
                total += d;
            }
            // データをシリーズにセットします
            for (int i = 0; i < values.Length; i++)
            {
                double rate = (values[i] / total) * 100.0;  // <-- ここで割合を算出します
                DataPoint dp = new DataPoint(rate, rate);
                dp.AxisLabel = rate.ToString() + "%";
                chart1.Series[legend1].Points.Add(dp);
            }
            chart1.Series[legend1].Points[0].AxisLabel = "あたり\n" + chart1.Series[legend1].Points[0].AxisLabel;
            chart1.Series[legend1].Points[1].AxisLabel = "はずれ\n" + chart1.Series[legend1].Points[1].AxisLabel;
        }

        private bool Monty()
        {
            int i, n, select;
            bool[] data = new bool[0];
            bool[] removedata = new bool[0];

            //あたり + はずれの分、配列を用意する
            Array.Resize(ref data, TotalLottery);
            Array.Resize(ref removedata, TotalLottery);

            //あたりの設定
            i = 0;
            while(i < TotalHitCnt)
            {
                n = r.Next(0, TotalLottery);

                if (!data[n]) data[n] = true;
                else continue;
                i++;
            }

            //プレイヤーの選択
            select = r.Next(0, TotalLottery);

            //選択以外のあたり／はずれを取り除く数分除去
            i = 0;
            //あたりを除去する
            while (i < RemoveHitCnt)
            {
                //乱数取得
                n = r.Next(0, TotalLottery);

                //プレイヤーが選択したものであれば飛ばす
                if (n == select) continue;

                //あたりかつまだ除去されていない場合除去
                if (data[n] && !removedata[n])
                {
                    removedata[n] = true;
                    i++;
                }
            }

            //はずれを除去する
            i = 0;
            while (i < RemoveMissCnt)
            {
                //乱数取得
                n = r.Next(0, TotalLottery);

                //プレイヤーが選択したものであれば飛ばす
                if (n == select) continue;

                //あたりかつまだ除去されていない場合除去
                if (!data[n] && !removedata[n])
                {
                    removedata[n] = true;
                    i++;
                }
            }

            if(chcSelect.Checked)
            {
                //選択を変える場合
                while(true)
                {
                    //乱数取得
                    n = r.Next(0, TotalLottery);
                    //すでに選択している場合、飛ばす
                    if (n == select) continue;
                    //除去済の場合、飛ばす
                    if (removedata[n]) continue;
                    //プレイヤーの選択(変更後)
                    select = n;
                    break;
                }
            }
            //結果を返す
            return data[select];
        }
    }
}
