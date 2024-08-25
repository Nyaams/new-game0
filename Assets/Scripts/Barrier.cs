using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] GameObject _BarrierEffectPrefab;
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier _playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if(_playerModifier != null)
        {
            _playerModifier.HitBarrier();
            Destroy(gameObject);
            Instantiate(_BarrierEffectPrefab, transform.position, transform.rotation);
        }
    }
}
