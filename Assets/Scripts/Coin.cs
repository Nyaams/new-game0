using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float _rotationSpeed;
    [SerializeField] GameObject _effectPrefab;

    void Update()
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinStatistics>().AddCoin();
        Destroy(gameObject);
        Instantiate(_effectPrefab, transform.position, transform.rotation);
    }
}
