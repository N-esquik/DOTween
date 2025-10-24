using DG.Tweening;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;

    private void Start()
    {
        transform.DORotate(_rotation, Init.Duration, RotateMode.FastBeyond360)
            .SetLoops(Init.Repeats, LoopType.Restart)
            .SetEase(Ease.Linear)
            .SetDelay(Init.Delay);
    }
}
