using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamis : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        transform.RotateAround(transform.position, Vector3.up, Random.Range(0, 360));
        StartCoroutine("Ground_Crawl");
    }

    IEnumerator Ground_Crawl()
    {//Have the spider guy appear from the ground

        float _speed = Random.Range(0f, .15f);

        for (float yPos = -1f; yPos <= 0.15f; yPos += _speed)
        {
            transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
            yield return new WaitForSeconds(0.1f);
        }
    }

}