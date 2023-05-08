using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

public class SOCreator : MonoBehaviour
{
    [MenuItem("Tools/CreateSOs", priority = 1)]
    public static void Create()
    {
        AssetDatabase.Refresh();

        UnityEngine.Object[] SOs = Resources.LoadAll("SOs", typeof(ScriptableObject));
        Type[] types = Assembly.GetAssembly(typeof(SOLoader<ScriptableObject>)).GetTypes();
        List<string> createdSOsNames = new List<string>();
        List<string> fullNames = new List<string>();

        for (int i = 0; i < SOs.Length; i++)
        {
            createdSOsNames.Add(SOs[i].GetType().FullName);
            Debug.Log("createdSOsNames  " + SOs[i].GetType().FullName);
        }

        for (int i = 0; i < types.Length; i++)
        {
            if (types[i].BaseType?.GetInterface("ISOLoader") != null)
            {
                if (createdSOsNames.Contains(types[i].FullName) == false)
                {
                    Debug.Log("type.FullName:  " + types[i].FullName);
                    fullNames.Add(types[i].FullName);

                    var createdInstance = ScriptableObject.CreateInstance(types[i].FullName);
                    AssetDatabase.CreateAsset(createdInstance, $"Assets/Resources/SOs/{types[i].FullName}.asset");
                    AssetDatabase.SaveAssets();
                    AssetDatabase.Refresh();
                    EditorUtility.FocusProjectWindow();
                    Selection.activeObject = createdInstance;
                }
                else
                {
                    Debug.LogWarning("Has duplicates  " + types[i].FullName);
                };
            }
        }
    }
}
