using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Birds : MonoBehaviour
{
    public float health = 4f;
    public static int BirdCount = 0;

    private void Start()
    {
        BirdCount++;
    }

    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if(colInfo.relativeVelocity.magnitude>health)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        BirdCount--;
        if(BirdCount==0)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
