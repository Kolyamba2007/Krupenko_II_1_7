using UnityEngine;

public class TriggerComponent : MonoBehaviour
{
    [SerializeField]
    private Collider _collider;

    private void OnTriggerEnter(Collider other)
    {
        GameManager.Self.UpdateLevel();
    }
}
