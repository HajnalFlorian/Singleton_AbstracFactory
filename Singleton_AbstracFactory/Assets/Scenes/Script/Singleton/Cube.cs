using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void Start()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();

        if (renderer)
        {
            if (singleton.Instance.Ruuning)
                renderer.material.color = Color.blue;
            else
                renderer.material.color = Color.red;
        }
    }
}
