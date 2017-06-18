using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelStats
{
    public bool levelPassed = false;
    public int coins = 0;
    public bool hasAllArtefacts = false;

    public List<int> coinsCollected;
    public List<int> artefactsCollected;
    public List<int> enemiesKilled;

}
