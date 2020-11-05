using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public abstract class Abstrac_Factory : MonoBehaviour
{
    public Mesh arbre;
    public Material m1;
    public Material m2;
    public abstract void objectcreator();
    public abstract void destructor();
}
