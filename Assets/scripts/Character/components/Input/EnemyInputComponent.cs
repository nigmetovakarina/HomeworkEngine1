using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInputComponent : IInputComponent
{
    private CharacterData characterTarget;
    private Transform transform;
    public Vector3 GetDirection()
    {
        Vector3 movedirection = characterTarget.transform.position - transform.position;
        movedirection.Normalize();

        return movedirection;
    }
}
