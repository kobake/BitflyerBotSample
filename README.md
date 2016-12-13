# BitflyerBotSample
bitFlyer 自動売買システムのサンプル

## 利用パッケージ
- [NuGet Gallery | BitflyerApi](https://www.nuget.org/packages/BitflyerApi)

## APIキーについて
プロジェクト実行の際には https://lightning.bitflyer.jp/developer で API Key, API Secret を取得し、以下の ```xxxxxxx``` の部分に文字列を埋め込んでください。

```cs
client = new BitflyerClient(
    "xxxxxxx", // ※実際の API Key に差し替えること
    "xxxxxxx", // ※実際の API Secret に差し替えること
    ProductCode.FX_BTC_JPY // 今回は BTC-FX を選択
);
```

## ご注意
あくまでも「こういう自動化もできるよ」というサンプルに過ぎません。ぶっちゃけこれをそのまま運用したらたぶん損します。

ちゃんと儲かる仕組みはご自身でよく考えて組み立ててみてください。
