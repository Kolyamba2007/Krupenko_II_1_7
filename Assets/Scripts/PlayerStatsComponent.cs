using UnityEngine;

public class PlayerStatsComponent : MonoBehaviour
{
    [Range(0f, 20f)]
    public float speed = 10f;
    [Range(0f, 10f)]
    public float jumpForce = 5f;
}
