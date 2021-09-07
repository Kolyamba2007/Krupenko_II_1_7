using UnityEngine;

//Этот скрипт для перемещения динамических препятствий

public class MovingObject : MonoBehaviour
{
    enum Direction : short {Left = -1, Right = 1};
    [SerializeField]
    Direction direction = Direction.Left;
    float t;
    Vector3 targetPosition;

    private void Start() {
        targetPosition = new Vector3(3.3f * (short)direction - 5, transform.localPosition.y, transform.localPosition.z);

        t = (3.3f - transform.position.x) / 6.6f * 0.028f;
    }

    private void FixedUpdate() {
        t += 0.00005f;
        transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, t);

        if(t >= 0.028f)
        {
            t = 0;

            if(direction == Direction.Left)
                direction = Direction.Right;
            else
                direction = Direction.Left;
            
            transform.localPosition = targetPosition;
            targetPosition = new Vector3(targetPosition.x + 6.6f * (short)direction, transform.localPosition.y, transform.localPosition.z);
        }
    }
}
