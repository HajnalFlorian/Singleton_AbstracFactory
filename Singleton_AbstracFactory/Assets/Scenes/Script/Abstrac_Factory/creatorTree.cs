using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class creatorTree : Abstrac_Factory
{
    public override void objectcreator()
    {
        GameObject arbre1 = new GameObject();
        arbre1.name = "arbre1";
        arbre1.transform.position = Vector3.right * 5;
        arbre1.transform.rotation = Quaternion.Euler(-90f, 0,0);
        arbre1.transform.localScale = Vector3.one * 30;
        arbre1.AddComponent<MeshFilter>();
        arbre1.GetComponent<MeshFilter>().mesh = arbre;
        arbre1.AddComponent<MeshRenderer>().materials = new Material[2];
        arbre1.GetComponent<MeshRenderer>().material = m1;
        arbre1.GetComponent<MeshRenderer>().materials[1] = m2;
        arbre1.tag = "arbre";



    }
    public override void destructor()
    {
        GameObject[] tabO = GameObject.FindGameObjectsWithTag("souche");
        for (int i = 0; i < tabO.Length; i++)
        {
            Destroy(tabO[i]);
        }
    }
}
