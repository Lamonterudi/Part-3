using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI; //for code to interact wtih UI

public class CharacterControl : MonoBehaviour
{
    public static Villager SelectedVillager { get; private set; }
    public TextMeshProUGUI screenText;
    //public GameObject ThiefText;
 //   public GameObject MerchantText;
   // public GameObject ArcherText;

    public static void SetSelectedVillager(Villager villager)
    {
        if (SelectedVillager != null)
        {
            SelectedVillager.Selected(false);

        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
       
    }
    public void Update()
    {

  //      ThiefText.name = "Thief";
      //  MerchantText.name = "Merchant"; tried to convert game objects to string in my expierementation
     //   ArcherText.name = "Archer";

        //reference the enum from other scripts
        if (SelectedVillager != null)
        {
            screenText.text = SelectedVillager.CanOpen().ToString();
        }
        if (SelectedVillager == null)
        {
            screenText.text = "No character Selected";
        }
    }
}
