#�t�@�C���p�X���w��
$strPath = 'C:\Users\Administrator\OneDrive\source\repos\oiconlib\oiconlib\wwwroot\icons\emoji\*';
Write-Host $strPath

#�g���qpdf�̃t�@�C���݂̂��擾
#$fileLst = Get-ChildItem $strPath -Filter *.png -Recurse;
$fileLst = Get-ChildItem $strPath -Include ('*.png', '*.svg', '*.json') -Recurse;

#foreach���Ńt�@�C�����X�g���i�荞��
foreach($str in $fileLst){

    if(!$str.PSIsContainer){
        Write-Output ($str.FullName);
    }
}
