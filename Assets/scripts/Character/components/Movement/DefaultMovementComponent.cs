
using UnityEngine;

public class DefaultMovementComponent : IMovementComponent
{
    private CharacterData characterData;
    public float speed;
    public float Speed {
        get => speed;
        set
        {
            if (value < 0)
                speed = 0;
            else
                speed = value;
        }
    }

    public Vector3 Position
    {
        get
        {
            return CharacterData.CharacterTransform.position;
        }
    }

    public CharacterData CharacterData { get => characterData; set => characterData = value; }

    public void Initialize(CharacterData characterData)
    {
        this.CharacterData = characterData;
        Speed = characterData.DefaultSpeed;
    }

    public void Move(Vector3 direction) 
    {
        if (direction == Vector3.zero)
        {
            return;
        }

        float targetAngle = Mathf.Atan2(y: direction.x, x: direction.z) * Mathf.Rad2Deg;
        Vector3 movement = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
        CharacterData.CharacterController.Move(motion:movement * speed * Time.deltaTime);

    }

    public void Rotation(Vector3 direction)
    {
        if (direction == Vector3.zero)
        {
            return;
        }
        float turnSmoothTime = 0.1f;
        float targetAngle = Mathf.Atan2(y: direction.x, x: direction.z) * Mathf.Rad2Deg;
        float angle = Mathf.SmoothDampAngle(CharacterData.CharacterTransform.eulerAngles.y, targetAngle, ref turnSmoothTime, turnSmoothTime);
        CharacterData.CharacterTransform.rotation = Quaternion.Euler(0, angle, 0);
    }

    

}

class characterData
{
    public static object CharacterTransform { get; internal set; }
}