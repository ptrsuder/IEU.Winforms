# IEU - Image Enhancing Utility
Windows only GUI for [IEU.Core](https://github.com/ptrsuder/IEU.Core) - use ESRGAN with additional features

Uses [net-vips](https://github.com/kleisauke/net-vips) library to split input images into tiles and then merge them after processing tiles with ESRGAN. Also supports **alpha channels** and **various image formats (.dds, .tga etc).**

Although app can detect model upscale size by running python script, it can cause error in some cases (freeze) and so it is highly recommended to **rename all your models so that filenames contain upscale size as in screenshot below**.

Please, before using this tool ensure that you installed all python dependencies correctly and ESRGAN is working on it's own.

## Requirements

* .NET Framework 4.6.1
* [ESRGAN](https://github.com/xinntao/ESRGAN)

![screen](https://i.imgur.com/AUSFg14.png)

## Usage

On first launch specify ESRGAN main directory path in Settings tab.
You can also specify folders for input and output images. By default it will be *"esrgan-path/img"* and *"esrgan-path/merged_results
  
 Check one or more models from the tree view, select corresponding upscale size, output mode.
 
 When ready click [CROP] button. Tiles will be created from input images in *"esrgan-path/LR"* directory. Tile resolution will be calculated from *MaxTileResolution* value (biggest possible). Each time old tiles will be deleted from folder.
 **You need to always run [CROP] before ESRGAN, even when you don't really need to crop images.**
 
Click [RUN ESRGAN] button to start ESRGAN script in console window. 

When ESRGAN is finished, results will be in *"results-path"* folder, *"results-path/models"* or *"results-path/images"* folders, depending on which output mode you selected earlier.

To merge resulted tiles back click [MERGE] button.

**Notice: Don't delete images from input directory before you finished working with them.**

## Settings

![screen-settings](https://i.imgur.com/tlvqgrL.png)
 ### Maximum tile resolution
 MaxTileResolution = TileWidth x TileHeight
 Currently, to find out how big MaxTileResolution you VGRAM can handle you need to experiment. Default value is for 2Gb VGRAM.
 ### Tiles overlap
 When creating tiles, they will be overlaping between themselves by size in pixels specified by this value. Value must be at least 16 pixels. The bigger value - more time to process tiles with ESRGAN.
 ### Ignore alpha
If checked, while creating tiles and merging them, alpha channels from input images will be ignored.
 ### Preserve image format
 When merging writes image in original format. If unchecked all images will be merged as PNG.
 ### Create image image in input folder
 Creates blank black image with max TileWith and TileHeight. It's might be needed because if ESRGAN starts with small image and then tries to process bigger image, it can run in out of memory error. 
 ### Delete results after merging
 After successfully merging image deletes all of it merged tiles in result folder. 
 
 ![screen-adv](https://i.imgur.com/c2fPYaW.png)
 
 ### Use suffix
 Useful when you are using tool other than ESRGAN and your processed image have suffix. Just check this option and write it in textbox befote merging tiles.
 ### Filters
 Use various filter if you want to work only with particular images from input folder. For example you might upscale only images with "(wood)" in filename. Or you want to merge images without alpha as .png and the rest - as .tga etc. </br>
 **Filters work only when cropping and merging! ESRGAN still process all files from it's LR directory.**
  
  ### Output modes
  #### Default  
  * **Results**: *esrgan-path/results*
  * **Merged results**: *merged-results-path/*
  
  #### Folder for each image  
  * **Results**: *results-path/images/image-name/*
  * **Merged results**: *merged-results-path/images/image-name/merged*
  
  #### Folder for each model  
  * **Results**: *results-path/models/model-name/*
  * **Merged results**: *merged-results-path/models/model-name/merged*
  
  
