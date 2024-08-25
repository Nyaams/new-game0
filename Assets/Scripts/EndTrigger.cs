using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviour _playerBehaviour = other.attachedRigidbody.GetComponent<PlayerBehaviour>();
        if (_playerBehaviour != null)
        {
            _playerBehaviour.StartEndingBehaviour();
        }
    }
}
