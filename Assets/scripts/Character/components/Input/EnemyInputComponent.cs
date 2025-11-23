using UnityEngine;

public class EnemyInputComponent : IInputComponent
{
    private Character characterTarget;
    private Transform selfTransform;

    public EnemyInputComponent(Transform selfTransform, Character characterTarget)
    {
        this.selfTransform = selfTransform;
        this.characterTarget = characterTarget;
    }

    public Vector3 GetDirection()
    {
        if (characterTarget == null || characterTarget.transform == null || selfTransform == null)
        {
            // На проде лучше логировать, а не падать
            return Vector3.zero;
        }

        Vector3 moveDirection = characterTarget.transform.position - selfTransform.position;
        return moveDirection.normalized;
    }
}