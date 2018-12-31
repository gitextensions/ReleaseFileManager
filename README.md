# Release File Manager
GUI tool to manage GitExtensions release files


## The Goal

Manage setup build scripts 
- [Portable Build](https://github.com/gitextensions/gitextensions/blob/master/Setup/MakePortableArchive.cmd)
- [MSI Build](https://github.com/gitextensions/gitextensions/blob/master/Setup/Product.wxs)

## Expected Workflow
1. User runs build script to create release build files
1. User runs this utility or even utility is run in build script to alter build scripts to include missing files in both installers
1. User verifies setup build script changes and commits

## Benefits

- Changes to needed files are detected
- User has final say over the changes and can edit in a way that is not prone to errors
- Sourcing files from ...\Bin\\%Configuration% folder will make it so portable builds are easier to manage
