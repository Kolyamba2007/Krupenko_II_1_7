using System;
using System.IO;
using System.Text;
using UnityEngine;

public static class DebugManager
{
    private static string FilePath => $"{Directory.GetCurrentDirectory()}\\Logs\\Logs.txt";
    
    public static void Log(object message, LogType type = LogType.Log)
    {
        switch (type)
        {
            case LogType.Assert:
                Debug.LogAssertion(message);
                break;
            case LogType.Error:
                Debug.LogError(message);
                break;
            case LogType.Exception:
                Debug.LogException(message as Exception);
                break;
            case LogType.Log:
                Debug.Log(message);
                break;
            case LogType.Warning:
                Debug.LogWarning(message);
                break;
        }
    }

#if !UNITY_EDITOR && UNITY_STANDALONE_WIN
    public static async void Log(string message, LogType type = LogType.Log)
    {
        FileStream stream;
        if (!File.Exists(FilePath)) stream = File.Create(FilePath, message.Length, FileOptions.Asynchronous);
        else stream = new FileStream(FilePath, FileMode.Append, FileAccess.Write);

        string logType = string.Empty;
        switch (type)
        {
            case LogType.Assert: logType = "===[ASSERT]==="; break;
            case LogType.Error: logType = "===[ERROR]==="; break;
            case LogType.Exception: logType = "===[EXCEPTION]==="; break;
            case LogType.Warning: logType = "===[WARNING]==="; break;
        }

        string header = DateTime.Now.ToLongTimeString();
        string text = $"{logType} [{header}] {message}\n";
        byte[] bytes = Encoding.Default.GetBytes(text);

        stream.Seek(stream.Length, SeekOrigin.Begin);
        await stream.WriteAsync(bytes, 0, bytes.Length);
        stream.Close();
    }
#endif
}
