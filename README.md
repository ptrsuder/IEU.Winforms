# IEU - Image Enhancing Utility
Windows only GUI for [IEU.Core](https://github.com/ptrsuder/IEU.Core) - wrapper around [ESRGAN](https://github.com/xinntao/ESRGAN) with additional features

![downloads_latest](https://img.shields.io/github/downloads/ptrsuder/IEU.Winforms/latest/total.svg?color=magenta)
![downloads_total](https://img.shields.io/github/downloads/ptrsuder/IEU.Winforms/total.svg?label=downloads%40total)

Uses [net-vips](https://github.com/kleisauke/net-vips) library to split input images into tiles and then merge them after processing tiles with ESRGAN. Also supports **alpha channels** and **various image formats (.dds, .tga etc).**

Please, before using this tool ensure that you installed all python dependencies correctly and ESRGAN is working on it's own.

## Full list of features
* Split images into tiles before processing them with ESRGAN and merge them afterwards with as little visible seams as possible
* Separate alpha layers from images and process them with the same model as original, or with another model
* Separate images into RGB channels
* Process seamless tiled textures while preserving seamlessness
* Ability to process images with multiple models at once with specific output mode (folder per image, folder per model)
* Few overwrite modes
* Preview feature similiar to Topaz AI Gigapixel one
* UI for quick model interpolation
* Filter images for split/merge with various rules
* Preprocess images (resize, reduce noise)
* Postprocess images  (resize, set black/white treshold)
* Set image format for results

## Requirements

* .NET Framework 4.6.1
* [ESRGAN](https://github.com/xinntao/ESRGAN/archive/old-arch.zip) (<-- yes, from this link)
* [BasicSR](https://github.com/victorca25/BasicSR) if you wish to use it instead of ESRGAN

## How to use
Please read [wiki](https://github.com/ptrsuder/IEU.Winforms/wiki/Basic-usage).

  
