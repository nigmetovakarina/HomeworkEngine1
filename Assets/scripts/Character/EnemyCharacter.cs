
using UnityEngine;

public class EnemyCharacter : Character
{
    [SerializeField]
    private Character characterTarget;
    [SerializeField]
    private Aistate aiState;



    public override void Initialize()
    {
        base.Initialize();
        HealthComponent = new HealthComponent();
        InputComponent = new EnemyInputComponent();

    }


    protected override void Update()
    {

        Debug.Log(HealthComponent.Health);
        if (HealthComponent == null || HealthComponent.Health <= 0)
            return;
     

        switch (aiState)
        {
            case Aistate.Idle:

              return;


            case Aistate.MoveToTarget:
                

                MovementComponent.Move(InputComponent.GetDirection());
                MovementComponent.Rotation(InputComponent.GetDirection());

                AttackComponent.MakeDamage(characterTarget);




                return;

        }



    }



}
