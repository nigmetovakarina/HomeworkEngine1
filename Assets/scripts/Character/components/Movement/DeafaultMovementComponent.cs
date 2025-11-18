
public class DeafaultMovementComponent : MonoBehaviour
{
    public float Speed { get; set; }

    public Vector3 Position { get; }

    public void Move(Vector3 direction);

    void Rotation(Vector3 direction);
}
