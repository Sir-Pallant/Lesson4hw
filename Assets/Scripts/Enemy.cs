using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private float _waitTime;
    public float StartWaitTime;

    public Transform[] MoveSpots;
    private int _randomSpot;

    void Start()
    {
        _waitTime = StartWaitTime;
        _randomSpot = Random.Range(0, MoveSpots.Length);
    }

     void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, MoveSpots[_randomSpot].position, speed * Time.deltaTime);
        if (Vector2.Distance (transform.position, MoveSpots[_randomSpot].position) < 0.2f)
            {
            if (_waitTime <= 0)
            {
                _randomSpot = Random.Range(0, MoveSpots.Length);
                _waitTime = StartWaitTime;
            }
            else
                {
                _waitTime -= Time.deltaTime;
                }
            }
    }
}
