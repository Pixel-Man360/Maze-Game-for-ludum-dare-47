﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _pillar;
    [SerializeField] private float _spawnTime = 1.7f;
    [SerializeField] private float _currentTime;
    

    

    private void Start()
    {
       // player.onDead += StopSpawing;
        
        //InvokeRepeating("Spawn", 1,_spawnTime);

         _currentTime = 1.4f;

        GameManagerFB.StopSpawn += StopSpawing;

        GameManagerFB.StartSpawn += StartSpawning;

       
        
    }

 
    void Spawn()
    {   
      
      Instantiate(_pillar, new Vector2(transform.position.x,UnityEngine.Random.Range(-5.9f,6.9f)), Quaternion.identity);
        
    }

    void StartSpawning()
    {

        _currentTime += Time.deltaTime;

        if(_currentTime >= _spawnTime)
         {
           _currentTime = 0f;
           Instantiate(_pillar, new Vector2(transform.position.x,UnityEngine.Random.Range(-5.9f,6.9f)), Quaternion.identity);
           
         }
        //InvokeRepeating("Spawn", 1,_spawnTime);
    } 

    
    void StopSpawing()
    {
      _currentTime = 0f;
      _spawnTime = 0f;
    }
    


}
