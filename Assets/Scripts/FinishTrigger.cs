using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviour _playerBehaviour = other.attachedRigidbody.GetComponent<PlayerBehaviour>();
        if (_playerBehaviour != null)
        {
            _playerBehaviour.StartFinishBehaviour();
            FindObjectOfType<GameManager>().ShowEndWindow();
        }
    }
}
