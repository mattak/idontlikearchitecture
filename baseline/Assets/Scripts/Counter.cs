using UnityEngine;
using UnityEngine.UI;

namespace Baseline
{
    public class Counter : MonoBehaviour
    {
        [SerializeField] private Button Button = default;
        [SerializeField] private Text Text = default;

        void Start()
        {
            var count = PlayerPrefs.GetInt("Count", 0);
            this.RenderCount(count);

            this.Button.onClick.AddListener(() =>
            {
                count += 1;
                PlayerPrefs.SetInt("Count", count);
                this.RenderCount(count);
            });
        }

        private void RenderCount(int value)
        {
            this.Text.text = value.ToString();
        }
    }
}