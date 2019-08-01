# IEU - Image Enhancing Utility
Windows only GUI for [IEU.Core](https://github.com/ptrsuder/IEU.Core) - wrapper around ESRGAN with additional features

![downloads_latest](https://img.shields.io/github/downloads/ptrsuder/IEU.Winforms/latest/total.svg?color=magenta)
![downloads_total](https://img.shields.io/github/downloads/ptrsuder/IEU.Winforms/total.svg?label=downloads%40total)

Uses [net-vips](https://github.com/kleisauke/net-vips) library to split input images into tiles and then merge them after processing tiles with ESRGAN. Also supports **alpha channels** and **various image formats (.dds, .tga etc).**

Although app can detect model upscale size by running python script, it takes some time, so it is recommended to **rename all your models so that filenames contain upscale size as in screenshot below**.

Please, before using this tool ensure that you installed all python dependencies correctly and ESRGAN is working on it's own.

## Requirements

* .NET Framework 4.6.1
* [ESRGAN](https://github.com/xinntao/ESRGAN/tree/aceb85730832001ec1fa3a77bd6856b75e1d0e87) (old version only)

## Usage

On first launch specify ESRGAN main directory path in Settings tab.
You can also specify folders for input and output images. By default it will be *"esrgan-path/img"* and *"esrgan-path/merged_results

**Take your images and put them in *"esrgan-path/img"*.** You can do this manually or by drag'n'droping files/folders to application form.
When ready click [SPLIT] button. Tiles will be created from input images in *"esrgan-path/LR"* directory. Tile resolution will be calculated from *MaxTileResolution* value (biggest possible). Each time old tiles will be deleted from folder.
 **You always need to run [SPLIT] before ESRGAN, because it will convert images to png, put them in LR folder, separate alpha channels etc.**
 
Check one or more models from the tree view, select preferred output mode (only two last modes are available if more than single model is selected).
Click [RUN ESRGAN] button to start ESRGAN script. 

When ESRGAN is finished, results will be in *"results-path"* folder, *"results-path/models"* or *"results-path/images"* folders, depending on which output mode you selected earlier.

To merge resulted tiles back click [MERGE] button.

**Notice: Don't delete images from input directory before you finished working with them.**

## Settings


 ### Maximum tile resolution
 MaxTileResolution = TileWidth x TileHeight
 Currently, to find out how big MaxTileResolution you VGRAM can handle you need to experiment. Default value is for 2Gb VGRAM.
 ### Tiles overlap
 When creating tiles, they will be overlapping between themselves by size in pixels specified by this value. The bigger value - more time to process tiles with ESRGAN. Improvement from setting this bigger than 16 is questionable.
 ### Output format
 Image format in which images will be written to disk on merge. If you check "Use original image format", output format will be the same as original image, but some setting (like compression factor, method) will be taken from Output format tab.
 
  ### Ignore alpha channel
 If checked, all alpha channels will be ignored during tiles creation and merge.
 ### Use different model for alpha
 If checked, selected model will be applied to all alphas when running ESRGAN.
 ### Split RGB channels
 If checked, images will be split into red, green and blue channels, so that ESRGAN will process each channel as separate image. Channels will be combined back in single image on merge, if this setting is enabled.
 ### Split RGB channels
 If checked, will treat all images as tiles textures and extend them over edges on Split and crop them back on Merge. This way textures will remain seamless after upscale.

 ### Create max resolution tile in input folder
 Creates blank black image with max TileWith and TileHeight. It's might be needed because if ESRGAN starts with small image and then tries to process bigger image it can run in out of memory error. 
 ### Delete results after merging
 Deletes all of merged tiles in result folder after successfully merging image .
 
## Advanced
  
 ### Use suffix
 Useful when you are using tool other than ESRGAN and your processed image results have some suffix. Just check this option and write suffix in textbox before merging tiles.
 ### Filters
 Use various filters if you want to work only with particular images from input folder. For example you might crop/merge only images with "(wood)" in filename. Or you want to merge images without alpha as .png and the rest - as .tga etc. </br>
 **Filters work only when cropping and merging! ESRGAN still process all files from LR directory.**
  
## Output modes
  ### Default  
  * **Results**: *esrgan-path/results*
  * **Merged results**: *merged-results-path/*
  
  ### Folder for each image  
  * **Results**: *results-path/images/image-name/*
  * **Merged results**: *merged-results-path/images/image-name/merged*
  
  ### Folder for each model  
  * **Results**: *results-path/models/model-name/*
  * **Merged results**: *merged-results-path/models/model-name/merged*
  
  
