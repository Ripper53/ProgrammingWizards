import os

fileExtensions = [".cpp", ".h", ".json", ".xml"]

def main():
    def getFilesWithExtension(extension):
        files = []
        for fileName in os.listdir():
            if fileName.endswith(extension):
                files.append(fileName)
        return files

    def printFiles(files, extension):
        print("--------------------------------")
        print("Files with", extension, "extension!")
        for i in range(0, len(files)):
            print("File #" + str(i + 1) + ":", files[i])
        print("Number of files with", extension, "extension:", len(files))

    for extension in fileExtensions:
        files = getFilesWithExtension(extension)
        printFiles(files, extension)


main()
