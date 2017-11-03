using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayerController : BaseCharacter, IPlayer
{
    public static EventHandler<TakeDamageEventArgs> TakeDamageEvent;
    public static EventHandler<HealthChangedEventArgs> HealthChangedEvent;
    public static EventHandler<LivesChangedEventArgs> LivesChangedEvent;
    public static EventHandler GameOverEvent;

    [SerializeField]
    protected Rigidbody2D _rigidBody;
    protected Vector3 _move;

    [SerializeField]
    protected float _moveSpeed = 5f;

    protected int _lives;

    public virtual int Lives
    {
        get { return _lives; }
        set
        {
            _lives = value;
            if (LivesChangedEvent != null)
            {
                LivesChangedEvent(this, new LivesChangedEventArgs(_lives, MaxLives));
            }
        }
    }

    public virtual int MaxLives { get; set; }

    public virtual bool EquipWeapon(BaseWeapon weapon, bool isEquip) { return false; }

    private void Awake()
    {
        OnAwake();
    }

    protected virtual void OnAwake()
    {
        if (_rigidBody == null)
        {
            _rigidBody = GetComponent<Rigidbody2D>();
        }
    }

    protected override void OnStart()
    {
        base.OnStart();
        BaseInputManager.MovementInputEvent += OnMovementInput;
    }

    protected virtual void OnMovementInput(object sender, MovementInputEventArgs e)
    {
        
    }

    protected override void OnKilledBy(ICharacter attacker)
    {
        base.OnKilledBy(attacker);

        Lives = Mathf.Max(Lives - 1, 0);
        if (Lives == 0 && GameOverEvent != null)
        {
            GameOverEvent(this, EventArgs.Empty);
        }
    }
}
