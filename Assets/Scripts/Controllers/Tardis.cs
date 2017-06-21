using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tardis : MonoBehaviour
{
    public int level;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (level == 0)
        {

        }
        else
        {
            SceneManager.LoadScene("Level" + level);
        }
    }

}