using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class EffectText : MonoBehaviour
{
    [SerializeField] Text _text;

    public const string NewText = "Почему фигуры сходят с ума ?";
    public const string AddText = "А это DOTween";
    public const string ChangeText = "Хорошо им, и вам хорошего дня!";

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(NewText, Init.Duration)).SetDelay(Init.Delay)
                .Append(_text.DOText(AddText, Init.Duration).SetRelative().SetDelay(Init.Delay))
                .Append(_text.DOText(ChangeText, Init.Duration, true, ScrambleMode.All).SetDelay(Init.Delay));
    }
}
