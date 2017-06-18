using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        Hero hero = collider.gameObject.GetComponent<Hero>();
        if (hero != null)
        {
            onHeroHit(hero);
        }
    }

    public virtual void onHeroHit(Hero hero) { }

    public void destroy()
    {
        Destroy(this.gameObject);
    }
}