// Webアプリケーションのビルダーを作成します。
var builder = WebApplication.CreateBuilder(args);

// コンテナにサービスを追加します。ここではRazorページのサービスを追加しています。
builder.Services.AddRazorPages();

// ビルダーからWebアプリケーションを構築します。
var app = builder.Build();

// HTTPリクエストパイプラインを構成します。
if (!app.Environment.IsDevelopment())
{
    // 開発環境ではない場合、エラーハンドラーを使用します。
    app.UseExceptionHandler("/Error");
    // HSTSを使用して、HTTPSを強制します。デフォルトのHSTS値は30日です。
    // 本番環境での設定変更については、https://aka.ms/aspnetcore-hsts を参照してください。
    app.UseHsts();
}

// HTTPSリダイレクションを使用します。
app.UseHttpsRedirection();

// 静的ファイルのサービスを使用します（wwwrootフォルダ内のファイル）。
app.UseStaticFiles();

// ルーティングのサービスを使用します。
app.UseRouting();

// 認証のサービスを使用します。認証が必要な場合に設定します。
app.UseAuthorization();

// Razorページへのルーティングをマッピングします。
app.MapRazorPages();

// アプリケーションを実行します。
app.Run();
