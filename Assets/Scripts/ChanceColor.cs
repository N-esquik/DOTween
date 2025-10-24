using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ChanceColor : MonoBehaviour
{
    [SerializeField] SpriteRenderer _sprite;
    [SerializeField] ChanceColor _color;

    private void Awake()
    {
        _sprite = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _sprite.DOColor(Color.yellow, Init.Duration)
               .SetLoops(Init.Repeats, LoopType.Yoyo)
               .SetEase(Ease.Linear);
    }
}
