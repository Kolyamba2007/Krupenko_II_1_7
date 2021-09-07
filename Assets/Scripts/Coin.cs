using UnityEngine;

public class Coin : MonoBehaviour
{
    private void Start() {
        transform.Rotate(Vector3.up * Random.Range(0, 45), Space.Self);
    }

    private void Update() {
        transform.Rotate(Vector3.up * 100 * Time.deltaTime, Space.Self);
    }

    void OnTriggerEnter()
    {
        GameManager.Self.CoinCollected(transform.gameObject);
    }
}
