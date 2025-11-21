
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


    }


    protected override void Update()
    {

        Debug.Log(HealthComponent.Health);
        if (HealthComponent == null || HealthComponent.Health <= 0)
            return;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;


        switch (aiState)
        {
            case Aistate.Idle:

              return;


            case Aistate.MoveToTarget:
                Vector3 movedirection = characterTarget.transform.position - transform.position;
                movedirection.Normalize();

                MovementComponent.Move(movedirection);
                MovementComponent.Rotation(movedirection);

                AttackComponent.MakeDamage(characterTarget);




                return;

        }



    }



}
