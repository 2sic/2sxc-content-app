# 2sxc-content-bootstrap3
The default "Content" types and templates for bootstrap 3.x

# Note: not officially published yet!

## Todo
* add images showing download dialog to docs
* ensure syncHeightResponsive always works, the current implementation sometimes includes the script, but it's not called, or the  
  anchor for it is a template specific wrapper - i think this should be simpler, like "co-sync-height-container" and "co-sync-height-element" 

## Purpose
Each DNN portal using [2sxc][2sxc] has a section called "Content" which contains the main content-types and main templates. 
This could be initialized manually, but in most cases it's more efficient to install a set of best-practice content-types and templates. To ensure this stuff looks good, these content-types and templates should be optimized to the CSS-framework in use. 

This package **Content-Bootstrap3** is the default configuration package which 2sxc offers for Bootstrap installations. 

## Installation
Whenever you install 2sxc on a DNN portal, or when you create a new portal on a DNN with 2sxc installed, 2sxc will automatitcally ask you if you want to install this. If you need to know more, read about [installations in the wiki](https://github.com/2sic/2sxc-content-bootstrap3/wiki/Installation-Instructions). 

## Skin/Theme Optimizations
We have some optimization recommendations, if you care about this, read about the [optimizations in the wiki](https://github.com/2sic/2sxc-content-bootstrap3/wiki/Theme-Optimizations).

## Customize to your colors and CSS
We've added some [instructions in the wiki](https://github.com/2sic/2sxc-content-bootstrap3/wiki/Customizing%20CSS%20or%20SASS).

## Questions and Support
We from 2sxc use [StackOverflow with the tag 2sxc][StackOverflow] for support. Post your questions there. 



[2sxc]:https://2sxc.org
[StackOverflow]:http://stackoverflow.com/questions/tagged/2sxc
[SCSS]:http://sass-lang.com/