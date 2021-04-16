using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    Enemy[] _enemies;
    GameObject[] _doors;
    // Start is called before the first frame update
    void Start()
    {
        _enemies = GameObject.FindObjectsOfType<Enemy>();
        _doors = GameObject.FindGameObjectsWithTag("Door");
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemiesAreAllDead())
        {
            OpenAllDoors();
        }
    }

    private void OpenAllDoors()
    {
        foreach(var door in _doors)
        {
            GameObject.Destroy(door);
        }
    }

    private bool EnemiesAreAllDead()
    {
        if ((_enemies != null) && (_enemies.Length != 0))
        {
            foreach (var enemy in _enemies)
            {
                if (enemy.enabled)
                {
                    //print("false");
                    return false;
                }
            }
        }
        return true;
    }
}
