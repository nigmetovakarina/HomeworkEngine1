
using UnityEngine;

public class EnemyCharacter : Character
{
    [SerializeField] private Character characterTarget;
    [SerializeField] private Aistate aiState;

    public override void Initialize()
    {
        base.Initialize();
        HealthComponent = new HealthComponent();

        InputComponent = new EnemyInputComponent(transform, characterTarget);
    }

    protected override void Update()
    {
        if (HealthComponent == null || HealthComponent.Health <= 0)
            return;

        switch (aiState)
        {
            case Aistate.Idle:
                return;

            case Aistate.MoveToTarget:
                var dir = InputComponent.GetDirection();
                MovementComponent.Move(dir);
                MovementComponent.Rotation(dir);
                AttackComponent.MakeDamage(characterTarget);
                return;
        }
    }
}