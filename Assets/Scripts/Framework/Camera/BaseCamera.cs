using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class BaseCamera : MonoBehaviour {

    protected Transform _player;

    [SerializeField]
    protected float _smoothingFactor = 5f;
	// Use this for initialization
	void Start () {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        FollowPlayer();
	}

    protected virtual void FollowPlayer()
    {

    }
}
