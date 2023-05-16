#ファイルパスを指定
$strPath = 'C:\Users\Administrator\OneDrive\source\repos\oiconlib\oiconlib\wwwroot\icons\emoji\*';
Write-Host $strPath

#拡張子pdfのファイルのみを取得
#$fileLst = Get-ChildItem $strPath -Filter *.png -Recurse;
$fileLst = Get-ChildItem $strPath -Include ('*.png', '*.svg', '*.json') -Recurse;

#foreach文でファイルリストを絞り込み
foreach($str in $fileLst){

    if(!$str.PSIsContainer){
        Write-Output ($str.FullName);
    }
}
