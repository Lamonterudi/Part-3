using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : Mice
{

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);
        Debug.Log("You found the easter egg!!");
    }
}
