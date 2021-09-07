using UnityEngine;

public class TriggerComponent : MonoBehaviour
{
    [SerializeField]
    private Collider _collider;

    private void Awake()
    {
        if (_collider == null) throw new MissingReferenceException();
    }

    private void OnTriggerEnter(Collider other)
    {
        GameManager.Self.UpdateLevel();
    }
}
