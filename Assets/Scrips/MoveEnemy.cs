using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MoveEnemy : MonoBehaviour
{
    public int EnemySpeed;
    GameObject movePlayer;

    private void Awake()
    {
        movePlayer = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 localPosition = movePlayer.transform.position - transform.position;
        localPosition = localPosition.normalized;
        transform.Translate(localPosition.x * Time.deltaTime * EnemySpeed, 0f, localPosition.z * Time.deltaTime * EnemySpeed);

    }
}




