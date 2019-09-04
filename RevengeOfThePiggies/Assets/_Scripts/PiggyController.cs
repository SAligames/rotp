using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiggyController : MonoBehaviour
{
    Vector3 startPosition;
    Quaternion startRotation;
    GameObject cannon;
    const int WAIT_TIME = 3;
    // Start is called before the first frame update
    void Start()
    {
        cannon = transform.parent;
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine();
    }

    IEnumerator ResetPiggie()
    {
        yield return WaitForSeconds();
        transform.position = startPosition;
        transform.rotation = startRotation;
        GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.parent = transform;
    }
}
