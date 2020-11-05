using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class singleton : MonoBehaviour
{
    public static singleton instance = null;
    public bool Ruuning = true;

    public static singleton Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<singleton>();
                if(instance == null)
                {
                    GameObject single = new GameObject();
                    instance = single.AddComponent<singleton>();
                    DontDestroyOnLoad(single);
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
