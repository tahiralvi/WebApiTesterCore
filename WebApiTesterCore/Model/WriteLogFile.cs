using System;
using System.IO;

namespace WebApiTesterCore.Model
{
    public static class WriteLogFile
    {
        public static bool WriteLog(string strFileName, string strMessage)
        {
            try
            {
                FileStream objFilestream = new FileStream(string.Format("{0}\\{1}", Path.GetTempPath(), strFileName), FileMode.Append, FileAccess.Write);
                StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
                objStreamWriter.WriteLine(strMessage);
                objStreamWriter.Close();
                objFilestream.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message.ToString());
                throw;
            }
        }

        public static bool Log(string strFileName, string strMessage)
        {
            try
            {
                // Set a variable to the Documents path.
                string docPath =
                  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Write the string array to a new file named "WriteLines.txt".
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, strFileName)))
                {
                    outputFile.WriteLine(strMessage);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message.ToString());
                throw;
            }
        }
    }
}