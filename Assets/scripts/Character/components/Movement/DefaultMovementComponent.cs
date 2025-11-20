
using UnityEngine;

public class DefaultMovementComponent : MonoBehaviour
{
    public float Speed { get; set; }
    public float speed;

    public Vector3 Position { get; }

    public void Initialize(CharacterData characterData)
    {
        this.characterData = characterData;
        speed = characterData.DefaultSpeed;
    }

    public void Move(Vector3 direction) { }

    public void Rotation(Vector3 direction) { }
}
