$json = ConvertFrom-Json -InputObject (Get-Content -Path "brand-icons.json")
$baseCss = Get-Content -Path "all.min.css" # [System.IO.File]::ReadAllText("all.min.css")

foreach($hit in $json.hits) {
    $name = $hit.name
    $regex = [regex] "(?is)\.fa-$($name):before[ ]*\{[^}]*\}[ \r\n]*"
    $baseCss = $baseCss -replace $regex,""
    
}

Set-Content -Path "fontawesome-nobrands.min.css" -Value $baseCss
# [System.IO.File]::WriteAllText("fontawesome-nobrands.min.css", $baseCss)