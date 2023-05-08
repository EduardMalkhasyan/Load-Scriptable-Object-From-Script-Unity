using UnityEngine;

public class SOLoader<T> : ScriptableObject, ISOLoader where T : ScriptableObject
{
    private static T Instance;

    public static T Value
    {
        get
        {
            if (Instance == null)
            {
                Instance = Resources.Load<T>($"SOs/{typeof(T)}");
            }

            return Instance;
        }
    }
}

interface ISOLoader
{

}
