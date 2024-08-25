using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] PlayerMove _playerMove;
    [SerializeField] EndingBehaviour _endingBehaviour;
    [SerializeField] Animator _animator;
    void Start()
    {
        _playerMove.enabled = false;
        _endingBehaviour.enabled = false;
    }
    public void Play()
    {
        _playerMove.enabled = true;
    }
    public void StartEndingBehaviour() {
        _playerMove.enabled = false;
        _endingBehaviour.enabled = true;
    }
    public void StartFinishBehaviour()
    {
        _endingBehaviour.enabled = false;
        _animator.SetTrigger("Dance");
    }

}
