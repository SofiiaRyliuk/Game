using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : Collectable
{
   // public UILabel amount;

    public override void onHeroHit(Hero hero)
    {
        LevelController.current.addCoin();
        destroy();
    }
}