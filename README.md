# IEU - Image Enhancing Utility
Windows only GUI for [IEU.Core](https://github.com/ptrsuder/IEU.Core) - "wrapper" around [ESRGAN](https://github.com/xinntao/ESRGAN) with additional features

![downloads_latest](https://img.shields.io/github/downloads/ptrsuder/IEU.Winforms/latest/total.svg?color=blue)
![downloads_total](https://img.shields.io/github/downloads/ptrsuder/IEU.Winforms/total.svg?label=downloads%40total)

Uses [net-vips](https://github.com/kleisauke/net-vips) library to merge splitted tiles after processing them with ESRGAN. Also supports **alpha channels** and **various image formats: .dds (BC1-BC7), .tga etc.**

## List of features
* Split images into tiles before processing them with ESRGAN and merge them afterwards with as little visible seams as possible
* Detect currently available VRAM amount and auto set maximum tile dimensions depending on model upscale factor
* Separate alpha layers from images and process them with the same model as original, with another model or with ImageMagick resize filter
* Separate images into RGB channels
* Process seamless tiled textures while preserving seamlessness
* Ability to process images with multiple models at once with specific output mode (folder per image, folder per model)
* Ability to process images with multiple models one after another ("model chaining")
* Multiple overwrite modes
* Preview feature similiar to Topaz AI Gigapixel one
* UI for quick model interpolation
* Filter images for split/merge with various rules
* Preprocess images (resize, reduce noise)
* Postprocess images  (resize, set black/white treshold)
* And more

## Requirements

* .NET Framework 4.6.1

## How to use
Please read [wiki](https://github.com/ptrsuder/IEU.Winforms/wiki/Basic-usage).
