using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    public Transform Gameobject1;
    public Transform Gameobject2;
    public Transform Gameobject3;

    Coroutine building;
   

    // Start is called before the first frame update
    void Start()
    {
        building = StartCoroutine(buildingSpawner());
    }
   
    // Update is called once per frame
    IEnumerator buildingSpawner()
    {
        //instantiates parts of my building one by one into my scene with a bit of a delay seperated by yield return new wait for seconds 
        Gameobject1.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one,.25f);
        yield return new WaitForSeconds(0.4f);
        Gameobject1.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, .8f);
        Gameobject2.transform.localScale = Vector3.Lerp(Vector3.zero,Vector3.one, .5f); //builds everything gradually 
        Gameobject3.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, .5f);
        yield return new WaitForSeconds(0.4f);
        Gameobject1.transform.localScale = Vector3.Lerp(Vector3.zero, new Vector3(2.11f, 4.2f, 0f), 1);
        Gameobject2.transform.localScale = Vector3.Lerp(Vector3.zero, new Vector3(2, 2, 0), 1);
        Gameobject3.transform.localScale = Vector3.Lerp(Vector3.zero, new Vector3(2, 2, 0), 1);
    }
}
