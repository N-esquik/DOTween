using DG.Tweening;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private Vector3 _scale;

    private void Start()
    {
        transform.DOScale(_scale, Init.Duration)
            .SetLoops(Init.Repeats, LoopType.Yoyo)
            .SetEase(Ease.Linear)
            .SetDelay(Init.Delay);
    }
}
