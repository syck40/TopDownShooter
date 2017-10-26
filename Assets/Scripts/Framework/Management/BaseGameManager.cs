using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGameManager : MonoBehaviour {

    protected IPlayer _player;
    protected List<IEnemy> _enemies;

    protected BaseInputManager _inputManager;
    protected BaseUIManager _uiManager;

    private void Awake()
    {
        OnAwake();
    }

    // Use this for initialization
    void Start () {
        OnStart();
	}
	
	// Update is called once per frame
	void Update () {
        OnUpdate();
	}

    protected virtual void OnAwake()
    {

    }

    protected virtual void OnStart()
    {

    }

    protected virtual void OnUpdate()
    {

    }
}
