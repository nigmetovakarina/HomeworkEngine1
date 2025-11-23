using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Character
{

    private IInputComponent _inputComponent;
    public override void Initialize()
    {
        base.Initialize();
        HealthComponent = new HealthComponent();
        InputComponent = new PlayerInputComponent();
    }

    protected override void Update()
    {
        if (HealthComponent == null || HealthComponent.Health <= 0)
            return;


        MovementComponent.Move(InputComponent.GetDirection());
        MovementComponent.Rotation(InputComponent.GetDirection());
    }
}
