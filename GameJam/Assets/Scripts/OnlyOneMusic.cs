using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyOneMusic : MonoBehaviour
{
    private static GameObject instance;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(instance);
        }
        instance = gameObject;
        DontDestroyOnLoad(this);
    }

}
