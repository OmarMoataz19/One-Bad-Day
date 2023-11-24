using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyClub : MonoBehaviour
{
    private static DontDestroyClub instance;

    void Awake()
    {
        if(instance != null) {
            Destroy(gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
