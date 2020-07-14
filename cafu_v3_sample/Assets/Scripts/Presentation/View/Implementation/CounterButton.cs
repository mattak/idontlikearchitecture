using System;
using Presentation.View.Interface;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Presentation.View.Implement
{
    [RequireComponent(typeof(Button))]
    public class CounterButton : MonoBehaviour, IButton
    {
        public IObservable<Unit> ClickAsObservable() => this.GetComponent<Button>().OnClickAsObservable();
    }
}