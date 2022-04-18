using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerContainer : MonoBehaviour
{
    public static ManagerContainer s_Instance;
    public static ManagerContainer Instance { get { Init(); return s_Instance; } }
    
    bool hello = true;

    public static void Init()
    { 
        if(s_Instance == null)
        {
            GameObject go =GameObject.Find("@ManagerContainer");

            if(go == null)
            {
                go = new GameObject { name = "@ManagerContainer" };


                go.AddComponent<ManagerContainer>();
            }
            s_Instance = go.GetComponent<ManagerContainer>();
            DontDestroyOnLoad(go);
        }
    }
}
