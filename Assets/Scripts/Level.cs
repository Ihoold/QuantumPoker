using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Level : ScriptableObject
{
    public int[] oponentMoney;
    public int humanMoney;

    public bool isBossLevel = false;

    public void Initialize(Table table)
    {
        table.humanPlayer.currentMoney = humanMoney;
        int i = 0;

        foreach (var player in table.robotPlayers)
        {
            player.gameObject.SetActive(true);
            player.currentMoney = oponentMoney[i];
            i++;
        }

        if (isBossLevel)
        {
            InitializeBoss();
        }
    }

    void InitializeBoss()
    {
        // TODO: boss
    }
}