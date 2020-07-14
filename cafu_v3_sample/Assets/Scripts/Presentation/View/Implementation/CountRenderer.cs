using Presentation.View.Interface;
using UnityEngine;
using UnityEngine.UI;

namespace Presentation.View.Implement
{
    [RequireComponent(typeof(Text))]
    public class CountRenderer: MonoBehaviour, IText
    {
        public void Render(string text)
        {
            this.GetComponent<Text>().text = text;
        }
    }
}