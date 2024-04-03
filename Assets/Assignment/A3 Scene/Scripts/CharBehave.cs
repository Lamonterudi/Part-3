using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharBehave : MonoBehaviour
{
    //this was created to help aid the lerping to blue when the mice is caught before it disappears. 
    protected virtual void destroyGameobject()
    {
        Destroy(gameObject);
    }
    //made it protected and virtual to be accessible in child classes and overriden 
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        destroyGameobject();
    }
}
