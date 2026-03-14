## CopyTo
I needed a quick little thing to move a bunch of files to a destination for a project, so here it is.

## Usage
`CopyTo.exe {Destination} [*]{Sources}`

Example:
```
CopyTo.exe "C:\Program Files\Destinations" "D:\Project\RelWithDebInfo\VeryNiceFile.dll" "D:\Project\RelWithDebInfo\OtherNiceFile.dll"
```

## Build
- Get the latest version of Dotnet
- Clone this repo
- Open a command prompt in the directory of the repo.
- type `dotnet build`
