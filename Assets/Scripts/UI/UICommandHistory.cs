using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WA.UI
{
    public class UICommandHistory : MonoBehaviour
    {
        [SerializeField] private UICommandHistoryItem _historyItemPrefab;

        public void AddCommand(string str)
        {
            UICommandHistoryItem item = Instantiate(_historyItemPrefab, transform);
            item.Init(str);
        }
    }
}