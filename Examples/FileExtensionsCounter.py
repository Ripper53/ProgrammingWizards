import os

fileExtensions = [".txt", ".docx", ".pdf", ".tex"]

def main():
    def getFilesWithExtension(extension):
        print("--------------------------------")
        print("Getting files with", extension, "extension!")
        files = []
        for fileName in os.listdir():
            if fileName.endswith(extension):
                files.append(fileName)
                print("Got file:", fileName)
        return files

    for extension in fileExtensions:
        files = getFilesWithExtension(extension)
        print("Number of files with", extension, "extension:", len(files))


main()
