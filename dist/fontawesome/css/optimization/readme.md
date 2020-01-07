# FA Remove Brand Icons
This is a PowerShell script which removes the brand-icons from the fontawesome css. To run this you will need the "brand-icons.json" file. This is simply the result of a request from this search tool: https://fontawesome.com/icons?d=gallery.

## How to update

1. In your browser, activate F12
1. Go to this page https://fontawesome.com/icons?d=gallery&s=brands
1. You'll see a request like query?x=algolia... - the body of it should be a json similar to the all-brands.json
1. Copy that whole body into the all-brands.json
1. Re-run the powershell in this folder - you should now get a new fontawesome-nobrands.min.css
1. Copy that file to the folder above this one (in the css folder)

