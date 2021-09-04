using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public bool destroy = false;
    public int pointsWorth = 0;

    private void Start()
    {
        FishScore.scoreValue = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        FishScore.scoreValue += pointsWorth;
        if (destroy)
        {
            Destroy(gameObject);
        }
    }
}
