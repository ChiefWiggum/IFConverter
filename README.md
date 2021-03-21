
# IFConverter

Converts iFolor photo books to pngs

  

## Note

This is a very quick and dirty prototype to load iFolor photobooks (Project.ipp) and generate some basic pngs for each page. It was written in early 2021 in a few hours and is still missing a lot of features, but is a start for someone with more time and interest.

  

## To do

-  [x] Load Project.ipp files

-  [x] Load Images

-  [x] Load RichText (xaml) files

-  [x] Generate png files

-  [x] Document ipp file format

-  [x] Document text file format

- [ ] Document photobook data structure

- [ ] Document differences between different photobook versions

- [ ] Rotation of Images and RichText partially working

- [ ] Zoom/Section of image missing

- [ ] Horizontal alignment missing

- [ ] Mirror of images missing

- [ ] Clip art support missing

- [ ] Speech bubbles support missing

- [ ] Background colour missing

  

# File formats

## Project.ipp

This is a xml document that got gzipped and has 23 leading bytes for an unknown reason.

If you want to unzip the file, use [7-zip](https://www.7-zip.org) or another tool that doesn't care about the leading bytes.

## Text files

The text files are xaml files which are basically zip files. These zip files are again gzipped and have again 23 leading bytes for unknown reasons.

The zip file contains the following files and folders

  

* _rels
	* .rels
* Xaml
	* Document.xaml
*  [Content_Types].xml

  

The `Document.xaml` contains a xml structure of [Sections](https://docs.microsoft.com/en-us/dotnet/api/system.windows.documents.section),[Paragraphs](https://docs.microsoft.com/en-us/dotnet/api/system.windows.documents.paragraph) and [Runs](https://docs.microsoft.com/en-us/dotnet/api/system.windows.documents.run).
