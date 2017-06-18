using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Artefact : Collectable
{
   // public UILabel art;

    public override void onHeroHit(Hero hero)
    {
        LevelController.current.addArtefact();
        destroy();
    }
}