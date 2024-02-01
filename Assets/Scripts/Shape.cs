using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    //ABSTRACTION
    protected abstract void Greet();

    protected virtual void OnMouseDown()
    {
        Greet();
    }

}
