using BitflyerApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitflyerBotSample
{
    class Program
    {
        static BitflyerClient client;

        static void Main(string[] args)
        {
            // 通信用クライアント生成
            client = new BitflyerClient(
                "xxxxxxx", // ※実際の API Key に差し替えること
                "xxxxxxx", // ※実際の API Secret に差し替えること
                ProductCode.FX_BTC_JPY // 今回は BTC-FX を選択
            );

            // 非同期なタスクを生成
            Task.Run(async () =>
            {
                try
                {
                    await BotLogic();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }).Wait(); // タスクが終わるまで待つ
        }

        static async Task BotLogic()
        {
            // 5秒毎にランダムに買い注文、売り注文を出し続ける
            Random r = new Random();
            while (true)
            {
                // 2分の1の確率で買い注文または売り注文
                if (r.Next() % 2 == 0)
                {
                    Console.WriteLine("buy");
                    await client.Buy(0.001); // 成行で 0.001BTC 買い注文
                }
                else
                {
                    Console.WriteLine("sell");
                    await client.Sell(0.001); // 成行で 0.001BTC 売り注文
                }

                // 5秒待機
                Console.WriteLine("wait");
                await Task.Delay(5000);
            }
        }
    }
}
