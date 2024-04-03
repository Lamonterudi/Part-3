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
    private void Update()
    {
        base.FixedUpdate();

        yoshiSpeech();
    }

    public static void yoshiSpeech()
    {
        //made yoshi a little sassy LOL 
        yoshTalk.text = "Yoshi: If you press \"y\" then we can get out of this ditch Chile... ";

    }
   
}
