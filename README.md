# 2sxc-content-bootstrap3
The default "Content" types and templates for bootstrap 3.x

## Purpose
Each DNN portal using [2sxc][2sxc] has a section called "Content" which contains the main content-types and main templates. 
This could be initialized manually, but in most cases it's more efficient to install a set of best-practice content-types and templates. To ensure this stuff looks good, these content-types and templates should be optimized to the CSS-framework in use. 

This package **Content-Bootstrap3** is the default configuration package which 2sxc offers for Bootstrap installations. 

## Installation Instructions
Basically 2sxc will ask the admin when creating a site, if he/she would like to install a default package - and offer this package as an option. That's it :)

## Optimizations
To make installation quick and simple, the default package includes a CSS file to style everything which is not defined by default in Bootstrap 3. 
This only works if the CSS is loaded by the browser, which is why each template file (the _...cshtml Razor files) has a reference to load the CSS files. 

In most cases you will actuall move this CSS file to your skin file, and remove the first line in all the template files using a code editor, quick and simple. 

## Customize to your colors and CSS
To optimize the CSS you can just edit it, or re-generate it using the provided [SCSS][SCSS] file. 

The way we (2sic) do it, is that we have a bootstrap SCSS setup with everything, and the file (included in this package) also uses both the default variables as well as a handfull of custom variables. So we actually put the SCSS for the content-templates into the skin folder and generate everything from there. 

## Questions and Support
We from 2sxc use [StackOverflow with the tag 2sxc][StackOverflow] for support. Post your questions there. 



[2sxc]:https://2sxc.org
[StackOverflow]:http://stackoverflow.com/questions/tagged/2sxc
[SCSS]:http://sass-lang.com/