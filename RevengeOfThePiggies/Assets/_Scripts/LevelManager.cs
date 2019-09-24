using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Subject
{
    public int level = 0;
    public Observer displayLevel;

    //making the constructor private prevents others
    //from creating an object of this class
    private void Start()
    {
        registerObserver(displayLevel);
    }

    public void updateLevel(int world)
    {
        level += world;
        Notify(level, NotificationType.LevelUpdated);
    }
}
