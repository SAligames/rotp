using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanceManager : Subject
{
    public int shots = 3;
    public Observer displayChance;

    // Start is called before the first frame update
    private void Start()
    {
        registerObserver(displayChance);
    }

    public void updateShot(int ammo)
    {
        shots -= ammo;
        Notify(shots, NotificationType.ChanceUpdated);
        if(shots==0)
        {
            Debug.Log("Game Over!");
        }
    }
}
