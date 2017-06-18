using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    //public
    public static LevelController current = null;

    public int maxLives;
    public int coins;
    public int level;

    //private
    Vector3 startPosition;
    LevelStats stats;

    void Awake()
    {
        current = this;
    }

    public void setStartPosition(Vector3 pos)
    {
        startPosition = pos;
    }
    public Vector3 getStartPosition()
    {
        return startPosition;
    }

    public void onHeroDeath(Hero hero)
    {
        hero.transform.position = getStartPosition();
    }

    public void addCoin()
    {

    }
    public void addLife() { }
    public void addArtefact() { }

    public void setStats()
    {

    }

    public LevelStats getStats()
    {
        return stats;
    }
}