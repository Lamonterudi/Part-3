using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ally : Player
{
    public static TextMeshProUGUI yoshTalk;
  
    // Start is called before the first frame update

    private void Start()
    {
        yoshTalk = FindAnyObjectByType<TextMeshProUGUI>();
    }
    private void FixedUpdate()
    {
        base.movement();
    }

    public static void yoshiSpeech()
    {

        yoshTalk.text = "Yoshi: If you press \"y\" then we can get out of this ditch girl... ";

    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
      
            yoshiSpeech();
     


    }
}
