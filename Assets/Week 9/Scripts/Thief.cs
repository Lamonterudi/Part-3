using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform spawnPoint;
    public Transform spawnPointTwo;
    protected override void Attack()
    { 
        //instantiates two daggers 
        Instantiate(daggerPrefab, spawnPoint.position, spawnPoint.rotation);
        Instantiate(daggerPrefab, spawnPointTwo.position, spawnPointTwo.rotation);
        base.Attack();
        //allows thief to dash while attacking to mouse clicked spot
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
    }
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
}
