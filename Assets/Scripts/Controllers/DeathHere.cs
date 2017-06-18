using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHere : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        Hero hero = collider.GetComponent<Hero>();
        if (hero != null)
        {
            LevelController.current.onHeroDeath(hero);
        }
    }
}