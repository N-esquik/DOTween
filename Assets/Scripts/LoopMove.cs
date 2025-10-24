using DG.Tweening;
using UnityEngine;

public class LoopMove : MonoBehaviour
{
    [SerializeField] private Vector3 _position;

    private void Start()
    {
        transform.DOMove(_position, Init.Duration)
            .SetLoops(Init.Repeats, LoopType.Yoyo)
            .SetDelay(Init.Delay)
            .SetEase(Ease.Linear);
    }
}
