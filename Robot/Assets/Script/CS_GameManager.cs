﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_GameManager : MonoBehaviour {
    public int enemyNum;
    public GameObject enemy;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		if(enemyNum == 0)
        {
            clear();
        }
	}

    public void CreateEnemy()
    {
        Vector3 position;
        for(int i = 0; i < enemyNum; i++)
        {
            position = new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f), Random.Range(-50f, 50f));
            Instantiate(enemy, position, transform.rotation);
        }
    }

    void clear()
    {
        GameObject.Find("SceneManager").GetComponent<CS_SceneManager>().LoadScene("Result");
    }
}
