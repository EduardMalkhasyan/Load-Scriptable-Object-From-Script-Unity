using System.IO;
using UnityEngine;

public class SOLoader<T> : ScriptableObject, ISOLoader where T : ScriptableObject
{
    public static T Value
    {
        get
        {
            var path = $"{SOProps.folderName}/{typeof(T)}";

            var loadedInstance = Resources.Load<T>(path);

            if (loadedInstance == null)
            {
                Debug.LogWarning($"Cant load Scriptable Object in path: \"{path}\", its null, file name is {typeof(T)}, path is not Specific");
            }

            return loadedInstance;
        }
    }

    public static T SpecificValue(string path)
    {
        var loadedInstance = Resources.Load<T>(path);

        if (loadedInstance == null)
        {
            Debug.LogWarning($"Cant load Scriptable Object in path: \"{path}\", its null, file name is {typeof(T)}, path is Specific");
        }

        return loadedInstance;
    }
}

interface ISOLoader
{

}
