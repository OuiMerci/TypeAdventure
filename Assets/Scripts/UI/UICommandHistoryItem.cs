using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace WA.UI
{
    public class UICommandHistoryItem : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private float _lifeTime;
        [SerializeField] private float _fadeOutDuration;

        private float _birthTime;

        public void Update()
        {
            if(_birthTime + _lifeTime > Time.time)
            {
                StartCoroutine(DisappearanceCoroutine());
            }
        }

        public void Init(string str)
        {
            _text.text = str;
            _birthTime = Time.time;
        }

        private IEnumerator DisappearanceCoroutine()
        {
            float timeElapsed = 0;

            while(timeElapsed < _fadeOutDuration)
            {
                float newAlpha = Mathf.Lerp(1, 0, timeElapsed / _fadeOutDuration);
                ApplyNewAlpha(newAlpha);
                timeElapsed += Time.deltaTime;

                yield return null;
            }

            GameObject.Destroy(gameObject);
        }

        private void ApplyNewAlpha(float newAlpha)
        {
            Color tempColor = _text.color;
            tempColor.a = newAlpha;
            _text.color = tempColor;
        }
    }
}