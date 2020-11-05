using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatorSouche : Abstrac_Factory
{
    public override void objectcreator()
    {
        GameObject souche = new GameObject();
        souche.name = "souche";
        souche.transform.position = Vector3.right * -5;
        souche.transform.rotation = Quaternion.Euler(-90f, 0, 0);
        souche.transform.localScale = Vector3.one * 30;
        souche.AddComponent<MeshFilter>();
        souche.GetComponent<MeshFilter>().mesh = arbre;
        souche.AddComponent<MeshRenderer>().materials = new Material[2];
        souche.GetComponent<MeshRenderer>().material = m1;
        souche.GetComponent<MeshRenderer>().materials[1] = m2;
        souche.tag = "souche";
    }

    public override void destructor()
    {
        GameObject[] tabO = GameObject.FindGameObjectsWithTag("arbre");
        for (int i = 0; i < tabO.Length; i++)
        {
            Destroy(tabO[i]);
        }
    }
}
