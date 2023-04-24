# Misq
Misq is an official .NET Misskey library.

## Install
available on nuget

## Usage

``` Csharp
// Create your app instance
var app = new Misq.App("https://misskey.io", "your app's secret key here");

// Authorize user
var user = await app.Authorize();

// Let's post a message to Misskey
user.Request("notes/create", new Dictionary<string, object> {
  { "text", "yee haw!" }
});
```
※ XP用作ってみたはいいけど、 await が .Net frame work 4.0 で外部ライブラリ経由だと使えない疑惑が出てきた。
