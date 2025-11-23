using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    private CharacterData characterData;


    public IHealthComponent HealthComponent { get; protected set; }

    public IMovementComponent MovementComponent { get; protected set; }

    public IAttackComponent AttackComponent { get; protected set; }

    public IInputComponent InputComponent { get; protected set; }

    public CharacterData CharacterData => characterData;

    public object CharacterTransform { get; internal set; }

    protected IInputComponent _InputComponent;


    

    public virtual void Initialize()
    {
    MovementComponent = new DefaultMovementComponent();
    MovementComponent.Initialize(characterData);
    AttackComponent = new AttackComponent();
    AttackComponent.Initialize(characterData);
    }
    private void Start()
    {
        Initialize();
    }

    protected abstract void Update();

}
