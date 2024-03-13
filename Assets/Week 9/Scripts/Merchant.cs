using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : Villager //took everything from villager 
{


    public override ChestType CanOpen()
    {
        return ChestType.Merchant;
    }
}