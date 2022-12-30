using Blog.Infrastructure.Operations;

namespace Blog.Infrastructure.Services.Storage
{
    public class Storage
    {
        protected delegate bool HasFile(string pathOrContainerName, string fileName);
        protected async Task<string> FileRenameAsync(string pathOrContainerName, string fileName, HasFile hasFileMethod)
        {
            string extension = Path.GetExtension(fileName);
            string changedFileName = $"{NameOperation.CharacterRegulatory(Path.GetFileNameWithoutExtension(fileName))}{extension}";

            if (!hasFileMethod(pathOrContainerName, changedFileName))
                return changedFileName + extension;

            else
            {
                string newFileName = Path.GetFileNameWithoutExtension(changedFileName);
                if (int.TryParse(newFileName[newFileName.Length - 1].ToString(), out int sayi) && newFileName.EndsWith($"-{sayi}"))
                {
                    sayi++;
                    newFileName = $"{newFileName.Remove(newFileName.IndexOf("-"))}-{sayi}";
                    changedFileName = newFileName + $"{extension}";
                }
                else
                    changedFileName = newFileName + "-1";

                return await FileRenameAsync(pathOrContainerName, changedFileName, hasFileMethod);
            }

        }
    }
}
