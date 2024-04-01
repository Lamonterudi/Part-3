using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CharBehave : MonoBehaviour
{
    public float jumpHeight = 3.0f; // The height the object will jump
    public float duration = 0.5f; // The duration of the jump
    Coroutine coroutine;
    private Vector3 ogPosition;

    void Start()
    {
        ogPosition = transform.position;
        StartCoroutine(Jump());
    }
    //made it protected and virtual to be accessible in child classes and overriden 
   protected virtual IEnumerator Jump()
    {
        while (true) // Creates an infinite loop for jump
        {
            // Move up
            float timer = 0.0f;
            Vector3 startPosition = transform.position;
            Vector3 endPosition = ogPosition + Vector3.up * jumpHeight;
            while (timer < duration)
            {
                transform.position = Vector3.Lerp(startPosition, endPosition, timer / duration);
                timer += Time.deltaTime;
                yield return null; // Wait for the next frame 
            }
            //set position to the end position in case of minor discrepancies.
            transform.position = endPosition;
            // Wait for 1 seconds at the top of the jump.
            yield return new WaitForSeconds(0.4f);
            // Move down
            timer = 0.0f;
            startPosition = transform.position;
            endPosition = ogPosition;
            while (timer < duration)
            {
                transform.position = Vector3.Lerp(startPosition, endPosition, timer / duration);
                timer += Time.deltaTime;
         
                yield return null;
            }
            transform.position = endPosition;

            // Wait for 3 seconds before jumping again
          yield return new WaitForSeconds(3);
        }
    }
}